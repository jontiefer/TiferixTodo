using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Tiferix.Global;
using Tiferix.TodoData;

namespace Tiferix.TodoModel
{
    public enum TodoModelItemStatus
    {
        Unmodified = 0,
        New = 1,
        Modified = 2,
        Deleted = 3,
        Detached = 4
    }

    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Method)]
    public class ExcludeAttribute : Attribute
    {
    }

    public abstract class DataModelList<ObjType> : IEnumerable<ObjType>
    {
        #region Member Variables

        protected TodoDB m_dsSource = null;
        protected List<ObjType> m_lstItems = new List<ObjType>();

        protected bool m_blAccessDataSource = true;

        #endregion

        #region Construction/Initialization

        /// <summary>
        /// Constructor
        /// </summary>
        public DataModelList()
        {
            try
            {
                m_dsSource = new TodoData.TodoDB();
            }
            catch (Exception err)
            {
                ErrorHandler.ShowErrorMessage(err, "Error in Constructor Overload 1 function of DataModelList class.");
            }
        }

        /// <summary>
        /// Constructor
        /// </summary>
        public DataModelList(TodoDB dsSource)
        {
            try
            {
                m_dsSource = dsSource;
            }
            catch (Exception err)
            {
                ErrorHandler.ShowErrorMessage(err, "Error in Constructor Overload 2 function of DataModelList class.");
            }
        }

        /// <summary>
        /// Constructor
        /// </summary>
        internal DataModelList(List<ObjType> items, bool blAccessDataSource = true)
            : base()
        {
            try
            {
                m_lstItems.AddRange(items);
                m_blAccessDataSource = blAccessDataSource;
            }
            catch (Exception err)
            {
                ErrorHandler.ShowErrorMessage(err, "Error in Constructor Overload 1 function of DataModelList class.");
            }
        }

        #endregion

        #region Data Model List Item Retrieval and Enumeration Properties, Functions

        /// <summary>
        /// Finds the item in the TodoModelList class that matches the item's primary key specified in the function.
        /// </summary>
        /// <param name="iKey">Primary Key</param>
        /// <returns></returns>
        public abstract ObjType GetItem(int iKey);

        /// <summary>
        /// Finds the TodoItem in the TodoList class at the specified index in the TodoList.
        /// </summary>
        /// <param name="iIndex">Index of Todo Item to retrieve.</param>
        /// <returns></returns>
        public virtual ObjType GetByIndex(int iIndex)
        {
            try
            {
                ObjType item = m_lstItems[iIndex];
                return item;
            }
            catch (Exception err)
            {
                ErrorHandler.ShowErrorMessage(err, "Error in GetByIndex function of DataModelList class.");
                return default(ObjType);
            }
        }

        public IEnumerator<ObjType> GetEnumerator()
        {
            return m_lstItems.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return m_lstItems.GetEnumerator();
        }

        public IList<ObjType> Items
        {
            get
            {
                return m_lstItems.ToList();
            }
        }

        #endregion

        #region Data Model List Utility Properties, Functions

        /// <summary>
        /// Clears the list of all items and the underlying data source of all data.
        /// </summary>
        public virtual void Clear()
        {
            try
            {
                m_lstItems.Clear();
                m_dsSource.Clear();
            }
            catch (Exception err)
            {
                ErrorHandler.ShowErrorMessage(err, "Error in Clear function of DataModelList class.");
            }
        }

        #endregion

        #region Data Model List Information Properties, Functions

        /// <summary>
        /// Indicates if the specified item is contained in the data model list.
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public bool Contains(ObjType item)
        {
            try
            {
                return m_lstItems.Contains(item);
            }
            catch (Exception err)
            {
                ErrorHandler.ShowErrorMessage(err, "Error in Contains function of DataModelList class.");
                return false;
            }
        }

        /// <summary>
        /// Gets the count of all items in the data model list.
        /// </summary>
        public int Count
        {
            get
            {
                return m_lstItems.Count;
            }
        }

        #endregion        
    }

    public abstract class TodoModelItem
    {
        protected DataRow m_source = null;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="rowSource"></param>
        public TodoModelItem(DataRow rowSource)
        {
            try
            {
                m_source = rowSource;
                ItemStatus = TodoModelItemStatus.Unmodified;
            }
            catch (Exception err)
            {
                ErrorHandler.ShowErrorMessage(err, "Error in Constructor Overload 1 of TodoModelItem class.");
            }
        }

        /// <summary>
        /// Constructor.  This version of constructor should only be used for unit testing.
        /// </summary>
        public TodoModelItem()
        {
            try
            {
                ItemStatus = TodoModelItemStatus.Unmodified;
            }
            catch (Exception err)
            {
                ErrorHandler.ShowErrorMessage(err, "Error in Constructor Overload 2 of TodoModelItem class.");
            }
        }

        [Exclude]
        public TodoModelItemStatus ItemStatus { get; set; }

        /// <summary>
        /// Syncs all data from the underlying row/record source linked to the model to the Todo data model class.
        /// </summary>
        public void SyncDataToClass()
        {
            try
            {
                // Get array of class properties.
                var properties = this.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance);

                foreach (var p in properties)
                {
                    ExcludeAttribute attr = p.GetCustomAttribute<ExcludeAttribute>();
                    bool blBypass = (attr == null) ? false : true;

                    if (!blBypass)
                    {
                        string strFieldName = p.Name;
                        p.SetValue(this, Convert.ChangeType(m_source[strFieldName], p.PropertyType));
                    }//end if
                }//next p                
            }
            catch (Exception err)
            {
                ErrorHandler.ShowErrorMessage(err, "Error in SyncDataToClass function of TodoDataModel class.");
            }
        }

        /// <summary>
        /// Syncs all data in the Todo data model class to the underlying row/record source linked to the model.
        /// </summary>
        public void SyncDataToSource()
        {
            try
            {
                // Get array of class properties.
                var properties = this.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance);

                foreach (var p in properties)
                {
                    ExcludeAttribute attr = p.GetCustomAttribute<ExcludeAttribute>();
                    bool blBypass = (attr == null) ? false : true;

                    if (!blBypass)
                    {
                        string strFieldName = p.Name;
                        var value = p.GetValue(this, null);

                        m_source[strFieldName] = value;
                    }//end if
                }//next p                
            }
            catch (Exception err)
            {
                ErrorHandler.ShowErrorMessage(err, "Error in SyncDataToSource function of TodoDataModel class.");
            }
        }

        /// <summary>
        /// Retrieves the underlying data row/record source linked to the Todo data model item class.
        /// </summary>
        /// <returns></returns>
        public DataRow GetRowSource()
        {
            try
            {
                return m_source;
            }
            catch (Exception err)
            {
                ErrorHandler.ShowErrorMessage(err, "Error in GetRowSource function of TodoDataModel class.");
                return null;
            }
        }
    }

    public class User : TodoModelItem
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="rowSource"></param>
        public User(DataRow rowSource) :
            base(rowSource)
        {
        }

        /// <summary>
        /// Constructor.  This version of constructor should only be used for unit testing.
        /// </summary>
        public User()
            : base()
        {
        }

        public int UserID { get; set; }
        public string UserName { get; set; }
    }

    public class TodoItem : TodoModelItem
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="rowSource"></param>
        public TodoItem(DataRow rowSource) :
            base(rowSource)
        {
        }

        /// <summary>
        /// Constructor.  This version of constructor should only be used for unit testing.
        /// </summary>
        public TodoItem()
            : base()
        {
        }

        public int TodoID { get; set; }

        public string Task { get; set; }

        public DateTime Deadline { get; set; }

        public bool Completed { get; set; }

        public string Details { get; set; }

        public int UserID { get; set; }
    }
}
