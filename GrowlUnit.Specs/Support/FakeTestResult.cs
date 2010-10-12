using NUnit.Core;

namespace GrowlUnit.Specs.Support
{
    public class FakeTestResult : TestResult
    {

        public FakeTestResult() : base(new TestInfo(new TestName()))
        {
            
        }

      

        public FakeTestResult(TestInfo test) : base(test)
        {
        }

        public FakeTestResult(ITest test) : base(test)
        {
        }

        public FakeTestResult(TestName testName) : base(testName)
        {
        }

        public override bool IsFailure 
        {
            get
            {
                return IsFakeFailure;
            }
        }

        public bool IsFakeFailure{get;set;}
    }
}