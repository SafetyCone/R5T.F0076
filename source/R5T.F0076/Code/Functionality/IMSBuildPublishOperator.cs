using System;

using R5T.T0132;


namespace R5T.F0076
{
	[FunctionalityMarker]
	public partial interface IMSBuildPublishOperator : IFunctionalityMarker
	{
		public void Publish_Synchronous(
			string projectFilePath,
			string outputDirectoryPath,
			string configurationName)
        {
			var msBuildArguments = $"-target:Publish -p:OutDir=\"{outputDirectoryPath}\" -p:Configuration={configurationName} \"{projectFilePath}\"";

			MSBuildOperator.Instance.Run_Synchronous(msBuildArguments);
		}

		public void Publish_Debug_Synchronous(
			string projectFilePath,
			string outputDirectoryPath)
        {
			this.Publish_Synchronous(
				projectFilePath,
				outputDirectoryPath,
				"Debug");
        }

		/// <summary>
		/// Chooses <see cref="Publish_Debug_Synchronous(string, string)"/> as the default configuration.
		/// </summary>
		public void Publish_Synchronous(
			string projectFilePath,
			string outputDirectoryPath)
        {
			this.Publish_Debug_Synchronous(
				projectFilePath,
				outputDirectoryPath);
        }
	}
}