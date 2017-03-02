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
    public partial class frmTodoEdit : Form
    {
        #region Enumerations

        public enum TodoEditFormType
        {
            CreateItem = 1,
            EditItem = 2
        }
    
        #endregion

        #region Member Variables

        private TodoItem m_TodoItem = null;

        private TodoEditFormType m_FormType = TodoEditFormType.EditItem;

        private bool m_blCloseForm = false;

        #endregion

        #region Construction/Initialization

        /// <summary>
        /// Constructor
        /// </summary>
        public frmTodoEdit(TodoEditFormType formType, TodoItem item)
        {
            try
            {
                InitializeComponent();

                m_FormType = formType;
                m_TodoItem = item;
            }
            catch (Exception err)
            {
                ErrorHandler.ShowErrorMessage(err, "Error in Constructor function of frmTodoEdit form.");
            }
        }

        /// <summary>
        /// Handles the Form Load event of the frmTodoEdit form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmTodoEdit_Load(object sender, EventArgs e)
        {
            try
            {
                InitFormUI();
                LoadTodoItem();

                dtpDeadline.Focus();

                if (lblDeadlineWarning.Visible)                
                    MessageBox.Show("Warning!! The deadline is past for this Todo item.", "Deadline Past", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);                
            }            
            catch (Exception err)
            {
                ErrorHandler.ShowErrorMessage(err, "Error in frmTodoEdit_Load function of frmTodoEdit form.");
            }
}

        /// <summary>
        /// Initializes the appropriate controls/UI in the form based on whether the form is used to create new Todo items or edit 
        /// existing Todo items.
        /// </summary>
        private void InitFormUI()
        {
            try
            {
                if (m_FormType == TodoEditFormType.CreateItem)
                {
                    this.Text = "Create Todo Item";
                }
                else
                {
                    this.Text = "View/Edit Todo Item";
                }//end if
            }
            catch (Exception err)
            {
                ErrorHandler.ShowErrorMessage(err, "Error in InitFormUI function of frmTodoEdit form.");
            }
        }


        #endregion

        #region Todo Item Data Loading and Updating Functions

        /// <summary>
        /// Loads the data associated with the TodoItem linked to the form into the appropriate controls in the form.
        /// </summary>
        private void LoadTodoItem()
        {
            try
            {
                if (m_FormType == TodoEditFormType.EditItem)
                {
                    dtpDeadline.Value = m_TodoItem.Deadline;
                    chbCompleted.Checked = m_TodoItem.Completed;
                    txtTask.Text = m_TodoItem.Task;
                    txtDetails.Text = m_TodoItem.Details;
                }
                else
                {
                    dtpDeadline.Value = DateTime.Now.AddDays(1);
                    chbCompleted.Checked = false;
                    txtTask.Text = "";
                    txtDetails.Text = "";
                }//end if

                UpdateUI();       
            }
            catch (Exception err)
            {
                ErrorHandler.ShowErrorMessage(err, "Error in LoadTodoItem function of frmTodoEdit form.");
            }
        }

        /// <summary>
        /// Updates the TodoItem linked to the form with the current data set in the controls in the form.
        /// </summary>
        private void UpdateTodoItem()
        {
            try
            {                
                m_TodoItem.Deadline = dtpDeadline.Value;
                m_TodoItem.Completed = chbCompleted.Checked;
                m_TodoItem.Task = txtTask.Text;
                m_TodoItem.Details = txtDetails.Text;

                if (m_TodoItem.ItemStatus == TodoModelItemStatus.Unmodified)
                    m_TodoItem.ItemStatus = TodoModelItemStatus.Modified;
            }
            catch (Exception err)
            {
                ErrorHandler.ShowErrorMessage(err, "Error in UpdateTodoItem function of frmTodoEdit form.");
            }
        }

        #endregion

        #region Todo Item Editor Form Control General Functions, Event Handlers

        /// <summary>
        /// Updates UI after deadline date is changed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtpDeadline_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                UpdateUI();
            }
            catch (Exception err)
            {
                ErrorHandler.ShowErrorMessage(err, "Error in dtpDeadline_ValueChangedfunction of frmTodoEdit form.");
            }
        }

        /// <summary>
        /// Updates UI after task completion check is changed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chbCompleted_CheckChanged(object sender, EventArgs e)
        {
            try
            {
                UpdateUI();
            }
            catch (Exception err)
            {
                ErrorHandler.ShowErrorMessage(err, "Error in chbCompleted_CheckChanged function of frmTodoEdit form.");
            }
        }

        /// <summary>
        /// Updates the appropriate controls in the form according to the current settings of various controls in the form.
        /// </summary>
        private void UpdateUI()
        {
            try
            {
                //Updates appropriate controls with respect to deadline and task completion settings.
                if (dtpDeadline.Value < DateTime.Now && !chbCompleted.Checked)
                    lblDeadlineWarning.Visible = true;
                else
                    lblDeadlineWarning.Visible = false;
            }
            catch (Exception err)
            {
                ErrorHandler.ShowErrorMessage(err, "Error in UpdateDeadlineUI function of frmTodoEdit form.");
            }
        }

        #endregion

        #region Form Command Control Functions, Event Handlers

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                UpdateTodoItem();
                                                
                this.DialogResult = DialogResult.OK;
                m_blCloseForm = true;
                this.Close();
            }
            catch (Exception err)
            {
                ErrorHandler.ShowErrorMessage(err, "Error in btnOK_Click function of frmTodoEdit form.");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Close form without saving changes?", "Cancel", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    this.DialogResult = DialogResult.Cancel;
                    m_blCloseForm = true;
                    this.Close();
                }//end if
            }
            catch (Exception err)
            {
                ErrorHandler.ShowErrorMessage(err, "Error in btnCancel_Click function of frmTodoEdit form.");
            }
        }

        #endregion

        #region Form General Functions, Event Handlers

        /// <summary>
        /// Handles the FormClosing event of the TodoEdit form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmTodoEdit_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (e.CloseReason == CloseReason.UserClosing && !m_blCloseForm)
                {
                    btnOK_Click(btnOK, EventArgs.Empty);
                    e.Cancel = true;
                }
            }
            catch (Exception err)
            {
                ErrorHandler.ShowErrorMessage(err, "Error in frmTodoEdit_FormClosing function of frmTodoEdit form.");
            }
        }



        #endregion

        
    }
}
