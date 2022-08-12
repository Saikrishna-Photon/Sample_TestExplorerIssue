namespace Sample_TestExplorerIssue.Features
{
    [TestFixture(AppConstants.Browser.Chrome)]
    [TestFixture(AppConstants.Browser.Firefox)]
    [TestFixture(AppConstants.Browser.Edge)]
    [TestFixture(AppConstants.Browser.Safari)]
    public partial class SampleFeature
    {

    }

    /*
     * In our actual project we inherit a hooks class to this partial SampleFeature class
     * and pass on the browser configuration. So in test explorer we see all the tests
     * with all the browsers in TestFixtures.
     * When we try to perform a "Clean" action in visual studio we see a separate test group
     * along the fixture tests. But when we try to "Build" the project we only see the 
     * tests derived from test fixture data after build completion.
     */
}
