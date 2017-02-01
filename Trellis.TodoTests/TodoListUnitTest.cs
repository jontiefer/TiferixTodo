using System;
using Trellis.TodoModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Trellis.TodoTests
{
    [TestClass]
    public class TodoListUnitTest
    {
        #region Member Variables
        #endregion

        #region Construction/Initialization

        /// <summary>
        /// Constructor
        /// </summary>
        public TodoListUnitTest()
        {
            GenerateMockRepoTodoList();
        }

        #endregion

        #region Moq Repository Related Properties, Functions

        /// <summary>
        /// Mock Todo List Repository for unit testing.
        /// </summary>
        public ITodoList MockRepoTodoList;

        public List<TodoItem> m_TodoItems = null;

        /* In Production code, I would include this test.
        /// <summary>
        /// Mock Users List Repository for unit testing.
        /// </summary>
        public readonly IUserList MockUserList;
        */

        private void GenerateMockRepoTodoList()
        {
            //Generate mock Todo item data.
            m_TodoItems = new List<TodoItem>
            {
                new TodoItem { TodoID = 1, Task = "Send Reports to Mr. Jones", Deadline = new DateTime(2017, 2, 15),
                                        Completed = false, Details = "These are the reports that have to do with Mr. Jones office totals.", UserID = 1,
                                        ItemStatus = TodoModelItemStatus.Unmodified },

                new TodoItem { TodoID = 2, Task = "Sign BAA with Richard Walkins", Deadline = new DateTime(2017, 3, 10),
                                        Completed = false, Details = "Business Associate Agreement with our client in the medical consulting firm.", UserID = 1,
                                        ItemStatus = TodoModelItemStatus.Unmodified },

                new TodoItem { TodoID = 3, Task = "Contact Zylex Inc For Contract Renewal", Deadline = new DateTime(2017, 5, 21),
                                        Completed = false, Details = "Our contract with Zylex Inc is due for renewal.  Top medical technology redistributor.", UserID = 1,
                                        ItemStatus = TodoModelItemStatus.Unmodified }
            };

            //Generate mock TodoList repository using Moq
            Mock<ITodoList> mockTodoList = new Mock<ITodoList>();

            SetupMoqTests(mockTodoList);
        }

        private void SetupMoqTests(Mock<ITodoList> mockTodoList)
        {
            //Return all Todo items.
            mockTodoList.Setup(mtl => mtl.Items).Returns(m_TodoItems);

            //Return a TodoItem by TodoId
            mockTodoList.Setup(mtl => mtl.GetItem(It.IsAny<int>())).Returns((int iTodoID) => m_TodoItems.Where(t => t.TodoID == iTodoID).Single());

            //Return a TodoItem by Index
            mockTodoList.Setup(mtl => mtl.GetByIndex(It.IsAny<int>())).Returns((int iIndex) => m_TodoItems[iIndex]);

            //Check if an Todo Item is contained in the TodoList
            mockTodoList.Setup(mtl => mtl.Contains(It.IsAny<int>())).Returns((int iTodoID) => (m_TodoItems.FirstOrDefault(t => t.TodoID == iTodoID) != null));

            /* NOT USED: Will Use Unit Test Instance of TodoList class instead.
            //Sets up the ability to test adding items to the Todo List
            mockTodoList.Setup(mtl => mtl.AddItem(It.IsAny<TodoItem>())).Callback((TodoItem item) => todoItems.Add(item));

            //Sets up the ability to test deleting items from the Todo List by TodoId
            mockTodoList.Setup(mtl => mtl.DeleteItem(It.IsAny<int>()));

            //Sets up the ability to test deleting items from the Todo List by Index
            mockTodoList.Setup(mtl => mtl.DeleteByIndex(It.IsAny<int>()));
            */

            //Complete the setup of the Mock TodoList Repository.
            MockRepoTodoList = mockTodoList.Object;
        }

        #endregion

        #region General Unit Test Properties
        #endregion

        [TestMethod]
        public void GetTodoListItemById()
        {
            int iTodoID = 2;

            TodoItem item = MockRepoTodoList.GetItem(iTodoID);
            
            Assert.IsNotNull(item);
            Assert.AreEqual("Sign BAA with Richard Walkins", item.Task);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void GetInvalidTodoListItemById_ShouldThrowArgumentOutOfRange()
        {            
            int iTodoID = 15;

            TodoItem item = MockRepoTodoList.GetItem(iTodoID);
            
            Assert.IsNotNull(item);
            Assert.AreEqual("Send Reports to Mr. Jones", item.Task);                   
        }

        [TestMethod]
        public void GetTodoListItemByIndex()
        {
            int iIndex = 2;

            TodoItem item = MockRepoTodoList.GetByIndex(iIndex);
            
            Assert.IsNotNull(item);
            Assert.AreEqual(3, item.TodoID);
        }

        [TestMethod]
        public void GetAllTodoListItems()
        {            
            IList<TodoItem> todoItems = MockRepoTodoList.Items;
          
            Assert.IsNotNull(todoItems);
            Assert.AreEqual(3, todoItems.Count);  
        }

        [TestMethod]
        public void ChangeTodoList_AddTodoItemToTodoList()
        {
            TodoList todoList = new TodoList(m_TodoItems);

            //Create new Todo Item
            TodoItem item = new TodoItem
            {                
                Task = "Contact attorney about BAA agreement with Sacred Star hospital.",
                Deadline = new DateTime(2017, 2, 15),
                Completed = false,
                Details = "Sacred Star hospital has requested a new BAA agreement and we need to contact Mr. Mandell to look over the agreement.",
                UserID = 1,
                ItemStatus = TodoModelItemStatus.New
            };

            int iTodoItemCount = todoList.Count;
            Assert.AreEqual(3, iTodoItemCount);

            //Add new Todo Item to mock TodoList repository.
            todoList.AddItem(item);

            iTodoItemCount = todoList.Count;
            Assert.AreEqual(4, iTodoItemCount);

            //Verify new Todo Item has been added to list and has a new TodoId assigned.
            TodoItem itemTest = todoList.GetItem(item.TodoID);
            Assert.IsNotNull(itemTest);
            Assert.IsInstanceOfType(item, typeof(TodoItem));
            Assert.IsTrue(item.Task.Contains("Sacred Star"));
            Assert.IsTrue(item.ItemStatus == TodoModelItemStatus.New);
        }

        [TestMethod]
        public void ChangeTodoList_ModifyTodoItemInTodoList()
        {
            TodoList todoList = new TodoList(m_TodoItems);

            int iTodoID = 3;

            //Find Todo Item by TodoID
            TodoItem item = todoList.GetItem(iTodoID);

            //Modify properties of the Todo Item
            item.Task = "Contact Touron International for Neuron Regeneration";
            item.Deadline = new DateTime(2021, 12, 07);
            item.ItemStatus = TodoModelItemStatus.Modified;

            //Verify changes by requering Todo Item in mock TodoList repository.
            TodoItem itemTest = todoList.GetItem(iTodoID);

            Assert.IsNotNull(itemTest);
            Assert.AreEqual("Contact Touron International for Neuron Regeneration", itemTest.Task);
            Assert.AreEqual(new DateTime(2021, 12, 07), item.Deadline);
            Assert.IsTrue(itemTest.ItemStatus == TodoModelItemStatus.Modified);
        }

        [TestMethod]
        public void ChangeTodoList_DeleteTodoItemFromTodoList()
        {
            TodoList todoList = new TodoList(m_TodoItems);
            
            int iTodoID = 2;

            //Find Todo Item by TodoID
            TodoItem item = todoList.GetItem(iTodoID);

            //Verifies Todo Item is contained in mock TodoList repository before deletion.
            int iTodoItemCount = todoList.Count;
            Assert.AreEqual(3, iTodoItemCount);
            Assert.IsTrue(todoList.Contains(iTodoID));
            
            //Delete Todo Item by specifying the item's TodoID            
            todoList.DeleteItem(iTodoID);

            //Verifies Todo Item is no longer contained in mock TodoList repository after deletion.
            iTodoItemCount = todoList.Count;
            Assert.AreEqual(2, iTodoItemCount);
            Assert.IsFalse(todoList.Contains(iTodoID));

            //Verifies the Todo Item's modification status has been marked to delete.
            Assert.IsTrue(item.ItemStatus == TodoModelItemStatus.Deleted);
        }

        [TestMethod]
        public void DetectTodoItemPastDeadline_MarkWithUrgentStatus()
        {
            DateTime datCurrent = new DateTime(2017, 4, 10);
            IEnumerable<TodoItem> todoItems = MockRepoTodoList.Items.Where(t => datCurrent > t.Deadline && !t.Completed);

            Assert.AreEqual(2, todoItems.Count());
            Assert.IsNotNull(todoItems.FirstOrDefault(t => t.TodoID == 1));
            Assert.IsNotNull(todoItems.FirstOrDefault(t => t.TodoID == 2));
        }
    }
}
