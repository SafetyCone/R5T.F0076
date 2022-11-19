using System;

using R5T.T0132;


namespace R5T.F0076.Construction
{
	[FunctionalityMarker]
	public partial interface ITry : IFunctionalityMarker
	{
		public void PublishProjectWithCOMReference()
        {
			var outputDirectoryPath = @"C:\Temp\Publish\Output";

			// Clear the directory.
			F0000.FileSystemOperator.Instance.DeleteDirectory_OkIfNotExists(outputDirectoryPath);

			MSBuildPublishOperator.Instance.Publish_Synchronous(
				Z0018.ProjectFilePaths.Instance.HasDirectCOMReference,
				outputDirectoryPath);
        }
	}
}