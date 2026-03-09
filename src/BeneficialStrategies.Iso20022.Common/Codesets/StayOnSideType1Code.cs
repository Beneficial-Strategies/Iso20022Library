// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates that an order is pegged against the offer/bid at the time of the order submission.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_wn8Z4A93EeGeV5vP7Mvdig_-1370869444")]
[Description(@"Indicates that an order is pegged against the offer/bid at the time of the order submission.")]
[DerivedFrom(typeof(StayOnSideTypeCode))]
public enum StayOnSideType1Code
{
    /// <summary>
    /// An order pegged against the offer price.
    /// Encoded/decoded by serializers as &quot;OFFR&quot;.
    /// </summary>
    [EnumMember(Value = "OFFR")]
    [IsoId("_zbzooA93EeGeV5vP7Mvdig_183499807")]
    [Description(@"An order pegged against the offer price.")]
    Offer = StayOnSideTypeCode.Offer, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// An order pegged against the bid price.
    /// Encoded/decoded by serializers as &quot;BIDE&quot;.
    /// </summary>
    [EnumMember(Value = "BIDE")]
    [IsoId("_zbzooQ93EeGeV5vP7Mvdig_-571250067")]
    [Description(@"An order pegged against the bid price.")]
    Bid = StayOnSideTypeCode.Bid, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Indicates a voluntary absence of choice/decision.
    /// Encoded/decoded by serializers as &quot;DCAR&quot;.
    /// </summary>
    [EnumMember(Value = "DCAR")]
    [IsoId("_zbzoog93EeGeV5vP7Mvdig_-128261575")]
    [Description(@"Indicates a voluntary absence of choice/decision.")]
    DontCare = StayOnSideTypeCode.DontCare, // same ordinal as derivation source for type conversions
    
}
