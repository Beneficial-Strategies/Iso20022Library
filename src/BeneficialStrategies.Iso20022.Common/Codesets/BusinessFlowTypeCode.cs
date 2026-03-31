// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Identifies the business process in which the actors are involved. This is important to trigger the right business process, according to the market business model, which may require matching instructions in a CSD environment (double leg process) or not (single leg process).
/// </summary>
[DataContract]
[Serializable]
[IsoId("_EbRBA_sMEeCZF5_uug7xyA")]
[Description(
    @"Identifies the business process in which the actors are involved. This is important to trigger the right business process, according to the market business model, which may require matching instructions in a CSD environment (double leg process) or not (single leg process)."
)]
[Derivations(typeof(BusinessFlowType1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<BusinessFlowTypeCode>))]
#endif
public enum BusinessFlowTypeCode
{
    /// <summary>
    /// Single leg process initiated by the delivering party.
    /// Encoded/decoded by serializers as &quot;SLDP&quot;.
    /// </summary>
    [EnumMember(Value = "SLDP")]
    [IsoId("_HgklF_sMEeCZF5_uug7xyA")]
    [Description(@"Single leg process initiated by the delivering party.")]
    SingleLegDeliveringParty,

    /// <summary>
    /// Single leg process initiated by the receiving party.
    /// Encoded/decoded by serializers as &quot;SLRP&quot;.
    /// </summary>
    [EnumMember(Value = "SLRP")]
    [IsoId("_SCRpR_sMEeCZF5_uug7xyA")]
    [Description(@"Single leg process initiated by the receiving party.")]
    SingleLegReceivingParty,

    /// <summary>
    /// Double leg process.
    /// Encoded/decoded by serializers as &quot;DLPR&quot;.
    /// </summary>
    [EnumMember(Value = "DLPR")]
    [IsoId("_ZA4aJ_sMEeCZF5_uug7xyA")]
    [Description(@"Double leg process.")]
    DoubleLegProcess,
}
