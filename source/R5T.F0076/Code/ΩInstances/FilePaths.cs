using System;


namespace R5T.F0076
{
	public class FilePaths : IFilePaths
	{
		#region Infrastructure

	    public static IFilePaths Instance { get; } = new FilePaths();

	    private FilePaths()
	    {
        }

	    #endregion
	}
}