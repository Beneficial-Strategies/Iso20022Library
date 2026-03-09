// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of fraud reporting.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ndM2AHbBEeef9c2nwgY9Xw")]
[Description(@"Type of fraud reporting.")]
[Derivations(typeof(FraudReportingAction1Code))]
public enum FraudReportingActionCode
{
    /// <summary>
    /// New fraud information not reported yet.
    /// Encoded/decoded by serializers as &quot;NEWF&quot;.
    /// </summary>
    [EnumMember(Value = "NEWF")]
    [IsoId("_r0wFEHbBEeef9c2nwgY9Xw")]
    [Description(@"New fraud information not reported yet.")]
    New,
    
    /// <summary>
    /// Fraud information already reported.
    /// Encoded/decoded by serializers as &quot;DUPL&quot;.
    /// </summary>
    [EnumMember(Value = "DUPL")]
    [IsoId("_xA9rQHbBEeef9c2nwgY9Xw")]
    [Description(@"Fraud information already reported.")]
    Duplicate,
    
    /// <summary>
    /// Update information about a fraud already reported.
    /// Encoded/decoded by serializers as &quot;UPDT&quot;.
    /// </summary>
    [EnumMember(Value = "UPDT")]
    [IsoId("_4nmFcHbBEeef9c2nwgY9Xw")]
    [Description(@"Update information about a fraud already reported.")]
    Update,
    
    /// <summary>
    /// Closing a previously reported fraud.
    /// Encoded/decoded by serializers as &quot;CLSE&quot;.
    /// </summary>
    [EnumMember(Value = "CLSE")]
    [IsoId("_JaL44HbCEeef9c2nwgY9Xw")]
    [Description(@"Closing a previously reported fraud.")]
    Close,
    
    /// <summary>
    /// Reopen a previously closed reported fraud case
    /// Encoded/decoded by serializers as &quot;REOP&quot;.
    /// </summary>
    [EnumMember(Value = "REOP")]
    [IsoId("_VzYqMHbCEeef9c2nwgY9Xw")]
    [Description(@"Reopen a previously closed reported fraud case")]
    Reopen,
    
    /// <summary>
    /// Other process about a fraud already reported defined at national level.
    /// Encoded/decoded by serializers as &quot;OTHN&quot;.
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_d5f1sHbCEeef9c2nwgY9Xw")]
    [Description(@"Other process about a fraud already reported defined at national level.")]
    OtherNational,
    
    /// <summary>
    /// Other process about a fraud already reported defined at private level.
    /// Encoded/decoded by serializers as &quot;OTHP&quot;.
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_meJ-YHbCEeef9c2nwgY9Xw")]
    [Description(@"Other process about a fraud already reported defined at private level.")]
    OtherPrivate,
    
}
