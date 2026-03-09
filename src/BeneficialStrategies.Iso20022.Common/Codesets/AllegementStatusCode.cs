// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the status of an allegement.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bopcI9p-Ed-ak6NoX_4Aeg_241665691")]
[Description(@"Specifies the status of an allegement.")]
[Derivations(typeof(AllegementStatus1Code),typeof(AllegementStatus2Code))]
public enum AllegementStatusCode
{
    /// <summary>
    /// Allegement has been cancelled since the previous delta statement. The allegement was cancelled because of a mistake by the sender or because the alleging party cancelled its instruction.
    /// Encoded/decoded by serializers as &quot;CANC&quot;.
    /// </summary>
    [EnumMember(Value = "CANC")]
    [IsoId("_bopcJNp-Ed-ak6NoX_4Aeg_285994217")]
    [Description(@"Allegement has been cancelled since the previous delta statement. The allegement was cancelled because of a mistake by the sender or because the alleging party cancelled its instruction.")]
    Cancelled,
    
    /// <summary>
    /// Allegement has been removed since the previous delta statement. The allegement was removed because the alleged party sent its instruction.
    /// Encoded/decoded by serializers as &quot;REMO&quot;.
    /// </summary>
    [EnumMember(Value = "REMO")]
    [IsoId("_bopcJdp-Ed-ak6NoX_4Aeg_311854439")]
    [Description(@"Allegement has been removed since the previous delta statement. The allegement was removed because the alleged party sent its instruction.")]
    Removed,
    
    /// <summary>
    /// Allegement is pending.
    /// Encoded/decoded by serializers as &quot;PEND&quot;.
    /// </summary>
    [EnumMember(Value = "PEND")]
    [IsoId("_bopcJtp-Ed-ak6NoX_4Aeg_1115315692")]
    [Description(@"Allegement is pending.")]
    Pending,
    
    /// <summary>
    /// Allegement has been accepted.
    /// Encoded/decoded by serializers as &quot;ACPT&quot;.
    /// </summary>
    [EnumMember(Value = "ACPT")]
    [IsoId("_UhHdoK3DEeeBVbuVcoH9Nw")]
    [Description(@"Allegement has been accepted.")]
    Accepted,
    
    /// <summary>
    /// Transaction or report has been rejected.
    /// Encoded/decoded by serializers as &quot;REJT&quot;.
    /// </summary>
    [EnumMember(Value = "REJT")]
    [IsoId("_WkCXoK3DEeeBVbuVcoH9Nw")]
    [Description(@"Transaction or report has been rejected.")]
    Rejected,
    
}
