// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Payment context in which the transaction is performed.
/// </summary>
[IsoId("_0eA4sdwqEeioifFt1dhnJA")]
[DisplayName("Payment Context")]
public record PaymentContext26
{
    /// <summary>
    /// Indicates whether the transaction has been initiated by a card physically present or not.
    /// </summary>
    [IsoId("_0nzt4dwqEeioifFt1dhnJA")]
    [DisplayName("Card Present")]
    [IsoXmlTag("CardPres")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? CardPresent { get; init; }

    /// <summary>
    /// Indicates whether the transaction has been initiated in presence of the cardholder or not.
    /// </summary>
    [IsoId("_0nzt49wqEeioifFt1dhnJA")]
    [DisplayName("Cardholder Present")]
    [IsoXmlTag("CrdhldrPres")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? CardholderPresent { get; init; }

    /// <summary>
    /// On-line or off-line context of the transaction.
    /// </summary>
    [IsoId("_0nzt5dwqEeioifFt1dhnJA")]
    [DisplayName("On Line Context")]
    [IsoXmlTag("OnLineCntxt")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? OnLineContext { get; init; }

    /// <summary>
    /// Human attendance at the POI (Point Of Interaction) location during the transaction.
    /// </summary>
    [IsoId("_0nzt59wqEeioifFt1dhnJA")]
    [DisplayName("Attendance Context")]
    [IsoXmlTag("AttndncCntxt")]
    public AttendanceContext1Code? AttendanceContext { get; init; }

    /// <summary>
    /// Indicates the environment of the transaction.
    /// </summary>
    [IsoId("_0nzt6dwqEeioifFt1dhnJA")]
    [DisplayName("Transaction Environment")]
    [IsoXmlTag("TxEnvt")]
    public TransactionEnvironment1Code? TransactionEnvironment { get; init; }

    /// <summary>
    /// Identifies the type of the communication channels used by the cardholder to the acceptor system.
    /// </summary>
    [IsoId("_0nzt69wqEeioifFt1dhnJA")]
    [DisplayName("Transaction Channel")]
    [IsoXmlTag("TxChanl")]
    public TransactionChannel5Code? TransactionChannel { get; init; }

    /// <summary>
    /// Indicates whether a message can be sent or not on an attendant display (attendant display present or not).
    /// </summary>
    [IsoId("_0nzt7dwqEeioifFt1dhnJA")]
    [DisplayName("Attendant Message Capable")]
    [IsoXmlTag("AttndntMsgCpbl")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? AttendantMessageCapable { get; init; }

    /// <summary>
    /// Language used to display messages to the attendant.
    /// Reference ISO 639-1 (alpha-2) et ISO 639-2 (alpha-3).
    /// </summary>
    [IsoId("_0nzt79wqEeioifFt1dhnJA")]
    [DisplayName("Attendant Language")]
    [IsoXmlTag("AttndntLang")]
    public LanguageCode? AttendantLanguage { get; init; }

    /// <summary>
    /// Entry mode of the card data.
    /// </summary>
    [IsoId("_0nzt8dwqEeioifFt1dhnJA")]
    [DisplayName("Card Data Entry Mode")]
    [IsoXmlTag("CardDataNtryMd")]
    public CardDataReading6Code? CardDataEntryMode { get; init; }

    /// <summary>
    /// Indicator of a card entry mode fallback.
    /// </summary>
    [IsoId("_0n0U8dwqEeioifFt1dhnJA")]
    [DisplayName("Fallback Indicator")]
    [IsoXmlTag("FllbckInd")]
    public CardFallback1Code? FallbackIndicator { get; init; }

    /// <summary>
    /// Payment options the card acceptor can support.
    /// </summary>
    [IsoId("_0n0U89wqEeioifFt1dhnJA")]
    [DisplayName("Supported Option")]
    [IsoXmlTag("SpprtdOptn")]
    public SimpleValueList<SupportedPaymentOption1Code> SupportedOption { get; init; } = [];
}
