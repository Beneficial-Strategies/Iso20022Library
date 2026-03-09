// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of the obligation.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YZ95pNp-Ed-ak6NoX_4Aeg_878628292")]
[Description(@"Specifies the type of the obligation.")]
[Derivations(typeof(ObligationType1Code))]
public enum ObligationTypeCode
{
    /// <summary>
    /// Specifies that the obligation is related to a failed trade.
    /// Encoded/decoded by serializers as &quot;FAIL&quot;.
    /// </summary>
    [EnumMember(Value = "FAIL")]
    [IsoId("_YZ95pdp-Ed-ak6NoX_4Aeg_2016902374")]
    [Description(@"Specifies that the obligation is related to a failed trade.")]
    Fails,
    
    /// <summary>
    /// Specifies that the obligation is related to new a trade.
    /// Encoded/decoded by serializers as &quot;NEW1&quot;.
    /// </summary>
    [EnumMember(Value = "NEW1")]
    [IsoId("_YZ95ptp-Ed-ak6NoX_4Aeg_-692422985")]
    [Description(@"Specifies that the obligation is related to new a trade.")]
    New,
    
    /// <summary>
    /// Specifies that the obligation is related to a corporate event.
    /// Encoded/decoded by serializers as &quot;COEV&quot;.
    /// </summary>
    [EnumMember(Value = "COEV")]
    [IsoId("_YZ95p9p-Ed-ak6NoX_4Aeg_1882565158")]
    [Description(@"Specifies that the obligation is related to a corporate event.")]
    CorporateEvent,
    
}
