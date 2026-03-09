// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Standard code to specify the reason why the instruction/event has a pending status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aCk2Odp-Ed-ak6NoX_4Aeg_1137066794")]
[Description(@"Standard code to specify the reason why the instruction/event has a pending status.")]
[DerivedFrom(typeof(PendingFailingReasonCode))]
public enum PendingReason4Code
{
    /// <summary>
    /// Financial instruments have not been delivered by the issuer.
    /// Encoded/decoded by serializers as &quot;NSEC&quot;.
    /// </summary>
    [EnumMember(Value = "NSEC")]
    [IsoId("_aCuAINp-Ed-ak6NoX_4Aeg_1236805137")]
    [Description(@"Financial instruments have not been delivered by the issuer.")]
    NotDelivered = PendingFailingReasonCode.NotDelivered, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Payment has not been made by issuer.
    /// Encoded/decoded by serializers as &quot;NPAY&quot;.
    /// </summary>
    [EnumMember(Value = "NPAY")]
    [IsoId("_aCuAIdp-Ed-ak6NoX_4Aeg_1537875311")]
    [Description(@"Payment has not been made by issuer.")]
    NoPayment = PendingFailingReasonCode.NoPayment, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Other. See Narrative.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_aCuAItp-Ed-ak6NoX_4Aeg_1606213447")]
    [Description(@"Other. See Narrative.")]
    Other = PendingFailingReasonCode.Other, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Tax reclaim has been sent to the tax authorities.
    /// Encoded/decoded by serializers as &quot;AUTH&quot;.
    /// </summary>
    [EnumMember(Value = "AUTH")]
    [IsoId("_aCuAI9p-Ed-ak6NoX_4Aeg_1893428479")]
    [Description(@"Tax reclaim has been sent to the tax authorities.")]
    SentToTaxAuthorities = PendingFailingReasonCode.SentToTaxAuthorities, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// For tax reclaim, the event is pending, the tax reclaim is valid for the tax authorities.
    /// Encoded/decoded by serializers as &quot;VLDA&quot;.
    /// </summary>
    [EnumMember(Value = "VLDA")]
    [IsoId("_aCuAJNp-Ed-ak6NoX_4Aeg_1935910629")]
    [Description(@"For tax reclaim, the event is pending, the tax reclaim is valid for the tax authorities.")]
    ValidForTaxAuthorities = PendingFailingReasonCode.ValidForTaxAuthorities, // same ordinal as derivation source for type conversions
    
}
