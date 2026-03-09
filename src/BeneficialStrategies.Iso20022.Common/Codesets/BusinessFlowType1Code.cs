// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Identifies the business process in which the actors are involved. This is important to trigger the right business process, according to the market business model, which may require matching instructions in a CSD environment (double leg process) or not (single leg process).
/// </summary>
[DataContract]
[Serializable]
[IsoId("_p7MmMPsMEeCZF5_uug7xyA")]
[Description(@"Identifies the business process in which the actors are involved. This is important to trigger the right business process, according to the market business model, which may require matching instructions in a CSD environment (double leg process) or not (single leg process).")]
[DerivedFrom(typeof(BusinessFlowTypeCode))]
public enum BusinessFlowType1Code
{
    /// <summary>
    /// Single leg process initiated by the delivering party.
    /// Encoded/decoded by serializers as &quot;SLDP&quot;.
    /// </summary>
    [EnumMember(Value = "SLDP")]
    [IsoId("_ad9YDv8xEeC-e_lDNJKWcg")]
    [Description(@"Single leg process initiated by the delivering party.")]
    SingleLegDeliveringParty = BusinessFlowTypeCode.SingleLegDeliveringParty, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Single leg process initiated by the receiving party.
    /// Encoded/decoded by serializers as &quot;SLRP&quot;.
    /// </summary>
    [EnumMember(Value = "SLRP")]
    [IsoId("_aiItbv8xEeC-e_lDNJKWcg")]
    [Description(@"Single leg process initiated by the receiving party.")]
    SingleLegReceivingParty = BusinessFlowTypeCode.SingleLegReceivingParty, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Double leg process.
    /// Encoded/decoded by serializers as &quot;DLPR&quot;.
    /// </summary>
    [EnumMember(Value = "DLPR")]
    [IsoId("_bIIWbv8xEeC-e_lDNJKWcg")]
    [Description(@"Double leg process.")]
    DoubleLegProcess = BusinessFlowTypeCode.DoubleLegProcess, // same ordinal as derivation source for type conversions
    
}
