// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Context of the card transaction.
/// </summary>
[IsoId("_q3WpQHsHEeSR68OJvMfxJQ")]
[DisplayName("Card Transaction Context")]
public record CardTransactionContext2
{
    /// <summary>
    /// Indicates whether the transaction has been initiated by a card physically present or not.
    /// It correspond to the ISO 8583: 1993 field number 22-6.
    /// </summary>
    [IsoId("_1Z6pEHsHEeSR68OJvMfxJQ")]
    [DisplayName("Card Present")]
    [IsoXmlTag("CardPres")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? CardPresent { get; init; }

    /// <summary>
    /// Indicates whether the transaction has been initiated in presence of the cardholder or not.
    /// It correspond to the ISO 8583: 1993 field number 22-5.
    /// </summary>
    [IsoId("_Cx2TgHsIEeSR68OJvMfxJQ")]
    [DisplayName("Cardholder Present")]
    [IsoXmlTag("CrdhldrPres")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? CardholderPresent { get; init; }

    /// <summary>
    /// Location category of the place where the transaction is actually performed.
    /// It correspond partially to the ISO 8583: 1993 field number 22-4.
    /// </summary>
    [IsoId("_RHwCEHsIEeSR68OJvMfxJQ")]
    [DisplayName("Location Category")]
    [IsoXmlTag("LctnCtgy")]
    public LocationCategory2Code? LocationCategory { get; init; }

    /// <summary>
    /// Human attendance at the terminal location during the transaction.
    /// It correspond partially to the ISO 8583: 1993 field number 22-4.
    /// </summary>
    [IsoId("_Xy5EYHsIEeSR68OJvMfxJQ")]
    [DisplayName("Attendance Context")]
    [IsoXmlTag("AttndncCntxt")]
    public AttendanceContext1Code? AttendanceContext { get; init; }

    /// <summary>
    /// Indicates the environment of the transaction.
    /// </summary>
    [IsoId("_jdKTIHsIEeSR68OJvMfxJQ")]
    [DisplayName("Transaction Environment")]
    [IsoXmlTag("TxEnvt")]
    public TransactionEnvironment2Code? TransactionEnvironment { get; init; }

    /// <summary>
    /// Indicates the entity hosting the terminal performing the transaction.
    /// It correspond partially to the ISO 8583: 1993 field number 22-4.
    /// </summary>
    [IsoId("_PNJhIHsJEeSR68OJvMfxJQ")]
    [DisplayName("Hosting Category")]
    [IsoXmlTag("HstgCtgy")]
    public TransactionEnvironment3Code? HostingCategory { get; init; }

    /// <summary>
    /// Identifies the type of the communication channels used by the cardholder to the acceptor system.
    /// It correspond to the ISO 8583: 1993 field number 22-5.
    /// </summary>
    [IsoId("_aAfu8HsJEeSR68OJvMfxJQ")]
    [DisplayName("Transaction Channel")]
    [IsoXmlTag("TxChanl")]
    public TransactionChannel3Code? TransactionChannel { get; init; }

    /// <summary>
    /// Entry mode of the card data.
    /// It correspond to the ISO 8583 field number 25 for the version 87 (partially), field number 22-7 for the version 93, and field number 22-1 for the version 2003.
    /// </summary>
    [IsoId("_fJ-KMHsJEeSR68OJvMfxJQ")]
    [DisplayName("Card Data Entry Mode")]
    [IsoXmlTag("CardDataNtryMd")]
    public required CardDataReading2Code CardDataEntryMode { get; init; }

    /// <summary>
    /// Indicator of a card entry mode fall-back. It correspond to the ISO 8583: 2003 field number 22-1.
    /// </summary>
    [IsoId("_k-fGgHsJEeSR68OJvMfxJQ")]
    [DisplayName("Fallback Indicator")]
    [IsoXmlTag("FllbckInd")]
    public CardFallback1Code? FallbackIndicator { get; init; }

    /// <summary>
    /// Payment options the card acceptor can support.
    /// </summary>
    [IsoId("_tOOvIHsJEeSR68OJvMfxJQ")]
    [DisplayName("Supported Option")]
    [IsoXmlTag("SpprtdOptn")]
    public SimpleValueList<SupportedPaymentOption1Code> SupportedOption { get; init; } = [];

    /// <summary>
    /// Data used to assign specific condition such as liability shift or preferential interchange fees.
    /// </summary>
    [IsoId("_-BLu8HsJEeSR68OJvMfxJQ")]
    [DisplayName("Special Conditions")]
    [IsoXmlTag("SpclConds")]
    public ValueList<CardTransactionCondition1> SpecialConditions { get; init; } = [];

    /// <summary>
    /// Indicates to the issuer the level of risk of the transaction.
    /// </summary>
    [IsoId("_vLIrQHsKEeSR68OJvMfxJQ")]
    [DisplayName("Risk Indicator")]
    [IsoXmlTag("RskInd")]
    public ValueList<CardTransactionRiskIndicator1> RiskIndicator { get; init; } = [];
}
