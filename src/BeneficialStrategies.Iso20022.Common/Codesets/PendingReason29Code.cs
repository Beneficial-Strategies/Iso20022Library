// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Standard code to specify the reason why the instruction/event has a pending status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_0so80JB0Ee-COKgew96POA")]
[Description(@"Standard code to specify the reason why the instruction/event has a pending status.")]
[DerivedFrom(typeof(PendingFailingReasonV2Code))]
public enum PendingReason29Code
{
    /// <summary>
    /// Instruction/event is pending because the reclaim is sent to the tax authorities.
    /// Encoded/decoded by serializers as &quot;AUTH&quot;.
    /// </summary>
    [EnumMember(Value = "AUTH")]
    [IsoId("")]
    [Description(@"Instruction/event is pending because the reclaim is sent to the tax authorities.")]
    SentToTaxAuthorities = PendingFailingReasonV2Code.SentToTaxAuthorities, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Payment has not been made by issuer.
    /// Encoded/decoded by serializers as &quot;NPAY&quot;.
    /// </summary>
    [EnumMember(Value = "NPAY")]
    [IsoId("")]
    [Description(@"Payment has not been made by issuer.")]
    NoPayment = PendingFailingReasonV2Code.NoPayment, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Financial instruments have not been delivered by the issuer.
    /// Encoded/decoded by serializers as &quot;NSEC&quot;.
    /// </summary>
    [EnumMember(Value = "NSEC")]
    [IsoId("")]
    [Description(@"Financial instruments have not been delivered by the issuer.")]
    NotDelivered = PendingFailingReasonV2Code.NotDelivered, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other. See Narrative.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("")]
    [Description(@"Other. See Narrative.")]
    Other = PendingFailingReasonV2Code.Other, // same ordinal as derivation source for type conversions

}
