// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of service for which a charge is asked or paid.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_WOC0odp-Ed-ak6NoX_4Aeg_-70268021")]
[Description(@"Specifies the type of service for which a charge is asked or paid.")]
[DerivedFrom(typeof(ChargeTypeCode))]
public enum ChargeType15Code
{
    /// <summary>
    /// Sales charge paid by the investor when redeeming an investment such as an investment fund.
    /// Encoded/decoded by serializers as &quot;BEND&quot;.
    /// </summary>
    [EnumMember(Value = "BEND")]
    [IsoId("_WOC0otp-Ed-ak6NoX_4Aeg_-70267990")]
    [Description(
        @"Sales charge paid by the investor when redeeming an investment such as an investment fund."
    )]
    BackEndLoad = ChargeTypeCode.BackEndLoad, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Sales charge paid immediately by the investor when subscribing to an investment such as an investment fund.
    /// Encoded/decoded by serializers as &quot;FEND&quot;.
    /// </summary>
    [EnumMember(Value = "FEND")]
    [IsoId("_WOC0o9p-Ed-ak6NoX_4Aeg_-70267989")]
    [Description(
        @"Sales charge paid immediately by the investor when subscribing to an investment such as an investment fund."
    )]
    FrontEndLoad = ChargeTypeCode.FrontEndLoad, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Charge that has been reduced from the standard initial charge levied by a fund, eg, during a launch period or as negotiated by a funds supermarket / discount broker.
    /// Encoded/decoded by serializers as &quot;DISC&quot;.
    /// </summary>
    [EnumMember(Value = "DISC")]
    [IsoId("_WOC0pNp-Ed-ak6NoX_4Aeg_-70267958")]
    [Description(
        @"Charge that has been reduced from the standard initial charge levied by a fund, eg, during a launch period or as negotiated by a funds supermarket / discount broker."
    )]
    Discount = ChargeTypeCode.Discount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Charges paid by the investor to the Fund Company for subscription and redemption orders.
    /// Encoded/decoded by serializers as &quot;UCIC&quot;.
    /// </summary>
    [EnumMember(Value = "UCIC")]
    [IsoId("_WOC0pdp-Ed-ak6NoX_4Aeg_-70267587")]
    [Description(
        @"Charges paid by the investor to the Fund Company for subscription and redemption orders."
    )]
    UCITSCommission = ChargeTypeCode.UCITSCommission, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Fee paid for the provision of financial services.
    /// Encoded/decoded by serializers as &quot;CHAR&quot;.
    /// </summary>
    [EnumMember(Value = "CHAR")]
    [IsoId("_WOC0ptp-Ed-ak6NoX_4Aeg_467608750")]
    [Description(@"Fee paid for the provision of financial services.")]
    ServiceProvisionFee = ChargeTypeCode.ServiceProvisionFee, // same ordinal as derivation source for type conversions
}
