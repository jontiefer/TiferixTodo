using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tiferix.Global;
using Tiferix.TodoData;

namespace Tiferix.TodoModel
{
    public interface IUserList
    {
        void Load();
        void Clear();
        IList<User> Items { get; }
        bool Contains(int iUserID);
        int Count { get; }
                        
    }

    //NOTE: In product version, I would allow creating, deleting and editing of users.
    public class UserList : DataModelList<User>, IUserList, IEnumerable<User>
    {
        #region Member Variables

        #endregion

        #region Construction/Initialization        

        /// <summary>
        /// Constructor
        /// </summary>
        public UserList()
            :base()
        {
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="dsSource"></param>
        public UserList(object dsSource)
            :base((TodoDB) dsSource)
        {
        }

        #endregion

        #region User Loading and Initialization Properties, Functions        

        /// <summary>
        /// Loads all the users into the UserList class from the underlying data source.
        /// </summary>        
        public void Load()
        {
            try
            {
                Clear();

                TodoDataSync.LoadUsers(m_dsSource.Users);

                foreach (TodoDB.UsersRow rowUser in m_dsSource.Users)
                {
                    User user = new TodoModel.User(rowUser);
                    user.SyncDataToClass();
                    user.ItemStatus = TodoModelItemStatus.Unmodified;

                    m_lstItems.Add(user);
                }//next rowTodoItem                
            }
            catch (Exception err)
            {
                ErrorHandler.ShowErrorMessage(err, "Error in Load function of UserList class.");
            }
        }

        #endregion

        #region User List Item Retrieval and Enumeration Properties, Functions

        /// <summary>
        /// Finds the User in the UserList class that matches the User's primary key specified in the function.
        /// </summary>
        /// <param name="iUserID">User Primary Key</param>
        /// <returns></returns>
        public override User GetItem(int iKey)
        {
            try
            {
                User user = m_lstItems.Find(u => u.UserID == iKey);
                return user;
            }
            catch (Exception err)
            {
                ErrorHandler.ShowErrorMessage(err, "Error in GetItem function of UserList class.");
                return null;
            }
        }

        #endregion

        #region User List Utility Properties, Functions

        #endregion

        #region User List Information Properties, Functions       

        /// <summary>
        /// Indicates if a User with the specified UserId is contained in the UserList.
        /// </summary>
        /// <param name="iUserID">UserID to search.</param>
        /// <returns></returns>
        public bool Contains(int iUserID)
        {
            try
            {
                return (m_lstItems.First(u => u.UserID == iUserID) != null);
            }
            catch (Exception err)
            {
                ErrorHandler.ShowErrorMessage(err, "Error in Contains function of UserList class.");
                return false;
            }
        }

        #endregion
    }
}
