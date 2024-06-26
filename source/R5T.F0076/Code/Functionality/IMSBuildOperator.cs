using System;

using R5T.T0132;


namespace R5T.F0076
{
	[FunctionalityMarker]
	public partial interface IMSBuildOperator : IFunctionalityMarker
	{
		public void Run_Synchronous(
			string msBuildArguments)
		{
			Instances.CommandLineOperator.Run_ThrowIfErrorOrFailure_Synchronous(
				FilePaths.Instance.MSBuildExecutable_VS2022,
				msBuildArguments);
		}
	}
}