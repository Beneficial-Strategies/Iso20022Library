// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates the type of redemption at maturity.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YghNmdp-Ed-ak6NoX_4Aeg_1836542162")]
[Description(@"Indicates the type of redemption at maturity.")]
[Derivations(typeof(MaturityRedemptionType1Code))]
public enum MaturityRedemptionTypeCode
{
    /// <summary>
    /// Indicates that the type of redemption at maturity is final.
    /// Encoded/decoded by serializers as &quot;FRED&quot;.
    /// </summary>
    [EnumMember(Value = "FRED")]
    [IsoId("_Ygq-kNp-Ed-ak6NoX_4Aeg_-429554626")]
    [Description(@"Indicates that the type of redemption at maturity is final.")]
    FinalRedemption,

    /// <summary>
    /// Indicates that the type of redemption at maturity is partial without reduction.
    /// Encoded/decoded by serializers as &quot;PRNR&quot;.
    /// </summary>
    [EnumMember(Value = "PRNR")]
    [IsoId("_Ygq-kdp-Ed-ak6NoX_4Aeg_1647932478")]
    [Description(
        @"Indicates that the type of redemption at maturity is partial without reduction."
    )]
    PartialRedemptionWithoutReduction,

    /// <summary>
    /// Indicates that the type of redemption at maturity is partial with reduction.
    /// Encoded/decoded by serializers as &quot;PRWR&quot;.
    /// </summary>
    [EnumMember(Value = "PRWR")]
    [IsoId("_Ygq-ktp-Ed-ak6NoX_4Aeg_707096487")]
    [Description(@"Indicates that the type of redemption at maturity is partial with reduction.")]
    PartialRedemptionWithReduction,

    /// <summary>
    /// Indicates that the type of redemption at maturity is drawing at random.
    /// Encoded/decoded by serializers as &quot;RNDM&quot;.
    /// </summary>
    [EnumMember(Value = "RNDM")]
    [IsoId("_Yg0vkNp-Ed-ak6NoX_4Aeg_-1966313104")]
    [Description(@"Indicates that the type of redemption at maturity is drawing at random.")]
    DrawingAtRandom,

    /// <summary>
    /// Indicates that the type of redemption at maturity is drawing pro-rata.
    /// Encoded/decoded by serializers as &quot;PRRA&quot;.
    /// </summary>
    [EnumMember(Value = "PRRA")]
    [IsoId("_Yg0vkdp-Ed-ak6NoX_4Aeg_-453490734")]
    [Description(@"Indicates that the type of redemption at maturity is drawing pro-rata.")]
    DrawingProRata,

    /// <summary>
    /// Indicates that the type of redemption at maturity is call.
    /// Encoded/decoded by serializers as &quot;CALL&quot;.
    /// </summary>
    [EnumMember(Value = "CALL")]
    [IsoId("_Yg0vktp-Ed-ak6NoX_4Aeg_-717923259")]
    [Description(@"Indicates that the type of redemption at maturity is call.")]
    Call,

    /// <summary>
    /// Indicates that the type of redemption at maturity is put.
    /// Encoded/decoded by serializers as &quot;PUUT&quot;.
    /// </summary>
    [EnumMember(Value = "PUUT")]
    [IsoId("_Yg0vk9p-Ed-ak6NoX_4Aeg_1234744459")]
    [Description(@"Indicates that the type of redemption at maturity is put.")]
    Put,
}
