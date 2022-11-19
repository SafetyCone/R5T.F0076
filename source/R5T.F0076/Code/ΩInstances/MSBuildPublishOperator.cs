using System;


namespace R5T.F0076
{
	public class MSBuildPublishOperator : IMSBuildPublishOperator
	{
		#region Infrastructure

	    public static IMSBuildPublishOperator Instance { get; } = new MSBuildPublishOperator();

	    private MSBuildPublishOperator()
	    {
        }

	    #endregion
	}
}