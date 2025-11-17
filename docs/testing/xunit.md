### TestAssemblyFixture
    + PipelineStage	                                            TestAssemblyExecution
    + TestAssembly                                              { assembly = "D:\\Github\\NetworkVisor\\Platform\\bin\\NetworkVisor.Platform.Test.NetCore.IntegrationTests\\Debug\\net10.0\\NetworkVisor.Platform.Test.NetCore.IntegrationTests.dll", config = null, id = "6fd850b2a9cf6ec6b111b7a36afb69e30a64c5433e042a151f28f9e2888e1053" }
    + TestAssemblyStatus                                        Initializing
    + Assembly                                                  TestAssembly.Assembly NetworkVisor.Platform.Test.NetCore.IntegrationTests.dll
    + testCancellationTokenSource	                            {System.Threading.CancellationTokenSource}
    + CancellationToken IsCancellationRequested                 false
	
### CoreTestClassFixture
    * PipelineStage	                                            TestClassExecution
    * TestAssemblyStatus                                        Running
    + TestClass                                                 Xunit.Sdk.ITestClass
    + TestClassStatus                                           Initializing
    + TestCollection                                            Test collection for NetworkVisor.Platform.Test.Shared.IntegrationTests.CoreApp.CoreAppIntegrationTests
    + TestCollectionStatus                                      Running
    + fixtures                                                  category = "Class", cache count = 0, known type count = 1	Xunit.v3.FixtureMappingManager

### CoreTestCaseBase
    * PipelineStage                                             TestExecution
    * TestClassStatus                                           Running
    + Test                                                      "NetworkVisor.Platform.Test.Shared.IntegrationTests.CoreApp.CoreAppIntegrationTests.AppIntegration_ApplicationContext
    + TestCase                                                  "CoreAppIntegrationTests:AppIntegration_ApplicationContext"
    + TestCaseStatus                                            Running
    + TestMethod                                                "CoreAppIntegrationTests:AppIntegration_ApplicationContext"
    + TestMethodStatus                                          Running
    + TestOutputHelper                                          Xunit.ITestOutputHelper
    + TestStatus                                                Running

### TestMethod
    + TestClassInstance                                         "NetworkVisor.Platform.Test.Shared.IntegrationTests.CoreApp.CoreAppIntegrationTests"
