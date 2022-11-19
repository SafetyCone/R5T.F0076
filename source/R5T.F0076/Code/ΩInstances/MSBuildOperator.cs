using System;


namespace R5T.F0076
{
	public class MSBuildOperator : IMSBuildOperator
	{
		#region Infrastructure

	    public static IMSBuildOperator Instance { get; } = new MSBuildOperator();

	    private MSBuildOperator()
	    {
        }

	    #endregion
	}
}