// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates the date of settlement in coded form.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZLI34dp-Ed-ak6NoX_4Aeg_1141279698")]
[Description(@"Indicates the date of settlement in coded form.")]
[DerivedFrom(typeof(SettlementDateCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<SettlementDate2Code>))]
#endif
public enum SettlementDate2Code
{
    /// <summary>
    /// Settlement takes place under the standard rules applicable to the market and instrument.
    /// Encoded/decoded by serializers as &quot;REGU&quot;.
    /// </summary>
    [EnumMember(Value = "REGU")]
    [IsoId("_ZLI34tp-Ed-ak6NoX_4Aeg_1279807839")]
    [Description(
        @"Settlement takes place under the standard rules applicable to the market and instrument."
    )]
    Regular = SettlementDateCode.Regular, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Settlement takes place on the trade date.
    /// Encoded/decoded by serializers as &quot;CASH&quot;.
    /// </summary>
    [EnumMember(Value = "CASH")]
    [IsoId("_ZLI349p-Ed-ak6NoX_4Aeg_1309359964")]
    [Description(@"Settlement takes place on the trade date.")]
    Cash = SettlementDateCode.Cash, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Settlement takes place on the day after trade date.
    /// Encoded/decoded by serializers as &quot;NXTD&quot;.
    /// </summary>
    [EnumMember(Value = "NXTD")]
    [IsoId("_ZLI35Np-Ed-ak6NoX_4Aeg_1313055335")]
    [Description(@"Settlement takes place on the day after trade date.")]
    NextDay = SettlementDateCode.NextDay, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Settlement takes place on the trade date plus one business day.
    /// Encoded/decoded by serializers as &quot;TONE&quot;.
    /// </summary>
    [EnumMember(Value = "TONE")]
    [IsoId("_ZLI35dp-Ed-ak6NoX_4Aeg_1322291660")]
    [Description(@"Settlement takes place on the trade date plus one business day.")]
    TPlusOne = SettlementDateCode.TPlusOne, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Settlement takes place on the trade date plus two business days.
    /// Encoded/decoded by serializers as &quot;TTWO&quot;.
    /// </summary>
    [EnumMember(Value = "TTWO")]
    [IsoId("_ZLI35tp-Ed-ak6NoX_4Aeg_1371237173")]
    [Description(@"Settlement takes place on the trade date plus two business days.")]
    TPlusTwo = SettlementDateCode.TPlusTwo, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Settlement takes place on the trade date plus three business days.
    /// Encoded/decoded by serializers as &quot;TTRE&quot;.
    /// </summary>
    [EnumMember(Value = "TTRE")]
    [IsoId("_ZLI359p-Ed-ak6NoX_4Aeg_1384166063")]
    [Description(@"Settlement takes place on the trade date plus three business days.")]
    TPlusThree = SettlementDateCode.TPlusThree, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Settlement takes place on the trade date plus four business days.
    /// Encoded/decoded by serializers as &quot;TFOR&quot;.
    /// </summary>
    [EnumMember(Value = "TFOR")]
    [IsoId("_ZLI36Np-Ed-ak6NoX_4Aeg_1597497895")]
    [Description(@"Settlement takes place on the trade date plus four business days.")]
    TPlusFour = SettlementDateCode.TPlusFour, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Settlement takes place on the trade date plus five business days.
    /// Encoded/decoded by serializers as &quot;TFIV&quot;.
    /// </summary>
    [EnumMember(Value = "TFIV")]
    [IsoId("_ZLI36dp-Ed-ak6NoX_4Aeg_1609504771")]
    [Description(@"Settlement takes place on the trade date plus five business days.")]
    TPlusFive = SettlementDateCode.TPlusFive, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Settlement takes place at the choice/option of the seller.
    /// Encoded/decoded by serializers as &quot;SELL&quot;.
    /// </summary>
    [EnumMember(Value = "SELL")]
    [IsoId("_ZLSo4Np-Ed-ak6NoX_4Aeg_1625207043")]
    [Description(@"Settlement takes place at the choice/option of the seller.")]
    SellersOption = SettlementDateCode.SellersOption, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Settlement takes place on the trade date plus six or more business days.
    /// Encoded/decoded by serializers as &quot;FUTU&quot;.
    /// </summary>
    [EnumMember(Value = "FUTU")]
    [IsoId("_ZLSo4dp-Ed-ak6NoX_4Aeg_1638134322")]
    [Description(@"Settlement takes place on the trade date plus six or more business days.")]
    Future = SettlementDateCode.Future, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transfer is to be effected as soon as possible.
    /// Encoded/decoded by serializers as &quot;ASAP&quot;.
    /// </summary>
    [EnumMember(Value = "ASAP")]
    [IsoId("_ZLSo4tp-Ed-ak6NoX_4Aeg_1651989075")]
    [Description(@"Transfer is to be effected as soon as possible.")]
    AsSoonAsPossible = SettlementDateCode.AsSoonAsPossible, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transfer is to be effected at the end of the contract.
    /// Encoded/decoded by serializers as &quot;ENDC&quot;.
    /// </summary>
    [EnumMember(Value = "ENDC")]
    [IsoId("_ZLSo49p-Ed-ak6NoX_4Aeg_1666763553")]
    [Description(@"Transfer is to be effected at the end of the contract.")]
    AtEndOfContract = SettlementDateCode.AtEndOfContract, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Settlement takes place when the financial instrument is issued by the issuer.
    /// Encoded/decoded by serializers as &quot;WHIF&quot;.
    /// </summary>
    [EnumMember(Value = "WHIF")]
    [IsoId("_ZLSo5Np-Ed-ak6NoX_4Aeg_1681541811")]
    [Description(@"Settlement takes place when the financial instrument is issued by the issuer.")]
    WhenAndIfIssued = SettlementDateCode.WhenAndIfIssued, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Settlement takes place when the financial instrument is distributed.
    /// Encoded/decoded by serializers as &quot;WDIS&quot;.
    /// </summary>
    [EnumMember(Value = "WDIS")]
    [IsoId("_ZLSo5dp-Ed-ak6NoX_4Aeg_1694470501")]
    [Description(@"Settlement takes place when the financial instrument is distributed.")]
    WhenDistributed = SettlementDateCode.WhenDistributed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Settlement takes place when the financial instrument is issued or distributed.
    /// Encoded/decoded by serializers as &quot;WHID&quot;.
    /// </summary>
    [EnumMember(Value = "WHID")]
    [IsoId("_ZLSo5tp-Ed-ak6NoX_4Aeg_1712016132")]
    [Description(@"Settlement takes place when the financial instrument is issued or distributed.")]
    WhenIssuedOrDistributed = SettlementDateCode.WhenIssuedOrDistributed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Settlement takes place as a result of a &quot;to be announced&quot; trade.
    /// Encoded/decoded by serializers as &quot;TBAT&quot;.
    /// </summary>
    [EnumMember(Value = "TBAT")]
    [IsoId("_ZLSo59p-Ed-ak6NoX_4Aeg_1727715906")]
    [Description(@"Settlement takes place as a result of a ""to be announced"" trade.")]
    ToBeAnnouncedTrade = SettlementDateCode.ToBeAnnouncedTrade, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Settlement takes place at the end of the month.
    /// Encoded/decoded by serializers as &quot;MONT&quot;.
    /// </summary>
    [EnumMember(Value = "MONT")]
    [IsoId("_ZLSo6Np-Ed-ak6NoX_4Aeg_1751726432")]
    [Description(@"Settlement takes place at the end of the month.")]
    EndOfMonth = SettlementDateCode.EndOfMonth, // same ordinal as derivation source for type conversions
}
