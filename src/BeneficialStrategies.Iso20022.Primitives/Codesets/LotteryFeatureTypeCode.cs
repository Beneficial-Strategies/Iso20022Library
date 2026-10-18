// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the lottery feature.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_visBIJSWEfCQbtmJ-bHX4Q")]
[Description(@"Specifies the lottery feature.")]
[Derivations(typeof(LotteryFeatureType1Code))]
[JsonConverter(typeof(Iso20022EnumJsonConverter<LotteryFeatureTypeCode>))]
public enum LotteryFeatureTypeCode
{
    /// <summary>
    /// Issuer has the right to redeem all or part of the bonds before their maturity dates.
    /// Encoded/decoded by serializers as &quot;OPTL&quot;.
    /// </summary>
    [EnumMember(Value = "OPTL")]
    [IsoId("_19eoYJSYEfCQbtmJ-bHX4Q")]
    [Description(@"Issuer has the right to redeem all or part of the bonds before their maturity dates.")]
    Optional,

    /// <summary>
    /// Bond sinking fund.
    /// Encoded/decoded by serializers as &quot;SINK&quot;.
    /// </summary>
    [EnumMember(Value = "SINK")]
    [IsoId("_Fnl7YJSaEfCQbtmJ-bHX4Q")]
    [Description(@"Bond sinking fund. Bond sinking fund is a financial mechanism used by bond issuers to set aside money for the purpose of repaying bondholders at maturity or through periodic redemptions.")]
    SinkingFund,

    /// <summary>
    /// Special redemption bond.
    /// Encoded/decoded by serializers as &quot;SPCL&quot;.
    /// </summary>
    [EnumMember(Value = "SPCL")]
    [IsoId("_sqYP4JSZEfCQbtmJ-bHX4Q")]
    [Description(@"Special redemption bond. Bond that can be redeemed before maturity due to an unusual event, such as a catastrophe that impacts the source of the bond's revenue. This feature must be specified in the bond's offering statement. Special redemption can be done pursuant to the provisions of the indenture.")]
    Special,

    /// <summary>
    /// Extraordinary redemption.
    /// Encoded/decoded by serializers as &quot;XTRA&quot;.
    /// </summary>
    [EnumMember(Value = "XTRA")]
    [IsoId("_GMYOAJSbEfCQbtmJ-bHX4Q")]
    [Description(@"Extraordinary redemption. Extraordinary redemption allows the issuer to call its bonds before maturity if certain specified events occur, such as the project for which the bond was issued to finance has been damaged or destroyed. This feature must be specified in the bond's offering statement.")]
    Extraordinary,
}
