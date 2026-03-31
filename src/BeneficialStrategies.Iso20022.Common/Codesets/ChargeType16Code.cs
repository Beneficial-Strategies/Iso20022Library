// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of service for which a charge is asked or paid.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_WOVvldp-Ed-ak6NoX_4Aeg_-479752789")]
[Description(@"Specifies the type of service for which a charge is asked or paid.")]
[DerivedFrom(typeof(ChargeTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<ChargeType16Code>))]
#endif
public enum ChargeType16Code
{
    /// <summary>
    /// Sales charge paid by the investor when redeeming an investment such as an investment fund.
    /// Encoded/decoded by serializers as &quot;BEND&quot;.
    /// </summary>
    [EnumMember(Value = "BEND")]
    [IsoId("_WOVvltp-Ed-ak6NoX_4Aeg_-479752787")]
    [Description(
        @"Sales charge paid by the investor when redeeming an investment such as an investment fund."
    )]
    BackEndLoad = ChargeTypeCode.BackEndLoad, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Sales charge paid immediately by the investor when subscribing to an investment such as an investment fund.
    /// Encoded/decoded by serializers as &quot;FEND&quot;.
    /// </summary>
    [EnumMember(Value = "FEND")]
    [IsoId("_WOVvl9p-Ed-ak6NoX_4Aeg_-471444618")]
    [Description(
        @"Sales charge paid immediately by the investor when subscribing to an investment such as an investment fund."
    )]
    FrontEndLoad = ChargeTypeCode.FrontEndLoad, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Charge that has been reduced from the standard initial charge levied by a fund, eg, during a launch period or as negotiated by a funds supermarket / discount broker.
    /// Encoded/decoded by serializers as &quot;DISC&quot;.
    /// </summary>
    [EnumMember(Value = "DISC")]
    [IsoId("_WOVvmNp-Ed-ak6NoX_4Aeg_-471444617")]
    [Description(
        @"Charge that has been reduced from the standard initial charge levied by a fund, eg, during a launch period or as negotiated by a funds supermarket / discount broker."
    )]
    Discount = ChargeTypeCode.Discount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Fee paid to a broker for services provided.
    /// Encoded/decoded by serializers as &quot;BRKF&quot;.
    /// </summary>
    [EnumMember(Value = "BRKF")]
    [IsoId("_WOVvmdp-Ed-ak6NoX_4Aeg_-471444588")]
    [Description(@"Fee paid to a broker for services provided.")]
    BrokerageFee = ChargeTypeCode.BrokerageFee, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Charges paid by the investor to the Fund Company for subscription and redemption orders.
    /// Encoded/decoded by serializers as &quot;UCIC&quot;.
    /// </summary>
    [EnumMember(Value = "UCIC")]
    [IsoId("_WOfgkNp-Ed-ak6NoX_4Aeg_-471444587")]
    [Description(
        @"Charges paid by the investor to the Fund Company for subscription and redemption orders."
    )]
    UCITSCommission = ChargeTypeCode.UCITSCommission, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Fee paid for the provision of financial services.
    /// Encoded/decoded by serializers as &quot;CHAR&quot;.
    /// </summary>
    [EnumMember(Value = "CHAR")]
    [IsoId("_WOfgkdp-Ed-ak6NoX_4Aeg_-408643080")]
    [Description(@"Fee paid for the provision of financial services.")]
    ServiceProvisionFee = ChargeTypeCode.ServiceProvisionFee, // same ordinal as derivation source for type conversions
}
