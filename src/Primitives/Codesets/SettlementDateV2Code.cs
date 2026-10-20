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
[IsoId("_CFRxhEWrEe6RZYUnHXjemQ")]
[Description(@"Specifies the date of settlement, in coded form.")]
[Derivations(
    typeof(SettlementDate1Code),
    typeof(SettlementDate2Code),
    typeof(SettlementDate3Code),
    typeof(SettlementDate4Code),
    typeof(SettlementDate5Code),
    typeof(SettlementDate6Code),
    typeof(SettlementDate8Code)
)]
[JsonConverter(typeof(Iso20022EnumJsonConverter<SettlementDateV2Code>))]
public enum SettlementDateV2Code
{
    /// <summary>
    /// Transfer is to be effected as soon as possible.
    /// Encoded/decoded by serializers as &quot;ASAP&quot;.
    /// </summary>
    [EnumMember(Value = "ASAP")]
    [IsoId("_CFRxhUWrEe6RZYUnHXjemQ")]
    [Description(@"Transfer is to be effected as soon as possible.")]
    AsSoonAsPossible,

    /// <summary>
    /// Settlement takes place on the trade date.
    /// Encoded/decoded by serializers as &quot;CASH&quot;.
    /// </summary>
    [EnumMember(Value = "CASH")]
    [IsoId("_CFTmmEWrEe6RZYUnHXjemQ")]
    [Description(@"Settlement takes place on the trade date.")]
    Cash,

    /// <summary>
    /// Cash settlement takes place before trade date.
    /// Encoded/decoded by serializers as &quot;CLEA&quot;.
    /// </summary>
    [EnumMember(Value = "CLEA")]
    [IsoId("_CFTmkEWrEe6RZYUnHXjemQ")]
    [Description(@"Cash settlement takes place before trade date.")]
    Cleared,

    /// <summary>
    /// Transfer is to be effected at the end of the contract.
    /// Encoded/decoded by serializers as &quot;ENDC&quot;.
    /// </summary>
    [EnumMember(Value = "ENDC")]
    [IsoId("_CFRxh0WrEe6RZYUnHXjemQ")]
    [Description(@"Transfer is to be effected at the end of the contract.")]
    AtEndOfContract,

    /// <summary>
    /// Settlement takes place on the trade date plus six or more business days.
    /// Encoded/decoded by serializers as &quot;FUTU&quot;.
    /// </summary>
    [EnumMember(Value = "FUTU")]
    [IsoId("_CFRxhkWrEe6RZYUnHXjemQ")]
    [Description(@"Settlement takes place on the trade date plus six or more business days.")]
    Future,

    /// <summary>
    /// Settlement takes place at the end of the month.
    /// Encoded/decoded by serializers as &quot;MONT&quot;.
    /// </summary>
    [EnumMember(Value = "MONT")]
    [IsoId("_CFTmlkWrEe6RZYUnHXjemQ")]
    [Description(@"Settlement takes place at the end of the month.")]
    EndOfMonth,

    /// <summary>
    /// Settlement takes place on the day after trade date.
    /// Encoded/decoded by serializers as &quot;NXTD&quot;.
    /// </summary>
    [EnumMember(Value = "NXTD")]
    [IsoId("_CFTmnEWrEe6RZYUnHXjemQ")]
    [Description(@"Settlement takes place on the day after trade date.")]
    NextDay,

    /// <summary>
    /// Any other settlement date.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_CFRxiEWrEe6RZYUnHXjemQ")]
    [Description(@"Any other settlement date.")]
    Other,

    /// <summary>
    /// Event occurs on the previous day.
    /// Encoded/decoded by serializers as &quot;PRVD&quot;.
    /// </summary>
    [EnumMember(Value = "PRVD")]
    [IsoId("_CFTmoEWrEe6RZYUnHXjemQ")]
    [Description(@"Event occurs on the previous day.")]
    PreviousDay,

    /// <summary>
    /// Settlement takes place under the standard rules applicable to the market and instrument.
    /// Encoded/decoded by serializers as &quot;REGU&quot;.
    /// </summary>
    [EnumMember(Value = "REGU")]
    [IsoId("_CFTmm0WrEe6RZYUnHXjemQ")]
    [Description(@"Settlement takes place under the standard rules applicable to the market and instrument.")]
    Regular,

    /// <summary>
    /// Event occurs on the same day or at time T.
    /// Encoded/decoded by serializers as &quot;SAMD&quot;.
    /// </summary>
    [EnumMember(Value = "SAMD")]
    [IsoId("_CFTmlEWrEe6RZYUnHXjemQ")]
    [Description(@"Event occurs on the same day or at time T.")]
    SameDay,

    /// <summary>
    /// Money is withdrawn automatically from the savings plan.
    /// Encoded/decoded by serializers as &quot;SAVE&quot;.
    /// </summary>
    [EnumMember(Value = "SAVE")]
    [IsoId("_CFTmkUWrEe6RZYUnHXjemQ")]
    [Description(@"Money is withdrawn automatically from the savings plan.")]
    SavingsPlan,

    /// <summary>
    /// Settlement takes place at the choice/option of the seller.
    /// Encoded/decoded by serializers as &quot;SELL&quot;.
    /// </summary>
    [EnumMember(Value = "SELL")]
    [IsoId("_CFTmnkWrEe6RZYUnHXjemQ")]
    [Description(@"Settlement takes place at the choice/option of the seller.")]
    SellersOption,

    /// <summary>
    /// Settlement takes place as a result of a "to be announced" trade.
    /// Encoded/decoded by serializers as &quot;TBAT&quot;.
    /// </summary>
    [EnumMember(Value = "TBAT")]
    [IsoId("_CFTmoUWrEe6RZYUnHXjemQ")]
    [Description(@"Settlement takes place as a result of a ""to be announced"" trade.")]
    ToBeAnnouncedTrade,

    /// <summary>
    /// Settlement takes place on the trade date plus five business days.
    /// Encoded/decoded by serializers as &quot;TFIV&quot;.
    /// </summary>
    [EnumMember(Value = "TFIV")]
    [IsoId("_CFTmnUWrEe6RZYUnHXjemQ")]
    [Description(@"Settlement takes place on the trade date plus five business days.")]
    TPlusFive,

    /// <summary>
    /// Settlement takes place on the trade date plus four business days.
    /// Encoded/decoded by serializers as &quot;TFOR&quot;.
    /// </summary>
    [EnumMember(Value = "TFOR")]
    [IsoId("_CFTmk0WrEe6RZYUnHXjemQ")]
    [Description(@"Settlement takes place on the trade date plus four business days.")]
    TPlusFour,

    /// <summary>
    /// Settlement takes place on the trade date plus one business day.
    /// Encoded/decoded by serializers as &quot;TONE&quot;.
    /// </summary>
    [EnumMember(Value = "TONE")]
    [IsoId("_CFTmkkWrEe6RZYUnHXjemQ")]
    [Description(@"Settlement takes place on the trade date plus one business day.")]
    TPlusOne,

    /// <summary>
    /// Settlement takes place on the trade date plus three business days.
    /// Encoded/decoded by serializers as &quot;TTRE&quot;.
    /// </summary>
    [EnumMember(Value = "TTRE")]
    [IsoId("_CFTml0WrEe6RZYUnHXjemQ")]
    [Description(@"Settlement takes place on the trade date plus three business days.")]
    TPlusThree,

    /// <summary>
    /// Settlement takes place on the trade date plus two business days.
    /// Encoded/decoded by serializers as &quot;TTWO&quot;.
    /// </summary>
    [EnumMember(Value = "TTWO")]
    [IsoId("_CFTmmUWrEe6RZYUnHXjemQ")]
    [Description(@"Settlement takes place on the trade date plus two business days.")]
    TPlusTwo,

    /// <summary>
    /// Settlement takes place when the financial instrument is distributed.
    /// Encoded/decoded by serializers as &quot;WDIS&quot;.
    /// </summary>
    [EnumMember(Value = "WDIS")]
    [IsoId("_CFRxiUWrEe6RZYUnHXjemQ")]
    [Description(@"Settlement takes place when the financial instrument is distributed.")]
    WhenDistributed,

    /// <summary>
    /// Settlement takes place when the financial instrument is issued or distributed.
    /// Encoded/decoded by serializers as &quot;WHID&quot;.
    /// </summary>
    [EnumMember(Value = "WHID")]
    [IsoId("_CFTmmkWrEe6RZYUnHXjemQ")]
    [Description(@"Settlement takes place when the financial instrument is issued or distributed.")]
    WhenIssuedOrDistributed,

    /// <summary>
    /// Settlement takes place when the financial instrument is issued by the issuer.
    /// Encoded/decoded by serializers as &quot;WHIF&quot;.
    /// </summary>
    [EnumMember(Value = "WHIF")]
    [IsoId("_CFTmlUWrEe6RZYUnHXjemQ")]
    [Description(@"Settlement takes place when the financial instrument is issued by the issuer.")]
    WhenAndIfIssued,

    /// <summary>
    /// Settlement is to be done when the security is issued.
    /// Encoded/decoded by serializers as &quot;WISS&quot;.
    /// </summary>
    [EnumMember(Value = "WISS")]
    [IsoId("_CFTmn0WrEe6RZYUnHXjemQ")]
    [Description(@"Settlement is to be done when the security is issued.")]
    WhenIssued,
}
