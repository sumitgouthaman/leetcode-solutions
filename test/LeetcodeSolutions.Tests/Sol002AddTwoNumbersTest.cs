using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace SumitGouthaman.LeetcodeSolutions.UnitTests
{
    public class Sol002AddTwoNumbersTest
    {
        private readonly Sol002AddTwoNumbers _solution;
        public Sol002AddTwoNumbersTest()
        {
            _solution = new Sol002AddTwoNumbers();
        }

        [Theory]
        [InlineData(new int[] { }, new int[] { }, new int[] { })]
        [InlineData(new int[] { 1 }, new int[] { }, new int[] { 1 })]
        [InlineData(new int[] { }, new int[] { 1 }, new int[] { 1 })]
        [InlineData(new int[] { 1 }, new int[] { 1 }, new int[] { 2 })]
        [InlineData(new int[] { 2, 5 }, new int[] { 3, 4 }, new int[] { 5, 9 })]
        [InlineData(new int[] { 7 }, new int[] { 7 }, new int[] { 4, 1 })]
        [InlineData(new int[] { 7, 1 }, new int[] { 7, 2 }, new int[] { 4, 4 })]
        [InlineData(new int[] { 7, 9 }, new int[] { 7, 2 }, new int[] { 4, 2, 1 })]
        [InlineData(new int[] { 2, 4, 3 }, new int[] { 5, 6, 4 }, new int[] { 7, 0, 8 })]
        public void AddTwoNumbers_VariousInputs_CorrectResults(int[] node1, int[] node2, int[] expectedResult)
        {
            ListNode result = _solution.AddTwoNumbers(ConvertArrayToList(node1), ConvertArrayToList(node2));
            Assert.True(ListNodeAreEqual(ConvertArrayToList(expectedResult), result),
                $"Result was: {ListNodeToString(result)}, Was expecting: {ListNodeToString(ConvertArrayToList(expectedResult))}");
        }

        [Fact]
        public void ConvertArrayToList_EmptyInput_ReturnsNull()
        {
            Assert.Null(ConvertArrayToList(new int[] { }));
        }

        [Fact]
        public void ConvertArrayToList_1ValueInInput_ReturnsListOfLength1()
        {
            var listNode = ConvertArrayToList(new int[] { 2 });
            Assert.NotNull(listNode);
            Assert.Null(listNode.next);
            Assert.Equal(2, listNode.val);
        }

        [Fact]
        public void ConvertArrayToList_2ValueInInput_ReturnsListOfLength2()
        {
            var listNode = ConvertArrayToList(new int[] { 2, 4 });
            Assert.NotNull(listNode);
            Assert.NotNull(listNode.next);
            Assert.Equal(2, listNode.val);
            Assert.Null(listNode.next.next);
            Assert.Equal(4, listNode.next.val);
        }

        [Fact]
        public void ConvertArrayToList_MultipleValueInInput_ReturnsListOfCorrectLength()
        {
            var listNode = ConvertArrayToList(new int[] { 2, 4, 5, 6 });
            Assert.NotNull(listNode);
            Assert.NotNull(listNode.next);
            Assert.Equal(2, listNode.val);
            Assert.NotNull(listNode.next.next);
            Assert.Equal(4, listNode.next.val);
            Assert.NotNull(listNode.next.next.next);
            Assert.Equal(5, listNode.next.next.val);
            Assert.Null(listNode.next.next.next.next);
            Assert.Equal(6, listNode.next.next.next.val);
        }

        [Theory]
        [InlineData(new int[] { }, new int[] { }, true)]
        [InlineData(new int[] { 1 }, new int[] { }, false)]
        [InlineData(new int[] { }, new int[] { 1 }, false)]
        [InlineData(new int[] { 2 }, new int[] { 2 }, true)]
        [InlineData(new int[] { 2 }, new int[] { 3 }, false)]
        [InlineData(new int[] { 1, 2 }, new int[] { 1, 2 }, true)]
        [InlineData(new int[] { 1, 2 }, new int[] { 2, 1 }, false)]
        [InlineData(new int[] { 3, 5, 7, 8 }, new int[] { 3, 5, 7 }, false)]
        [InlineData(new int[] { 3, 5, 7 }, new int[] { 3, 5, 7, 8 }, false)]
        [InlineData(new int[] { 3, 5, 7, 8 }, new int[] { 3, 5, 7, 8 }, true)]
        public void ListNodeAreEqual_VariousInputs_CorrectResults(int[] node1, int[] node2, bool expectedResult)
        {
            Assert.Equal(expectedResult, ListNodeAreEqual(ConvertArrayToList(node1), ConvertArrayToList(node2)));
        }

        public static ListNode ConvertArrayToList(int[] input)
        {
            ListNode latest = null;
            foreach (int i in input.Reverse())
            {
                ListNode temp = new ListNode(i);
                temp.next = latest;
                latest = temp;
            }
            return latest;
        }

        public static bool ListNodeAreEqual(ListNode node1, ListNode node2)
        {
            if (node1 == null && node2 == null)
                return true;

            if (node1 == null || node2 == null)
                return false;

            return (node1.val == node2.val) && ListNodeAreEqual(node1.next, node2.next);
        }

        public static string ListNodeToString(ListNode node)
        {
            IList<int> list = new List<int>();
            while (node != null)
            {
                list.Add(node.val);
                node = node.next;
            }
            return string.Join(" -> ", list);
        }
    }
}
