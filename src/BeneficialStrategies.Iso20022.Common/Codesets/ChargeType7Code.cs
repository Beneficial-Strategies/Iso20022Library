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
[IsoId("_Vlzv-Np-Ed-ak6NoX_4Aeg_-1682515584")]
[Description(@"Specifies the type of service for which a charge is asked or paid.")]
[DerivedFrom(typeof(ChargeTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<ChargeType7Code>))]
#endif
public enum ChargeType7Code
{
    /// <summary>
    /// Fee paid to an investment manager for services. The fee usually includes fund administration costs and investor relationship management. Typically, the amount paid is a percentage of the assets under management.
    /// Encoded/decoded by serializers as &quot;MANF&quot;.
    /// </summary>
    [EnumMember(Value = "MANF")]
    [IsoId("_Vlzv-dp-Ed-ak6NoX_4Aeg_-1483959498")]
    [Description(
        @"Fee paid to an investment manager for services. The fee usually includes fund administration costs and investor relationship management. Typically, the amount paid is a percentage of the assets under management."
    )]
    ManagementFee = ChargeTypeCode.ManagementFee, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Sales charge paid by the investor when redeeming an investment such as an investment fund.
    /// Encoded/decoded by serializers as &quot;BEND&quot;.
    /// </summary>
    [EnumMember(Value = "BEND")]
    [IsoId("_Vl9g8Np-Ed-ak6NoX_4Aeg_-1483959203")]
    [Description(
        @"Sales charge paid by the investor when redeeming an investment such as an investment fund."
    )]
    BackEndLoad = ChargeTypeCode.BackEndLoad, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Fee paid for advisory services rendered.
    /// Encoded/decoded by serializers as &quot;ADVI&quot;.
    /// </summary>
    [EnumMember(Value = "ADVI")]
    [IsoId("_Vl9g8dp-Ed-ak6NoX_4Aeg_-1223527582")]
    [Description(@"Fee paid for advisory services rendered.")]
    AdvisoryFee = ChargeTypeCode.AdvisoryFee, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Fee paid to a custodian in respect of custodial services.
    /// Encoded/decoded by serializers as &quot;CUST&quot;.
    /// </summary>
    [EnumMember(Value = "CUST")]
    [IsoId("_Vl9g8tp-Ed-ak6NoX_4Aeg_-1211518630")]
    [Description(@"Fee paid to a custodian in respect of custodial services.")]
    CustodyFee = ChargeTypeCode.CustodyFee, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Fee paid in respect of publications made.
    /// Encoded/decoded by serializers as &quot;PUBL&quot;.
    /// </summary>
    [EnumMember(Value = "PUBL")]
    [IsoId("_Vl9g89p-Ed-ak6NoX_4Aeg_-1184737330")]
    [Description(@"Fee paid in respect of publications made.")]
    PublicationFee = ChargeTypeCode.PublicationFee, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Fee paid for accounting services rendered.
    /// Encoded/decoded by serializers as &quot;ACCT&quot;.
    /// </summary>
    [EnumMember(Value = "ACCT")]
    [IsoId("_Vl9g9Np-Ed-ak6NoX_4Aeg_-1157032381")]
    [Description(@"Fee paid for accounting services rendered.")]
    AccountingFee = ChargeTypeCode.AccountingFee, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Another type of charge.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_Vl9g9dp-Ed-ak6NoX_4Aeg_1890586208")]
    [Description(@"Another type of charge.")]
    Other = ChargeTypeCode.Other, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The part of an investor&apos;s subscription amount that is held by the fund in order to pay incentive or performance fees at the end of the fiscal year.
    /// Encoded/decoded by serializers as &quot;EQUL&quot;.
    /// </summary>
    [EnumMember(Value = "EQUL")]
    [IsoId("_Vl9g9tp-Ed-ak6NoX_4Aeg_753326519")]
    [Description(
        @"The part of an investor's subscription amount that is held by the fund in order to pay incentive or performance fees at the end of the fiscal year."
    )]
    Equalisation = ChargeTypeCode.Equalisation, // same ordinal as derivation source for type conversions
}
