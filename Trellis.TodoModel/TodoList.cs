using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tiferix.Global;
using Trellis.TodoData;

namespace Trellis.TodoModel
{
    public interface ITodoList
    {
        TodoItem NewTodoItem();
        void AddItem(TodoItem item);
        TodoItem GetByIndex(int iIndex);
        TodoItem GetItem(int iTodoID);

        void DeleteByIndex(int iIndex);
        void DeleteItem(int iTodoID);
        void Load(User user);
        IList<TodoItem> Items { get; }
        bool Contains(int iKeyID);
        void Clear();
        int Count { get; }
        int Update();
    }

    public class TodoList : DataModelList<TodoItem>, IEnumerable<TodoItem>, ITodoList
    {
        #region Member Variables

        private User m_User = null;
        //private List<TodoItem> m_lstTodoItems = new List<TodoItem>();
        private List<TodoItem> m_lstDelTodoItems = new List<TodoItem>();
        
        #endregion

        #region Properties
        #endregion

        #region Construction/Initialization       

        /// <summary>
        /// Constructor
        /// </summary>
        public TodoList()
            : base()
        {
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="dsSource"></param>
        public TodoList(object dsSource)
            : base((TodoDB)dsSource)
        {
        }

        /// <summary>
        /// Constructor.  This constructor will be used for unit testing.
        /// </summary>
        public TodoList(List<TodoItem> items, bool blAccessDataSource = true)
            : base(items, blAccessDataSource)
        {
            try
            {
            }
            catch (Exception err)
            {
                ErrorHandler.ShowErrorMessage(err, "Error in Constructor Overload 3 function of DataModelList class.");
            }
        }

        #endregion

        #region Todo List Loading Properties, Functions

        /// <summary>
        /// Loads all the Todo items for the specified user into the TodoList class from the underlying data source.
        /// </summary>
        /// <param name="user">The user whose Todo items to load into the TodoList class.</param>
        public void Load(User user)
        {
            try
            {
                Clear();

                m_User = user;
                TodoDataSync.LoadTodoItems(user.UserID, m_dsSource.TodoItems);

                foreach (TodoDB.TodoItemsRow rowTodoItem in m_dsSource.TodoItems)
                {
                    TodoItem todo = new TodoItem(rowTodoItem);
                    todo.SyncDataToClass();
                    todo.ItemStatus = TodoModelItemStatus.Unmodified;

                    //m_lstTodoItems.Add(todo);
                    m_lstItems.Add(todo);
                }//next rowTodoItem                
            }
            catch (Exception err)
            {
                ErrorHandler.ShowErrorMessage(err, "Error in Load function of TodoList class.");
            }
        }

        #endregion

        #region Todo List Creation, Addition, Deletion Properties, Functions

        /// <summary>
        /// Creates a new TodoItem which can be added to the TodoList and links the TodoItem to the underlying data row source of the TodoList.
        /// </summary>
        /// <returns></returns>
        public TodoItem NewTodoItem()
        {
            try
            {
                //NOTE: In production code a counter table would be used instead.
                TodoItem item = new TodoModel.TodoItem(m_dsSource.TodoItems.NewTodoItemsRow());
                item.ItemStatus = TodoModelItemStatus.Detached;
                item.UserID = m_User.UserID;

                return item;
            }
            catch (Exception err)
            {
                ErrorHandler.ShowErrorMessage(err, "Error in NewTodoItem function of TodoList class.");
                return null;
            }
        }

        /// <summary>
        /// Adds a new Todo Item to the TodoList and marks the item to be created in the underlying data source.
        /// </summary>
        public void AddItem(TodoItem item)
        {
            try
            {
                item.ItemStatus = TodoModelItemStatus.New;
                item.TodoID = GetNextTodoID();

                m_lstItems.Add(item);
            }
            catch (Exception err)
            {
                ErrorHandler.ShowErrorMessage(err, "Error in AddItem function of TodoList class.");
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="iIndex"></param>
        public void DeleteByIndex(int iIndex)
        {
            try
            {
                TodoItem item = GetByIndex(iIndex);
                DeleteItem(item.TodoID);
            }
            catch (Exception err)
            {
                ErrorHandler.ShowErrorMessage(err, "Error in DeleteByIndex function of TodoList class.");
            }
        }

        /// <summary>
        /// Deletes the Todo item in the list that matches the TodoItem's primary key specified in the function.  The Todo Item will be also marked
        /// for deletion in the underlying data source of the class.
        /// </summary>
        /// <param name="iTodoID">TodoItem Primary Key</param>
        public void DeleteItem(int iTodoID)
        {
            try
            {
                TodoItem item = GetItem(iTodoID);

                if (item.ItemStatus != TodoModelItemStatus.New)
                    m_lstDelTodoItems.Add(item);

                m_lstItems.Remove(item);
                item.ItemStatus = TodoModelItemStatus.Deleted;
            }
            catch (Exception err)
            {
                ErrorHandler.ShowErrorMessage(err, "Error in DeleteItem function of TodoList class.");
            }
        }

        #endregion

        #region Todo List Item Retrieval and Enumeration Properties, Functions

        /// <summary>
        /// Finds the TodoItem in the TodoList class that matches the TodoItem's primary key specified in the function.
        /// </summary>
        /// <param name="iTodoID">TodoItem Primary Key</param>
        /// <returns></returns>
        public override TodoItem GetItem(int iKey)
        {
            try
            {
                TodoItem item = m_lstItems.Find(t => t.TodoID == iKey);
                return item;
            }
            catch (Exception err)
            {
                ErrorHandler.ShowErrorMessage(err, "Error in GetItem function of TodoList class.");
                return null;
            }
        }

        #endregion


        #region Todo List Utility Properties, Functions

        /// <summary>
        /// Clears the list of all TodoItems and the underlying data source of all data.
        /// </summary>
        public override void Clear()
        {
            try
            {
                base.Clear();

                m_User = null;
                m_lstDelTodoItems.Clear();                
            }
            catch (Exception err)
            {
                ErrorHandler.ShowErrorMessage(err, "Error in Clear function of TodoList class.");
            }
        }

        /// <summary>
        /// Retrieves the next available TodoID to assign to a new TodoItem record.        
        /// </summary>
        /// <returns></returns>
        protected int GetNextTodoID()
        {
            try
            {
                if (m_blAccessDataSource)
                    return TodoDataSync.GetCounterID("TodoID");
                else
                {
                    if (m_lstItems.Count > 0)
                        return m_lstItems.Max(t => t.TodoID) + 1;
                    else
                        return 1;
                }//end if
            }
            catch (Exception err)
            {
                ErrorHandler.ShowErrorMessage(err, "Error in GetNextTodoID function of TodoList class.");
                return -1;
            }
        }

        #endregion

        #region Todo List Information Properties, Functions

        /// <summary>
        /// Indicates if a Todo Item with the specified TodoId is contained in the TodoList.
        /// </summary>
        /// <param name="iTodoID">TodoID to search.</param>
        /// <returns></returns>
        public bool Contains(int iTodoID)
        {
            try
            {
                return (m_lstItems.FirstOrDefault(t => t.TodoID == iTodoID) != null);
            }
            catch (Exception err)
            {
                ErrorHandler.ShowErrorMessage(err, "Error in Contains function of TodoList class.");
                return false;
            }
        }

        #endregion

        #region Todo List Data Updating Properties, Functions

        /// <summary>
        /// Updates all changes to the Todo items made in the TodoList class to the class's underlying data source.
        /// </summary>
        /// <returns>Success: Returns number of records updated, Failure: -1</returns>
        public int Update()
        {
            try
            {
                IEnumerable<TodoItem> lstNewTodoItems = m_lstItems.Where(t => t.ItemStatus == TodoModelItemStatus.New);
                IEnumerable<TodoItem> lstModTodoItems = m_lstItems.Where(t => t.ItemStatus == TodoModelItemStatus.Modified);

                foreach (TodoItem item in lstNewTodoItems)
                {
                    item.SyncDataToSource();
                    m_dsSource.TodoItems.AddTodoItemsRow((TodoDB.TodoItemsRow)item.GetRowSource());
                }//next item

                foreach (TodoItem item in lstModTodoItems)
                {
                    item.SyncDataToSource();
                }//next item                        

                foreach (TodoItem item in m_lstDelTodoItems)
                {
                    ((TodoDB.TodoItemsRow)item.GetRowSource()).Delete();
                }//next item                

                int iRowCount = TodoDataSync.UpdateTodoItems(m_dsSource.TodoItems);

                m_lstItems.ForEach(t => t.ItemStatus = TodoModelItemStatus.Unmodified);
                m_lstDelTodoItems.Clear();

                return iRowCount;
            }
            catch (Exception err)
            {
                ErrorHandler.ShowErrorMessage(err, "Error in Update Overload 1 function of TodoList class.");
                return -1;
            }
        }

        #endregion
    }
}
