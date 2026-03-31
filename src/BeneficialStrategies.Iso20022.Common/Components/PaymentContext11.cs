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
[IsoId("_yOE7cWl9EeSxgrJ0GX4SQQ")]
[DisplayName("Payment Context")]
public record PaymentContext11
{
    /// <summary>
    /// Indicates whether the transaction has been initiated by a card physically present or not.
    /// </summary>
    [IsoId("_ybUtQWl9EeSxgrJ0GX4SQQ")]
    [DisplayName("Card Present")]
    [IsoXmlTag("CardPres")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? CardPresent { get; init; }

    /// <summary>
    /// Indicates whether the transaction has been initiated in presence of the cardholder or not.
    /// </summary>
    [IsoId("_ybUtQ2l9EeSxgrJ0GX4SQQ")]
    [DisplayName("Cardholder Present")]
    [IsoXmlTag("CrdhldrPres")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? CardholderPresent { get; init; }

    /// <summary>
    /// On-line or off-line context of the transaction.
    /// </summary>
    [IsoId("_ybUtRWl9EeSxgrJ0GX4SQQ")]
    [DisplayName("On Line Context")]
    [IsoXmlTag("OnLineCntxt")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? OnLineContext { get; init; }

    /// <summary>
    /// Human attendance at the POI location during the transaction.
    /// </summary>
    [IsoId("_ybUtR2l9EeSxgrJ0GX4SQQ")]
    [DisplayName("Attendance Context")]
    [IsoXmlTag("AttndncCntxt")]
    public AttendanceContext1Code? AttendanceContext { get; init; }

    /// <summary>
    /// Indicates the environment of the transaction.
    /// </summary>
    [IsoId("_ybUtSWl9EeSxgrJ0GX4SQQ")]
    [DisplayName("Transaction Environment")]
    [IsoXmlTag("TxEnvt")]
    public TransactionEnvironment1Code? TransactionEnvironment { get; init; }

    /// <summary>
    /// Identifies the type of the communication channels used by the cardholder to the acceptor system.
    /// </summary>
    [IsoId("_ybUtS2l9EeSxgrJ0GX4SQQ")]
    [DisplayName("Transaction Channel")]
    [IsoXmlTag("TxChanl")]
    public TransactionChannel3Code? TransactionChannel { get; init; }

    /// <summary>
    /// Entry mode of the card data.
    /// </summary>
    [IsoId("_ybUtTWl9EeSxgrJ0GX4SQQ")]
    [DisplayName("Card Data Entry Mode")]
    [IsoXmlTag("CardDataNtryMd")]
    public required CardDataReading1Code CardDataEntryMode { get; init; }

    /// <summary>
    /// Indicator of a card entry mode fallback.
    /// </summary>
    [IsoId("_ybUtT2l9EeSxgrJ0GX4SQQ")]
    [DisplayName("Fallback Indicator")]
    [IsoXmlTag("FllbckInd")]
    public CardFallback1Code? FallbackIndicator { get; init; }
}
