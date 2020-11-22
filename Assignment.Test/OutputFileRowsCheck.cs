using Assignment.Service;
using NUnit.Framework;

namespace Assignment.Test
{
    public class OutputFileRowsCheck
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void OutputFile_MustHave_EightRows()
        {
            //Process data to check the output rows
            CoreProcess.Process();
            var result = FileService.GetOutputFileRows();
            Assert.IsTrue(result.Equals(8), "Result is wrong, output file must have 8 rows");
        }
    }
}
