// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the date of settlement, in coded form.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZLby19p-Ed-ak6NoX_4Aeg_336259131")]
[Description(@"Specifies the date of settlement, in coded form.")]
[Derivations(
    typeof(SettlementDate5Code),
    typeof(SettlementDate6Code),
    typeof(SettlementDate4Code),
    typeof(SettlementDate1Code),
    typeof(SettlementDate2Code),
    typeof(SettlementDate3Code)
)]
[Obsolete("Marked obsolete in the ISO 20022 2025-04-24 snapshot. No removal date recorded.")]
public enum SettlementDateCode
{
    /// <summary>
    /// Settlement takes place under the standard rules applicable to the market and instrument.
    /// Encoded/decoded by serializers as &quot;REGU&quot;.
    /// </summary>
    [EnumMember(Value = "REGU")]
    [IsoId("_ZLlj0Np-Ed-ak6NoX_4Aeg_336259139")]
    [Description(
        @"Settlement takes place under the standard rules applicable to the market and instrument."
    )]
    Regular,

    /// <summary>
    /// Settlement takes place on the trade date.
    /// Encoded/decoded by serializers as &quot;CASH&quot;.
    /// </summary>
    [EnumMember(Value = "CASH")]
    [IsoId("_ZLlj0dp-Ed-ak6NoX_4Aeg_336259140")]
    [Description(@"Settlement takes place on the trade date.")]
    Cash,

    /// <summary>
    /// Settlement takes place on the day after trade date.
    /// Encoded/decoded by serializers as &quot;NXTD&quot;.
    /// </summary>
    [EnumMember(Value = "NXTD")]
    [IsoId("_ZLlj0tp-Ed-ak6NoX_4Aeg_336259142")]
    [Description(@"Settlement takes place on the day after trade date.")]
    NextDay,

    /// <summary>
    /// Settlement takes place on the trade date plus one business day.
    /// Encoded/decoded by serializers as &quot;TONE&quot;.
    /// </summary>
    [EnumMember(Value = "TONE")]
    [IsoId("_ZLlj09p-Ed-ak6NoX_4Aeg_336259143")]
    [Description(@"Settlement takes place on the trade date plus one business day.")]
    TPlusOne,

    /// <summary>
    /// Settlement takes place on the trade date plus two business days.
    /// Encoded/decoded by serializers as &quot;TTWO&quot;.
    /// </summary>
    [EnumMember(Value = "TTWO")]
    [IsoId("_ZLlj1Np-Ed-ak6NoX_4Aeg_336259144")]
    [Description(@"Settlement takes place on the trade date plus two business days.")]
    TPlusTwo,

    /// <summary>
    /// Settlement takes place on the trade date plus three business days.
    /// Encoded/decoded by serializers as &quot;TTRE&quot;.
    /// </summary>
    [EnumMember(Value = "TTRE")]
    [IsoId("_ZLlj1dp-Ed-ak6NoX_4Aeg_336259153")]
    [Description(@"Settlement takes place on the trade date plus three business days.")]
    TPlusThree,

    /// <summary>
    /// Settlement takes place on the trade date plus four business days.
    /// Encoded/decoded by serializers as &quot;TFOR&quot;.
    /// </summary>
    [EnumMember(Value = "TFOR")]
    [IsoId("_ZLlj1tp-Ed-ak6NoX_4Aeg_336259154")]
    [Description(@"Settlement takes place on the trade date plus four business days.")]
    TPlusFour,

    /// <summary>
    /// Settlement takes place on the trade date plus five business days.
    /// Encoded/decoded by serializers as &quot;TFIV&quot;.
    /// </summary>
    [EnumMember(Value = "TFIV")]
    [IsoId("_ZLlj19p-Ed-ak6NoX_4Aeg_336259155")]
    [Description(@"Settlement takes place on the trade date plus five business days.")]
    TPlusFive,

    /// <summary>
    /// Settlement takes place at the choice/option of the seller.
    /// Encoded/decoded by serializers as &quot;SELL&quot;.
    /// </summary>
    [EnumMember(Value = "SELL")]
    [IsoId("_ZLlj2Np-Ed-ak6NoX_4Aeg_336259156")]
    [Description(@"Settlement takes place at the choice/option of the seller.")]
    SellersOption,

    /// <summary>
    /// Settlement takes place on the trade date plus six or more business days.
    /// Encoded/decoded by serializers as &quot;FUTU&quot;.
    /// </summary>
    [EnumMember(Value = "FUTU")]
    [IsoId("_ZLlj2dp-Ed-ak6NoX_4Aeg_336259157")]
    [Description(@"Settlement takes place on the trade date plus six or more business days.")]
    Future,

    /// <summary>
    /// Transfer is to be effected as soon as possible.
    /// Encoded/decoded by serializers as &quot;ASAP&quot;.
    /// </summary>
    [EnumMember(Value = "ASAP")]
    [IsoId("_ZLlj2tp-Ed-ak6NoX_4Aeg_581713024")]
    [Description(@"Transfer is to be effected as soon as possible.")]
    AsSoonAsPossible,

    /// <summary>
    /// Transfer is to be effected at the end of the contract.
    /// Encoded/decoded by serializers as &quot;ENDC&quot;.
    /// </summary>
    [EnumMember(Value = "ENDC")]
    [IsoId("_ZLvU0Np-Ed-ak6NoX_4Aeg_581713025")]
    [Description(@"Transfer is to be effected at the end of the contract.")]
    AtEndOfContract,

    /// <summary>
    /// Settlement takes place when the financial instrument is issued by the issuer.
    /// Encoded/decoded by serializers as &quot;WHIF&quot;.
    /// </summary>
    [EnumMember(Value = "WHIF")]
    [IsoId("_ZLvU0dp-Ed-ak6NoX_4Aeg_321193071")]
    [Description(@"Settlement takes place when the financial instrument is issued by the issuer.")]
    WhenAndIfIssued,

    /// <summary>
    /// Settlement takes place when the financial instrument is distributed.
    /// Encoded/decoded by serializers as &quot;WDIS&quot;.
    /// </summary>
    [EnumMember(Value = "WDIS")]
    [IsoId("_ZLvU0tp-Ed-ak6NoX_4Aeg_321193349")]
    [Description(@"Settlement takes place when the financial instrument is distributed.")]
    WhenDistributed,

    /// <summary>
    /// Settlement takes place when the financial instrument is issued or distributed.
    /// Encoded/decoded by serializers as &quot;WHID&quot;.
    /// </summary>
    [EnumMember(Value = "WHID")]
    [IsoId("_ZLvU09p-Ed-ak6NoX_4Aeg_321193391")]
    [Description(@"Settlement takes place when the financial instrument is issued or distributed.")]
    WhenIssuedOrDistributed,

    /// <summary>
    /// Settlement takes place as a result of a &quot;to be announced&quot; trade.
    /// Encoded/decoded by serializers as &quot;TBAT&quot;.
    /// </summary>
    [EnumMember(Value = "TBAT")]
    [IsoId("_ZLvU1Np-Ed-ak6NoX_4Aeg_321193444")]
    [Description(@"Settlement takes place as a result of a ""to be announced"" trade.")]
    ToBeAnnouncedTrade,

    /// <summary>
    /// Settlement takes place at the end of the month.
    /// Encoded/decoded by serializers as &quot;MONT&quot;.
    /// </summary>
    [EnumMember(Value = "MONT")]
    [IsoId("_ZLvU1dp-Ed-ak6NoX_4Aeg_321193504")]
    [Description(@"Settlement takes place at the end of the month.")]
    EndOfMonth,

    /// <summary>
    /// Cash settlement takes place before trade date.
    /// Encoded/decoded by serializers as &quot;CLEA&quot;.
    /// </summary>
    [EnumMember(Value = "CLEA")]
    [IsoId("_ZLvU1tp-Ed-ak6NoX_4Aeg_392642567")]
    [Description(@"Cash settlement takes place before trade date.")]
    Cleared,

    /// <summary>
    /// Money is withdrawn automatically from the savings plan.
    /// Encoded/decoded by serializers as &quot;SAVE&quot;.
    /// </summary>
    [EnumMember(Value = "SAVE")]
    [IsoId("_ZLvU19p-Ed-ak6NoX_4Aeg_392642584")]
    [Description(@"Money is withdrawn automatically from the savings plan.")]
    SavingsPlan,

    /// <summary>
    /// Settlement is to be done when the security is issued.
    /// Encoded/decoded by serializers as &quot;WISS&quot;.
    /// </summary>
    [EnumMember(Value = "WISS")]
    [IsoId("_ZLvU2Np-Ed-ak6NoX_4Aeg_-1554460647")]
    [Description(@"Settlement is to be done when the security is issued.")]
    WhenIssued,

    /// <summary>
    /// Event occurs on the same day or at time T.
    /// Encoded/decoded by serializers as &quot;SAMD&quot;.
    /// </summary>
    [EnumMember(Value = "SAMD")]
    [IsoId("_glq90LbwEeaqL_M7XFD7PQ")]
    [Description(@"Event occurs on the same day or at time T.")]
    SameDay,

    /// <summary>
    /// Event occurs on the previous day.
    /// Encoded/decoded by serializers as &quot;PRVD&quot;.
    /// </summary>
    [EnumMember(Value = "PRVD")]
    [IsoId("_dnAzIOobEeadseq5W5YLvQ")]
    [Description(@"Event occurs on the previous day.")]
    PreviousDay,

    /// <summary>
    /// Any other settlement date.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_I5zl8CkjEemdy87C5UYJ0g")]
    [Description(@"Any other settlement date.")]
    Other,
}
