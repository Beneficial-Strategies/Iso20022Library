// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the date of settlement, in coded form.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_rYvlUO3uEe6nAu63uIo75Q")]
[Description(@"Specifies the date of settlement, in coded form.")]
[DerivedFrom(typeof(SettlementDateV2Code))]
[JsonConverter(typeof(Iso20022EnumJsonConverter<SettlementDate8Code>))]
public enum SettlementDate8Code
{
    /// <summary>
    /// Transfer is to be effected as soon as possible.
    /// Encoded/decoded by serializers as &quot;ASAP&quot;.
    /// </summary>
    [EnumMember(Value = "ASAP")]
    [IsoId("_wD_Mce3uEe6nAu63uIo75Q")]
    [Description(@"Transfer is to be effected as soon as possible.")]
    AsSoonAsPossible = SettlementDateV2Code.AsSoonAsPossible, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Settlement takes place on the trade date.
    /// Encoded/decoded by serializers as &quot;CASH&quot;.
    /// </summary>
    [EnumMember(Value = "CASH")]
    [IsoId("_wU4IIe3uEe6nAu63uIo75Q")]
    [Description(@"Settlement takes place on the trade date.")]
    Cash = SettlementDateV2Code.Cash, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cash settlement takes place before trade date.
    /// Encoded/decoded by serializers as &quot;CLEA&quot;.
    /// </summary>
    [EnumMember(Value = "CLEA")]
    [IsoId("_wYXhAe3uEe6nAu63uIo75Q")]
    [Description(@"Cash settlement takes place before trade date.")]
    Cleared = SettlementDateV2Code.Cleared, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transfer is to be effected at the end of the contract.
    /// Encoded/decoded by serializers as &quot;ENDC&quot;.
    /// </summary>
    [EnumMember(Value = "ENDC")]
    [IsoId("_wMExce3uEe6nAu63uIo75Q")]
    [Description(@"Transfer is to be effected at the end of the contract.")]
    AtEndOfContract = SettlementDateV2Code.AtEndOfContract, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Settlement takes place on the trade date plus six or more business days.
    /// Encoded/decoded by serializers as &quot;FUTU&quot;.
    /// </summary>
    [EnumMember(Value = "FUTU")]
    [IsoId("_wilM8e3uEe6nAu63uIo75Q")]
    [Description(@"Settlement takes place on the trade date plus six or more business days.")]
    Future = SettlementDateV2Code.Future, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Settlement takes place at the end of the month.
    /// Encoded/decoded by serializers as &quot;MONT&quot;.
    /// </summary>
    [EnumMember(Value = "MONT")]
    [IsoId("_wcZFYe3uEe6nAu63uIo75Q")]
    [Description(@"Settlement takes place at the end of the month.")]
    EndOfMonth = SettlementDateV2Code.EndOfMonth, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Event occurs on the previous day.
    /// Encoded/decoded by serializers as &quot;PRVD&quot;.
    /// </summary>
    [EnumMember(Value = "PRVD")]
    [IsoId("_xIwcIe3uEe6nAu63uIo75Q")]
    [Description(@"Event occurs on the previous day.")]
    PreviousDay = SettlementDateV2Code.PreviousDay, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Settlement takes place under the standard rules applicable to the market and instrument.
    /// Encoded/decoded by serializers as &quot;REGU&quot;.
    /// </summary>
    [EnumMember(Value = "REGU")]
    [IsoId("_xn8Sge3uEe6nAu63uIo75Q")]
    [Description(@"Settlement takes place under the standard rules applicable to the market and instrument.")]
    Regular = SettlementDateV2Code.Regular, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Money is withdrawn automatically from the savings plan.
    /// Encoded/decoded by serializers as &quot;SAVE&quot;.
    /// </summary>
    [EnumMember(Value = "SAVE")]
    [IsoId("_x6sPYe3uEe6nAu63uIo75Q")]
    [Description(@"Money is withdrawn automatically from the savings plan.")]
    SavingsPlan = SettlementDateV2Code.SavingsPlan, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Settlement takes place at the choice/option of the seller.
    /// Encoded/decoded by serializers as &quot;SELL&quot;.
    /// </summary>
    [EnumMember(Value = "SELL")]
    [IsoId("_yElyQe3uEe6nAu63uIo75Q")]
    [Description(@"Settlement takes place at the choice/option of the seller.")]
    SellersOption = SettlementDateV2Code.SellersOption, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Settlement takes place as a result of a "to be announced" trade.
    /// Encoded/decoded by serializers as &quot;TBAT&quot;.
    /// </summary>
    [EnumMember(Value = "TBAT")]
    [IsoId("_yL234e3uEe6nAu63uIo75Q")]
    [Description(@"Settlement takes place as a result of a ""to be announced"" trade.")]
    ToBeAnnouncedTrade = SettlementDateV2Code.ToBeAnnouncedTrade, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Settlement takes place on the trade date plus five business days.
    /// Encoded/decoded by serializers as &quot;TFIV&quot;.
    /// </summary>
    [EnumMember(Value = "TFIV")]
    [IsoId("_yQm1Ae3uEe6nAu63uIo75Q")]
    [Description(@"Settlement takes place on the trade date plus five business days.")]
    TPlusFive = SettlementDateV2Code.TPlusFive, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Settlement takes place on the trade date plus four business days.
    /// Encoded/decoded by serializers as &quot;TFOR&quot;.
    /// </summary>
    [EnumMember(Value = "TFOR")]
    [IsoId("_yT8c4e3uEe6nAu63uIo75Q")]
    [Description(@"Settlement takes place on the trade date plus four business days.")]
    TPlusFour = SettlementDateV2Code.TPlusFour, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Settlement takes place on the trade date plus one business day.
    /// Encoded/decoded by serializers as &quot;TONE&quot;.
    /// </summary>
    [EnumMember(Value = "TONE")]
    [IsoId("_yYY4Ae3uEe6nAu63uIo75Q")]
    [Description(@"Settlement takes place on the trade date plus one business day.")]
    TPlusOne = SettlementDateV2Code.TPlusOne, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Settlement takes place on the trade date plus three business days.
    /// Encoded/decoded by serializers as &quot;TTRE&quot;.
    /// </summary>
    [EnumMember(Value = "TTRE")]
    [IsoId("_yf1j0e3uEe6nAu63uIo75Q")]
    [Description(@"Settlement takes place on the trade date plus three business days.")]
    TPlusThree = SettlementDateV2Code.TPlusThree, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Settlement takes place on the trade date plus two business days.
    /// Encoded/decoded by serializers as &quot;TTWO&quot;.
    /// </summary>
    [EnumMember(Value = "TTWO")]
    [IsoId("_yu9k8e3uEe6nAu63uIo75Q")]
    [Description(@"Settlement takes place on the trade date plus two business days.")]
    TPlusTwo = SettlementDateV2Code.TPlusTwo, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Settlement takes place when the financial instrument is distributed.
    /// Encoded/decoded by serializers as &quot;WDIS&quot;.
    /// </summary>
    [EnumMember(Value = "WDIS")]
    [IsoId("_y4hJke3uEe6nAu63uIo75Q")]
    [Description(@"Settlement takes place when the financial instrument is distributed.")]
    WhenDistributed = SettlementDateV2Code.WhenDistributed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Settlement takes place when the financial instrument is issued or distributed.
    /// Encoded/decoded by serializers as &quot;WHID&quot;.
    /// </summary>
    [EnumMember(Value = "WHID")]
    [IsoId("_zDH3Ee3uEe6nAu63uIo75Q")]
    [Description(@"Settlement takes place when the financial instrument is issued or distributed.")]
    WhenIssuedOrDistributed = SettlementDateV2Code.WhenIssuedOrDistributed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Settlement takes place when the financial instrument is issued by the issuer.
    /// Encoded/decoded by serializers as &quot;WHIF&quot;.
    /// </summary>
    [EnumMember(Value = "WHIF")]
    [IsoId("_yzSrUe3uEe6nAu63uIo75Q")]
    [Description(@"Settlement takes place when the financial instrument is issued by the issuer.")]
    WhenAndIfIssued = SettlementDateV2Code.WhenAndIfIssued, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Settlement is to be done when the security is issued.
    /// Encoded/decoded by serializers as &quot;WISS&quot;.
    /// </summary>
    [EnumMember(Value = "WISS")]
    [IsoId("_y90gUe3uEe6nAu63uIo75Q")]
    [Description(@"Settlement is to be done when the security is issued.")]
    WhenIssued = SettlementDateV2Code.WhenIssued, // same ordinal as derivation source for type conversions
}
