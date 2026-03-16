// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of service for which a charge is asked or paid.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_a8ruBtp-Ed-ak6NoX_4Aeg_-1448425004")]
[Description(@"Type of service for which a charge is asked or paid.")]
[DerivedFrom(typeof(ChargeTypeCode))]
public enum ChargeType12Code
{
    /// <summary>
    /// Sales charge paid by the investor when redeeming an investment such as an investment fund.
    /// Encoded/decoded by serializers as &quot;BEND&quot;.
    /// </summary>
    [EnumMember(Value = "BEND")]
    [IsoId("_a8ruB9p-Ed-ak6NoX_4Aeg_-1066086887")]
    [Description(
        @"Sales charge paid by the investor when redeeming an investment such as an investment fund."
    )]
    BackEndLoad = ChargeTypeCode.BackEndLoad, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Charge that has been reduced from the standard initial charge levied by a fund, eg, during a launch period or as negotiated by a funds supermarket / discount broker.
    /// Encoded/decoded by serializers as &quot;DISC&quot;.
    /// </summary>
    [EnumMember(Value = "DISC")]
    [IsoId("_a8ruCNp-Ed-ak6NoX_4Aeg_-1066086869")]
    [Description(
        @"Charge that has been reduced from the standard initial charge levied by a fund, eg, during a launch period or as negotiated by a funds supermarket / discount broker."
    )]
    Discount = ChargeTypeCode.Discount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Sales charge paid immediately by the investor when subscribing to an investment such as an investment fund.
    /// Encoded/decoded by serializers as &quot;FEND&quot;.
    /// </summary>
    [EnumMember(Value = "FEND")]
    [IsoId("_a8ruCdp-Ed-ak6NoX_4Aeg_-1066086844")]
    [Description(
        @"Sales charge paid immediately by the investor when subscribing to an investment such as an investment fund."
    )]
    FrontEndLoad = ChargeTypeCode.FrontEndLoad, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Charge paid for the postage.
    /// Encoded/decoded by serializers as &quot;POST&quot;.
    /// </summary>
    [EnumMember(Value = "POST")]
    [IsoId("_a81fANp-Ed-ak6NoX_4Aeg_-1066086827")]
    [Description(@"Charge paid for the postage.")]
    PostageCharge = ChargeTypeCode.PostageCharge, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Fee charged by a regulatory authority, eg, Securities and Exchange fees.
    /// Encoded/decoded by serializers as &quot;REGF&quot;.
    /// </summary>
    [EnumMember(Value = "REGF")]
    [IsoId("_a81fAdp-Ed-ak6NoX_4Aeg_-1066086809")]
    [Description(@"Fee charged by a regulatory authority, eg, Securities and Exchange fees.")]
    RegulatoryFee = ChargeTypeCode.RegulatoryFee, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Charge for shipping, including the insurance of securities.
    /// Encoded/decoded by serializers as &quot;SHIP&quot;.
    /// </summary>
    [EnumMember(Value = "SHIP")]
    [IsoId("_a81fAtp-Ed-ak6NoX_4Aeg_-1066086792")]
    [Description(@"Charge for shipping, including the insurance of securities.")]
    ShippingCharge = ChargeTypeCode.ShippingCharge, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Charges, drawdown, or other reduction from or in addition to the deal price.
    /// Encoded/decoded by serializers as &quot;SPCN&quot;.
    /// </summary>
    [EnumMember(Value = "SPCN")]
    [IsoId("_a81fA9p-Ed-ak6NoX_4Aeg_-1066086774")]
    [Description(@"Charges, drawdown, or other reduction from or in addition to the deal price.")]
    SpecialConcessions = ChargeTypeCode.SpecialConcessions, // same ordinal as derivation source for type conversions

    /// <summary>
    /// In investment funds, a fee charged for the transfer of ownership of an investment fund.
    /// Encoded/decoded by serializers as &quot;TRAN&quot;.
    /// </summary>
    [EnumMember(Value = "TRAN")]
    [IsoId("_a81fBNp-Ed-ak6NoX_4Aeg_-1066086749")]
    [Description(
        @"In investment funds, a fee charged for the transfer of ownership of an investment fund."
    )]
    TransferFee = ChargeTypeCode.TransferFee, // same ordinal as derivation source for type conversions
}
