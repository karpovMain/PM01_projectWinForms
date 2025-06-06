using Microsoft.VisualStudio.TestTools.UnitTesting;
using statisticRequest;
using System;
using System.Data;
using System.Windows.Forms;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CleanTable_ShouldTrimAllStringValues()
        {
            var form = new mainForm();
            DataTable table = new DataTable();
            table.Columns.Add("A", typeof(string));
            var row = table.NewRow();
            row["A"] = " \r\n test\t ";
            table.Rows.Add(row);

            form.cleanTable(table);

            Assert.AreEqual("test", table.Rows[0]["A"]);
        }

        [TestMethod]
        public void ConfigureDGV_ShouldSetGridProperties()
        {
            var form = new mainForm();
            var dgv = new DataGridView();
            dgv.Columns.Add("col1", "Column 1");

            form.configureDGV(dgv);

            Assert.AreEqual(DataGridViewAutoSizeColumnsMode.Fill, dgv.AutoSizeColumnsMode);
            Assert.AreEqual(false, dgv.RowHeadersVisible);
        }

        [TestMethod]
        public void DifferentiationRole_ClientRole_ConfiguresButtonsCorrectly()
        {
            data.role = "client";
            var form = new mainForm();

            form.addRequestButton = new Button();
            form.editRequestButton = new Button();
            form.deleteRequestButton = new Button();

            form.differentiationRole();

            Assert.IsTrue(form.addRequestButton.Visible);
            Assert.IsFalse(form.editRequestButton.Visible);
            Assert.IsFalse(form.deleteRequestButton.Visible);
        }
    }
}
