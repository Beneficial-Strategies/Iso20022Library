// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates the type of redemption at maturity.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_hbcApmliEeGaMcKyqKNRfQ_-883545842")]
[Description(@"Indicates the type of redemption at maturity.")]
[DerivedFrom(typeof(MaturityRedemptionTypeCode))]
public enum MaturityRedemptionType1Code
{
    /// <summary>
    /// Indicates that the type of redemption at maturity is final.
    /// Encoded/decoded by serializers as &quot;FRED&quot;.
    /// </summary>
    [EnumMember(Value = "FRED")]
    [IsoId("_hbcAp2liEeGaMcKyqKNRfQ_-716525947")]
    [Description(@"Indicates that the type of redemption at maturity is final.")]
    FinalRedemption = MaturityRedemptionTypeCode.FinalRedemption, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Indicates that the type of redemption at maturity is partial without reduction.
    /// Encoded/decoded by serializers as &quot;PRNR&quot;.
    /// </summary>
    [EnumMember(Value = "PRNR")]
    [IsoId("_hbcAqGliEeGaMcKyqKNRfQ_750622816")]
    [Description(@"Indicates that the type of redemption at maturity is partial without reduction.")]
    PartialRedemptionWithoutReduction = MaturityRedemptionTypeCode.PartialRedemptionWithoutReduction, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Indicates that the type of redemption at maturity is partial with reduction.
    /// Encoded/decoded by serializers as &quot;PRWR&quot;.
    /// </summary>
    [EnumMember(Value = "PRWR")]
    [IsoId("_hbcAqWliEeGaMcKyqKNRfQ_641285009")]
    [Description(@"Indicates that the type of redemption at maturity is partial with reduction.")]
    PartialRedemptionWithReduction = MaturityRedemptionTypeCode.PartialRedemptionWithReduction, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Indicates that the type of redemption at maturity is drawing at random.
    /// Encoded/decoded by serializers as &quot;RNDM&quot;.
    /// </summary>
    [EnumMember(Value = "RNDM")]
    [IsoId("_hbcAqmliEeGaMcKyqKNRfQ_2108433772")]
    [Description(@"Indicates that the type of redemption at maturity is drawing at random.")]
    DrawingAtRandom = MaturityRedemptionTypeCode.DrawingAtRandom, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Indicates that the type of redemption at maturity is drawing pro-rata.
    /// Encoded/decoded by serializers as &quot;PRRA&quot;.
    /// </summary>
    [EnumMember(Value = "PRRA")]
    [IsoId("_hbcAq2liEeGaMcKyqKNRfQ_178204958")]
    [Description(@"Indicates that the type of redemption at maturity is drawing pro-rata.")]
    DrawingProRata = MaturityRedemptionTypeCode.DrawingProRata, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Indicates that the type of redemption at maturity is call.
    /// Encoded/decoded by serializers as &quot;CALL&quot;.
    /// </summary>
    [EnumMember(Value = "CALL")]
    [IsoId("_hbcArGliEeGaMcKyqKNRfQ_938970111")]
    [Description(@"Indicates that the type of redemption at maturity is call.")]
    Call = MaturityRedemptionTypeCode.Call, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Indicates that the type of redemption at maturity is put.
    /// Encoded/decoded by serializers as &quot;PUUT&quot;.
    /// </summary>
    [EnumMember(Value = "PUUT")]
    [IsoId("_hbcArWliEeGaMcKyqKNRfQ_-1888848422")]
    [Description(@"Indicates that the type of redemption at maturity is put.")]
    Put = MaturityRedemptionTypeCode.Put, // same ordinal as derivation source for type conversions
    
}
