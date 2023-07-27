using System;

using R5T.T0131;


namespace R5T.F0076
{
	[ValuesMarker]
	public partial interface IFilePaths : IValuesMarker
	{
		// Found by opening a Developer Command Prompt for VS 2022 (by opening the Windows start menu and then typing that in to search for it),
		// Then executing the command "where MSbuild"
		public string MSBuildExecutable_VS2022 =>
			@"C:\Program Files\Microsoft Visual Studio\2022\Community\Msbuild\Current\Bin\MSBuild.exe";
			//@"C:\Program Files\Microsoft Visual Studio\2022\Community\Msbuild\Current\Bin\amd64\MSBuild.exe";
	}
}