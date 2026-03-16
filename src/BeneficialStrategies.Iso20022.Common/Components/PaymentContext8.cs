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
[IsoId("_bTG-UWjqEeSDR-pyia6Xtg")]
[DisplayName("Payment Context")]
public record PaymentContext8
{
    /// <summary>
    /// Indicates whether the transaction has been initiated by a card physically present or not.
    /// </summary>
    [IsoId("_bgKi4WjqEeSDR-pyia6Xtg")]
    [DisplayName("Card Present")]
    [IsoXmlTag("CardPres")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? CardPresent { get; init; }

    /// <summary>
    /// Indicates whether the transaction has been initiated in presence of the cardholder or not.
    /// </summary>
    [IsoId("_bgKi42jqEeSDR-pyia6Xtg")]
    [DisplayName("Cardholder Present")]
    [IsoXmlTag("CrdhldrPres")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? CardholderPresent { get; init; }

    /// <summary>
    /// Human attendance at the POI (Point Of Interaction) location during the transaction.
    /// </summary>
    [IsoId("_bgKi5WjqEeSDR-pyia6Xtg")]
    [DisplayName("Attendance Context")]
    [IsoXmlTag("AttndncCntxt")]
    public AttendanceContext1Code? AttendanceContext { get; init; }

    /// <summary>
    /// Indicates the environment of the transaction.
    /// </summary>
    [IsoId("_bgKi52jqEeSDR-pyia6Xtg")]
    [DisplayName("Transaction Environment")]
    [IsoXmlTag("TxEnvt")]
    public TransactionEnvironment1Code? TransactionEnvironment { get; init; }

    /// <summary>
    /// Identifies the type of the communication channels used by the cardholder to the acceptor system.
    /// </summary>
    [IsoId("_bgKi6WjqEeSDR-pyia6Xtg")]
    [DisplayName("Transaction Channel")]
    [IsoXmlTag("TxChanl")]
    public TransactionChannel3Code? TransactionChannel { get; init; }

    /// <summary>
    /// Indicates whether a message can be sent or not on an attendant display (attendant display present or not).
    /// </summary>
    [IsoId("_bgKi62jqEeSDR-pyia6Xtg")]
    [DisplayName("Attendant Message Capable")]
    [IsoXmlTag("AttndntMsgCpbl")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? AttendantMessageCapable { get; init; }

    /// <summary>
    /// Language used to display messages to the attendant.
    /// Reference: ISO 639-1 (alpha-2) et ISO 639-2 (alpha-3).
    /// </summary>
    [IsoId("_bgKi7WjqEeSDR-pyia6Xtg")]
    [DisplayName("Attendant Language")]
    [IsoXmlTag("AttndntLang")]
    public LanguageCode? AttendantLanguage { get; init; }

    /// <summary>
    /// Entry mode of the card data.
    /// </summary>
    [IsoId("_bgKi72jqEeSDR-pyia6Xtg")]
    [DisplayName("Card Data Entry Mode")]
    [IsoXmlTag("CardDataNtryMd")]
    public required CardDataReading1Code CardDataEntryMode { get; init; }

    /// <summary>
    /// Indicator of a card entry mode fallback.
    /// </summary>
    [IsoId("_bgKi8WjqEeSDR-pyia6Xtg")]
    [DisplayName("Fallback Indicator")]
    [IsoXmlTag("FllbckInd")]
    public CardFallback1Code? FallbackIndicator { get; init; }

    /// <summary>
    /// Payment options the card acceptor can support.
    /// </summary>
    [IsoId("_bgKi82jqEeSDR-pyia6Xtg")]
    [DisplayName("Supported Option")]
    [IsoXmlTag("SpprtdOptn")]
    public SimpleValueList<SupportedPaymentOption1Code> SupportedOption { get; init; } = [];
}
