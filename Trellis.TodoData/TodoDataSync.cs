using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tiferix.Global;

namespace Trellis.TodoData
{
    public class TodoDataSync
    {
        /// <summary>
        /// Loads all Todo Items records for the specified user from the TodoItems table in the database.
        /// </summary>
        /// <param name="iUserID"></param>
        /// <param name="dtTodoItems"></param>
        public static void LoadTodoItems(int iUserID, TodoData.TodoDB.TodoItemsDataTable dtTodoItems)
        {
            try
            {
                TodoDBTableAdapters.TodoItemsTableAdapter daTodoItems = new TodoDBTableAdapters.TodoItemsTableAdapter();                
                daTodoItems.Adapter.SelectCommand = new SqlCommand("SELECT * FROM dbo.TodoItems WHERE UserID = @UserID");
                daTodoItems.Adapter.SelectCommand.Parameters.AddWithValue("@UserID", iUserID);
                daTodoItems.Adapter.SelectCommand.Connection = daTodoItems.Connection;
                daTodoItems.Adapter.Fill(dtTodoItems);
            }
            catch (Exception err)
            {
                ErrorHandler.ShowErrorMessage(err, "Error in LoadTodoItems function of TodoDataSync class.");
            }
        }

        /// <summary>
        /// Loads all User records from the Users table in the database.
        /// </summary>
        /// <param name="dtUsers"></param>
        public static void LoadUsers(TodoDB.UsersDataTable dtUsers)
        {
            try
            {
                TodoDBTableAdapters.UsersTableAdapter daUsers = new TodoDBTableAdapters.UsersTableAdapter();
                daUsers.Fill(dtUsers);
            }
            catch (Exception err)
            {
                ErrorHandler.ShowErrorMessage(err, "Error in LoadUsers function of TodoDataSync class.");
            }
        }

        /// <summary>
        /// Updates all changes in the Users data table to the Users table in the TodoDB database.
        /// </summary>
        /// <param name="dtUsers"></param>
        /// <returns></returns>
        public static int UpdateUsers(TodoDB.UsersDataTable dtUsers)
        {
            try
            {
                TodoDBTableAdapters.UsersTableAdapter daUsers = new TodoDBTableAdapters.UsersTableAdapter();
                return daUsers.Update(dtUsers);
            }
            catch (Exception err)
            {
                ErrorHandler.ShowErrorMessage(err, "Error in UpdateUsers function of TodoDataSync class.");
                return -1;
            }
        }

        /// <summary>
        /// Updates all changes in the TodoItems data table to the TodoItems table in the TodoDB database.
        /// </summary>
        /// <param name="dtTodoItems"></param>
        public static int UpdateTodoItems(TodoDB.TodoItemsDataTable dtTodoItems)
        {
            try
            {
                TodoDBTableAdapters.TodoItemsTableAdapter daTodoItems = new TodoDBTableAdapters.TodoItemsTableAdapter();
                return daTodoItems.Update(dtTodoItems);
            }
            catch (Exception err)
            {
                ErrorHandler.ShowErrorMessage(err, "Error in UpdateTodoItems function of TodoDataSync class.");
                return -1;
            }
        }

        /// <summary>
        /// Retrieves the next available ID for the specified field from the Counter table in the database.
        /// </summary>
        /// <param name="strFieldName"></param>
        /// <returns></returns>
        public static int GetCounterID(string strFieldName)
        {
            SqlConnection connTodoItems = null;

            try
            {
                connTodoItems = new SqlConnection(Properties.Settings.Default.TodoDBConnectionString);
                connTodoItems.Open();

                SqlCommand cmdSelect = connTodoItems.CreateCommand();
                cmdSelect.CommandText = "SELECT [" + strFieldName + "] FROM dbo.Counter";
                int iNextTodoID = (int)cmdSelect.ExecuteScalar();
                cmdSelect.Dispose();

                SqlCommand cmdUpdate = connTodoItems.CreateCommand();
                cmdUpdate.CommandText = "UPDATE Counter Set [" + strFieldName + "] = " + Convert.ToString(iNextTodoID + 1);
                cmdUpdate.ExecuteNonQuery();
                cmdUpdate.Dispose();

                connTodoItems.Close();
                connTodoItems = null;

                return iNextTodoID;
            }
            catch (Exception err)
            {
                ErrorHandler.ShowErrorMessage(err, "Error in GetCounterID function of TodoDataSync class.");
                return -1;
            }
            finally
            {
                if (connTodoItems != null)
                {
                    if (connTodoItems.State == System.Data.ConnectionState.Open)
                        connTodoItems.Close();
                }
            }
        }
    }
}
