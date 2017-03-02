using DotCoolControls.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tiferix.Global;
using Tiferix.TodoModel;

namespace Tiferix.TodoUI
{
    public partial class frmMain : Form
    {
        #region Member Variables
        
        private User m_CurrentUser = null;
        private int m_iCurrentUserIndex = -1;

        private bool m_blTodoListModified = false;
        private bool m_blCloseForm = false;

        private CancelEvents m_CancelEvents = new CancelEvents();

        #endregion

        #region Member Model Variables

        private UserList m_UserList = new UserList();
        private TodoList m_TodoList = new TodoList();
        
        #endregion 

        #region Construction/Initialization

        /// <summary>
        /// Constructor
        /// </summary>
        public frmMain()
        {
            try
            {
                InitializeComponent();                                      
            }
            catch (Exception err)
            {
                ErrorHandler.ShowErrorMessage(err, "Error in Constructor function of frmMain form.");
            }
        }

        /// <summary>
        /// Handles the Form Load event of the Main form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMain_Load(object sender, EventArgs e)
        {
            try
            {
                LoadUsers();
            }
            catch (Exception err)
            {
                ErrorHandler.ShowErrorMessage(err, "Error in frmMain_Load function of frmMain form.");
            }
        }

        #endregion

        #region User Loading and Initialization Properties, Functions

        /// <summary>
        /// Loads the list of users from the Users table in the database.
        /// </summary>
        private void LoadUsers()
        {
            try
            {
                m_UserList.Clear();
                m_UserList.Load();

                m_CancelEvents.ComboBoxValueChanged = true;
                cbUsers.Items.Clear();

                foreach (User user in m_UserList)
                {
                    cbUsers.Items.Add(user.UserName);
                }//next user

                m_CancelEvents.ComboBoxValueChanged = false;


                if (m_UserList.Count > 0)
                {                    
                    cbUsers.SelectedIndex = 0;
                    LoadTodoList();
                }//end if
            }
            catch (Exception err)
            {
                ErrorHandler.ShowErrorMessage(err, "Error in LoadUsers function of frmMain form.");
            }
        }
       
        #endregion

        #region User Selection Functions, Event Handlers

        /// <summary>
        /// Loads the todo list items in the form for the selected user in the Users combobox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (m_CancelEvents.ComboBoxValueChanged)
                    return;
                                                
                if (!CheckListChanges() && m_CurrentUser != null)
                {
                    m_CancelEvents.ComboBoxValueChanged = true;
                    cbUsers.SelectedIndex = m_iCurrentUserIndex;
                    m_CancelEvents.ComboBoxValueChanged = false;

                    return;
                }//end if                

                m_CurrentUser = m_UserList.GetByIndex(cbUsers.SelectedIndex);
                m_iCurrentUserIndex = cbUsers.SelectedIndex;

                LoadTodoList();                
            }
            catch (Exception err)
            {
                ErrorHandler.ShowErrorMessage(err, "Error in rbUser_CheckedChanged function of frmTiferixSampleMain form.");
            }
        }        

        #endregion

        #region Todo List Loading and Initialization Properties, Functions

        /// <summary>
        /// Loads the TodoList items for the current user selected in the form.
        /// </summary>
        private void LoadTodoList()
        {
            try
            {                
                m_TodoList.Load(m_CurrentUser);

                gridTodoList.Rows.Clear();

                foreach (TodoItem item in m_TodoList)
                {
                    AddTodoGridRow(item);
                }//next item                

                m_blTodoListModified = false;
            }
            catch (Exception err)
            {
                ErrorHandler.ShowErrorMessage(err, "Error in LoadTodoList function of frmMain form.");
            }
        }

        #endregion

        #region Todo Item Creation and Deletion Properties, Functions

        /// <summary>
        /// Adds a new Todo Item to the Todo List data model object and to the TodoList grid.  In addition, the TodoList item will be marked to be added 
        /// to the underlying data source.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNewTodoItem_Click(object sender, EventArgs e)
        {
            try
            {                
                TodoItem item = m_TodoList.NewTodoItem();
                frmTodoEdit TodoEditForm = new frmTodoEdit(frmTodoEdit.TodoEditFormType.CreateItem, item);

                if (TodoEditForm.ShowDialog() == DialogResult.OK)
                {                    
                    m_TodoList.AddItem(item);
                    AddTodoGridRow(item);
                    m_blTodoListModified = true;
                }//end if
            }
            catch (Exception err)
            {
                ErrorHandler.ShowErrorMessage(err, "Error in btnNewTodoItem_Click function of frmMain form.");
            }
        }

        #endregion

        #region Todo Item Editing Properties, Functions

        /// <summary>
        /// Displays the TodoEdit form to edit the selected Todo item selected in the TodoList grid.  If the Todo item is modified it will be updated 
        /// in the TodoList data model object and grid, as well as marks to be updated in its underlying data source.        
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEditTodoItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (gridTodoList.SelectedRows.Count == 0)
                    return;

                DataGridViewRow rowTodoItem = gridTodoList.SelectedRows[0];
                TodoItem item = m_TodoList.GetItem((int)rowTodoItem.Cells["TodoID"].Value);

                frmTodoEdit TodoEditForm = new frmTodoEdit(frmTodoEdit.TodoEditFormType.EditItem, item);

                if (TodoEditForm.ShowDialog() == DialogResult.OK)
                {                    
                    UpdateTodoGridRow(rowTodoItem, item);
                    m_blTodoListModified = true;
                }//end if
            }
            catch (Exception err)
            {
                ErrorHandler.ShowErrorMessage(err, "Error in btnEditTodoItem_Click function of frmMain form.");
            }
        }
        
        /// <summary>
        /// Deletes the selected Todo item in the TodoList grid from both the grid and from the TodoList data model object, as well as marks it for
        /// deletion in its underlying data source.        
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDeleteTodoItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (gridTodoList.SelectedRows.Count == 0)
                    return;

                DataGridViewRow rowTodoItem = gridTodoList.SelectedRows[0];
                TodoItem item = m_TodoList.GetItem((int)rowTodoItem.Cells["TodoID"].Value);

                m_TodoList.DeleteItem(item.TodoID);
                gridTodoList.Rows.Remove(rowTodoItem);

                gridTodoList.Update();

                m_blTodoListModified = true;
            }
            catch (Exception err)
            {
                ErrorHandler.ShowErrorMessage(err, "Error in btnDeleteTodoItem_Click function of frmMain form.");
            }
        }

        #endregion

        #region Todo Grid Row Addition, Modification, Deletion Functions, Event Handlers

        /// <summary>
        /// Adds a TodoItem object as a new row to the TodoList grid in the form.
        /// </summary>
        /// <param name="item"></param>
        private void AddTodoGridRow(TodoItem item)
        {
            try
            {
                DataGridViewRow rowTodoItem = new DataGridViewRow();
                rowTodoItem.CreateCells(gridTodoList, new object[] { item.TodoID, item.Completed, item.Deadline, item.Task });

                UpdateTodoGridRowDeadline(rowTodoItem, item);

                gridTodoList.Rows.Add(rowTodoItem);                                
            }
            catch (Exception err)
            {
                ErrorHandler.ShowErrorMessage(err, "Error in AddTodoGridRow function of frmMain form.");
            }
        }

        /// <summary>
        /// Updates a TodoItem row in the TodoList grid from a TodoItem data model object passed to the function.
        /// </summary>
        /// <param name="item"></param>
        private void UpdateTodoGridRow(DataGridViewRow rowTodoItem, TodoItem item)
        {
            try
            {
                rowTodoItem.Cells["TodoID"].Value = item.TodoID;
                rowTodoItem.Cells["Completed"].Value = item.Completed;
                rowTodoItem.Cells["Deadline"].Value = item.Deadline;
                rowTodoItem.Cells["Task"].Value = item.Task;

                UpdateTodoGridRowDeadline(rowTodoItem, item);

                gridTodoList.Update();                
            }
            catch (Exception err)
            {
                ErrorHandler.ShowErrorMessage(err, "Error in UpdateTodoGridRow function of frmMain form.");
            }
        }

        /// <summary>
        /// Updates the Todo grid row item passed to the function according to whether the Todo item is past its deadline or not.
        /// </summary>
        /// <param name="rowTodoItem"></param>
        /// <param name="item"></param>
        private void UpdateTodoGridRowDeadline(DataGridViewRow rowTodoItem, TodoItem item)
        {
            try
            {
                if (item.Deadline < DateTime.Now && !item.Completed)
                {
                    rowTodoItem.DefaultCellStyle.ForeColor = Color.Red;
                    rowTodoItem.DefaultCellStyle.Font = new Font("Arial", 11.25f, FontStyle.Bold);
                }
                else
                {
                    rowTodoItem.DefaultCellStyle.ForeColor = Color.Black;
                    rowTodoItem.DefaultCellStyle.Font = new Font("Arial", 11.25f, FontStyle.Regular);
                }//end if

                gridTodoList.Update();
            }
            catch (Exception err)
            {
                ErrorHandler.ShowErrorMessage(err, "Error in UpdateTodoGridRowDeadline function of frmMain form.");
            }
        }

        #endregion

        #region Todo Grid Item Selection and Item Editing Functions, Event Handlers

        /// <summary>
        /// Handles the event when an editable cell in the grid is clicked and updates the values to the Todo Data model record associated with the 
        /// modified grid record.
        /// </summary>
        private void gridTodoList_CellValueChanged(object sender, DataGridViewCellEventArgs e)                
        {                
            try
            {
                if (e.ColumnIndex == 1 && e.RowIndex >= 0)
                {
                    DataGridViewRow rowTodoItem = gridTodoList.Rows[e.RowIndex];
                    TodoItem item = m_TodoList.GetItem((int)rowTodoItem.Cells["TodoID"].Value);

                    if ((bool)rowTodoItem.Cells["Completed"].Value != item.Completed)
                    {
                        item.Completed = (bool)rowTodoItem.Cells["Completed"].Value;
                        UpdateTodoGridRowDeadline(rowTodoItem, item);

                        if (item.ItemStatus == TodoModelItemStatus.Unmodified)
                            item.ItemStatus = TodoModelItemStatus.Modified;

                        m_blTodoListModified = true;
                    }//end if
                }//end if
            }
            catch (Exception err)
            {
                ErrorHandler.ShowErrorMessage(err, "Error in gridTodoList_CellValueChanged function of frmMain form.");
            }
        }
        private void gridTodoList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                btnEditTodoItem.PerformClick();
            }
            catch (Exception err)
            {
                ErrorHandler.ShowErrorMessage(err, "Error in gridTodoList_CellDoubleClick function of frmMain form.");
            }
        }

        #endregion

        #region Todo Item Validation and Saving Properties, Functions

        /// <summary>
        /// Checks to see if any changes have been made to the TodoList loaded in the form for the current user.  If changes have occurred the user
        /// will be prompted with a message to see if they wish to save changes before proceeding with the next operation or to cancel the next operation.
        /// </summary>        
        /// <returns>True = Proceed with operation, False = Cancel next operation until changes are saved or cancelled.</returns>
        private bool CheckListChanges()
        {
            try
            {
                if(m_blTodoListModified)
                {
                    DialogResult result = MessageBox.Show("The Todo List has been modified.  Do you wish to save changes before proceeding?",
                                                                               "Save", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        m_TodoList.Update();
                        m_blTodoListModified = false;                
                        return true;                                            
                    }
                    else if (result == DialogResult.Cancel)
                        return false;
                }//end if

                return true;
            }
            catch (Exception err)
            {
                ErrorHandler.ShowErrorMessage(err, "Error in CheckListChanges function of frmMain form.");
                return false;
            }
        }

        #endregion

        #region Form General Command Button Functions, Event Handlers

        /// <summary>
        /// Saves all changes in the TodoList that have been made in the form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                m_TodoList.Update();
                m_blTodoListModified = false;

                MessageBox.Show("Changes saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception err)
            {
                ErrorHandler.ShowErrorMessage(err, "Error in btnSave_Click function of frmMain form.");
            }
        }

        /// <summary>
        /// Exits the application, after prompting the user to save changes, if necessary.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            try
            {
                if (!CheckListChanges())
                    return;

                m_blCloseForm = true;
                this.Close();
            }
            catch (Exception err)
            {
                ErrorHandler.ShowErrorMessage(err, "Error in btnSave_Click function of frmMain form.");
            }
        }

        #endregion

        #region Form Closing Functions, Event Handlers

        /// <summary>
        /// Handles the Form Closing event of the Main form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (e.CloseReason == CloseReason.UserClosing && !m_blCloseForm)
                {
                    btnExit_Click(btnExit, EventArgs.Empty);
                    e.Cancel = true;
                }
            }
            catch (Exception err)
            {
                ErrorHandler.ShowErrorMessage(err, "Error in frmMain_FormClosing function of frmTodoEdit form.");
            }
        }







        #endregion

        
    }
}
