// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates whether the event agent has approved the acceptance of volunatry instructions for a given event.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_9w3pAHG0Ee6S2Llv74R19w")]
[Description(
    @"Indicates whether the event agent has approved the acceptance of volunatry instructions for a given event."
)]
[DerivedFrom(typeof(AgentAcceptRejectCode))]
public enum AgentAcceptReject1Code
{
    /// <summary>
    /// Offer approved by agent.
    /// Encoded/decoded by serializers as &quot;ACPT&quot;.
    /// </summary>
    [EnumMember(Value = "ACPT")]
    [IsoId("")]
    [Description(@"Offer approved by agent.")]
    Accept = AgentAcceptRejectCode.Accept, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Offer rejected by agent.
    /// Encoded/decoded by serializers as &quot;REJT&quot;.
    /// </summary>
    [EnumMember(Value = "REJT")]
    [IsoId("")]
    [Description(@"Offer rejected by agent.")]
    Reject = AgentAcceptRejectCode.Reject, // same ordinal as derivation source for type conversions
}
