using System;

using R5T.T0131;


namespace R5T.F0076
{
	[ValuesMarker]
	public partial interface IFilePaths : IValuesMarker
	{
		public string MSBuildExecutable_VS2022 => @"C:\Program Files\Microsoft Visual Studio\2022\Community\Msbuild\Current\Bin\amd64\MSBuild.exe";
	}
}