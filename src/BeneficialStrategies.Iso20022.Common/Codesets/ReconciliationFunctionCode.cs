// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates wheneter the message is a request for totals or to convey totals. 
/// </summary>
[DataContract]
[Serializable]
[IsoId("_gpSC0_GHEeiGNursv3uE_g")]
[Description(@"Indicates wheneter the message is a request for totals or to convey totals. ")]
[Derivations(typeof(ReconciliationFunction1Code))]
public enum ReconciliationFunctionCode
{
    /// <summary>
    /// Inquiry for reconciliation totals
    /// Encoded/decoded by serializers as &quot;INQR&quot;.
    /// </summary>
    [EnumMember(Value = "INQR")]
    [IsoId("_gpSC1PGHEeiGNursv3uE_g")]
    [Description(@"Inquiry for reconciliation totals")]
    Inquire,
    
    /// <summary>
    /// Convey reconciliation totals
    /// Encoded/decoded by serializers as &quot;CNVY&quot;.
    /// </summary>
    [EnumMember(Value = "CNVY")]
    [IsoId("_gpSC1fGHEeiGNursv3uE_g")]
    [Description(@"Convey reconciliation totals")]
    Convey,
    
    /// <summary>
    /// Initiation of a cutover. 
    /// Encoded/decoded by serializers as &quot;INCU&quot;.
    /// </summary>
    [EnumMember(Value = "INCU")]
    [IsoId("_WQf80P2KEeiETYIvb2Y3Bg")]
    [Description(@"Initiation of a cutover. ")]
    InitiateCutover,
    
}
