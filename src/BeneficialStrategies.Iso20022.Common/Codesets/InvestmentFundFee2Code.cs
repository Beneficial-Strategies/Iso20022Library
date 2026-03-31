// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of service for which a charge is asked or paid.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_qWiA0K26EeerDLLe8bZJCA")]
[Description(@"Type of service for which a charge is asked or paid.")]
[DerivedFrom(typeof(InvestmentFundFeeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<InvestmentFundFee2Code>))]
#endif
public enum InvestmentFundFee2Code
{
    /// <summary>
    /// Fee paid by the investor to the fund or fund management company when redeeming.
    /// Encoded/decoded by serializers as &quot;BEND&quot;.
    /// </summary>
    [EnumMember(Value = "BEND")]
    [IsoId("_uPlWAa26EeerDLLe8bZJCA")]
    [Description(
        @"Fee paid by the investor to the fund or fund management company when redeeming."
    )]
    BackEndLoad = InvestmentFundFeeCode.BackEndLoad, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Fee paid by the investor to the fund or fund management company when subscribing.
    /// Encoded/decoded by serializers as &quot;FEND&quot;.
    /// </summary>
    [EnumMember(Value = "FEND")]
    [IsoId("_uhu18a26EeerDLLe8bZJCA")]
    [Description(
        @"Fee paid by the investor to the fund or fund management company when subscribing."
    )]
    FrontEndLoad = InvestmentFundFeeCode.FrontEndLoad, // same ordinal as derivation source for type conversions

    /// <summary>
    /// In investment funds, a fee charged for the transfer of ownership of an investment fund.
    /// Encoded/decoded by serializers as &quot;TRAN&quot;.
    /// </summary>
    [EnumMember(Value = "TRAN")]
    [IsoId("_uzbp8a26EeerDLLe8bZJCA")]
    [Description(
        @"In investment funds, a fee charged for the transfer of ownership of an investment fund."
    )]
    TransferFee = InvestmentFundFeeCode.TransferFee, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Charge paid for the postage.
    /// Encoded/decoded by serializers as &quot;POST&quot;.
    /// </summary>
    [EnumMember(Value = "POST")]
    [IsoId("_0rY70a26EeerDLLe8bZJCA")]
    [Description(@"Charge paid for the postage.")]
    PostageCharge = InvestmentFundFeeCode.PostageCharge, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Fee charged by a regulatory authority, for example, securities and exchange fees.
    /// Encoded/decoded by serializers as &quot;REGF&quot;.
    /// </summary>
    [EnumMember(Value = "REGF")]
    [IsoId("_48070a26EeerDLLe8bZJCA")]
    [Description(
        @"Fee charged by a regulatory authority, for example, securities and exchange fees."
    )]
    RegulatoryFee = InvestmentFundFeeCode.RegulatoryFee, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Charge for shipping, including the insurance of securities.
    /// Encoded/decoded by serializers as &quot;SHIP&quot;.
    /// </summary>
    [EnumMember(Value = "SHIP")]
    [IsoId("_6HEhYa26EeerDLLe8bZJCA")]
    [Description(@"Charge for shipping, including the insurance of securities.")]
    ShippingCharge = InvestmentFundFeeCode.ShippingCharge, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Fees, drawdown, or other reduction from or in addition to the deal price.
    /// Encoded/decoded by serializers as &quot;SPCN&quot;.
    /// </summary>
    [EnumMember(Value = "SPCN")]
    [IsoId("_uV2goa27EeerDLLe8bZJCA")]
    [Description(@"Fees, drawdown, or other reduction from or in addition to the deal price.")]
    SpecialConcessions = InvestmentFundFeeCode.SpecialConcessions, // same ordinal as derivation source for type conversions
}
