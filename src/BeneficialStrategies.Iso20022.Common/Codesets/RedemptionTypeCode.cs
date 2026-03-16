// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates the redemption type of the interest bearing instrument.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_VuwQltp-Ed-ak6NoX_4Aeg_-946443320")]
[Description(@"Indicates the redemption type of the interest bearing instrument.")]
[Derivations(typeof(RedemptionType1Code))]
public enum RedemptionTypeCode
{
    /// <summary>
    /// Indicates whether an interest bearing instrument is being escrowed or collateralized either by direct obligations guaranteed by the US government, or by other types of securities. The maturity schedules of the securities in the escrow fund are determined in such a way to pay the maturity value, coupon, and premium payments (if any) of the refunded bonds.
    /// Encoded/decoded by serializers as &quot;PFIN&quot;.
    /// </summary>
    [EnumMember(Value = "PFIN")]
    [IsoId("_VuwQl9p-Ed-ak6NoX_4Aeg_-573340788")]
    [Description(
        @"Indicates whether an interest bearing instrument is being escrowed or collateralized either by direct obligations guaranteed by the US government, or by other types of securities. The maturity schedules of the securities in the escrow fund are determined in such a way to pay the maturity value, coupon, and premium payments (if any) of the refunded bonds."
    )]
    PreFunded,

    /// <summary>
    /// Indicates whether an interest bearing instrument is deposited in a fund that will be used to pay debt service on refunded securities.
    /// Encoded/decoded by serializers as &quot;ESIN&quot;.
    /// </summary>
    [EnumMember(Value = "ESIN")]
    [IsoId("_VuwQmNp-Ed-ak6NoX_4Aeg_-573340770")]
    [Description(
        @"Indicates whether an interest bearing instrument is deposited in a fund that will be used to pay debt service on refunded securities."
    )]
    Escrowed,

    /// <summary>
    /// Indicates whether the interest bearing instrument is convertible into another type of financial instrument or not.
    /// Encoded/decoded by serializers as &quot;COIN&quot;.
    /// </summary>
    [EnumMember(Value = "COIN")]
    [IsoId("_Vu5agNp-Ed-ak6NoX_4Aeg_-573340769")]
    [Description(
        @"Indicates whether the interest bearing instrument is convertible into another type of financial instrument or not."
    )]
    Convertible,

    /// <summary>
    /// Indicates whether the issuer has the right to pay the bond prior to maturity.
    /// Encoded/decoded by serializers as &quot;CAIN&quot;.
    /// </summary>
    [EnumMember(Value = "CAIN")]
    [IsoId("_Vu5agdp-Ed-ak6NoX_4Aeg_-573340753")]
    [Description(@"Indicates whether the issuer has the right to pay the bond prior to maturity.")]
    Callable,

    /// <summary>
    /// Indicates whether the bondholder has the right to redeem the principal amount of a bond prior to final maturity.
    /// Encoded/decoded by serializers as &quot;PUIN&quot;.
    /// </summary>
    [EnumMember(Value = "PUIN")]
    [IsoId("_Vu5agtp-Ed-ak6NoX_4Aeg_-573340744")]
    [Description(
        @"Indicates whether the bondholder has the right to redeem the principal amount of a bond prior to final maturity."
    )]
    Putable,
}
