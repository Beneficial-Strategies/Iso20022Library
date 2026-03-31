// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of the transaction for network management.
/// </summary>
[IsoId("_ie4K4VWQEeeiG_nL4vgKnQ")]
[DisplayName("Transaction Identification")]
public record TransactionIdentification10
{
    /// <summary>
    /// Local date and time the transaction takes place at the card acceptor location.
    /// ISO 8583:87 bit 12 and 13, ISO 8583:93/2003 bit 12
    /// </summary>
    [IsoId("_iqou8VWQEeeiG_nL4vgKnQ")]
    [DisplayName("Local Date Time")]
    [IsoXmlTag("LclDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime LocalDateTime { get; init; }

    /// <summary>
    /// Time zone name (for example, as defined by IANA - Internet Assigned Numbers Authority - in the time zone database.
    /// </summary>
    [IsoId("_iqou81WQEeeiG_nL4vgKnQ")]
    [DisplayName("Time Zone")]
    [IsoXmlTag("TmZone")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? TimeZone { get; init; }

    /// <summary>
    /// Identification of the transaction by the card acceptor. It may appear on the receipt of the cardholder. It remains unchanged throughout the lifetime of the transaction.
    /// </summary>
    [IsoId("_iqou9VWQEeeiG_nL4vgKnQ")]
    [DisplayName("Transaction Reference")]
    [IsoXmlTag("TxRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? TransactionReference { get; init; }

    /// <summary>
    /// Date and time expressed in UTC of the message as sent by the initiator.
    /// ISO 8583 bit 7
    /// </summary>
    [IsoId("_iqou91WQEeeiG_nL4vgKnQ")]
    [DisplayName("Transmission Date Time")]
    [IsoXmlTag("TrnsmssnDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? TransmissionDateTime { get; init; }

    /// <summary>
    /// A number assigned by a transaction originator to assist in identifying a transaction uniquely. The trace number remains unchanged for all messages within a two-message exchange (for example,  request/repeat and response)
    /// ISO 8583 bit 11.
    /// </summary>
    [IsoId("_iqou-VWQEeeiG_nL4vgKnQ")]
    [DisplayName("System Trace Audit Number")]
    [IsoXmlTag("SysTracAudtNb")]
    [IsoSimpleType(IsoSimpleType.Max12NumericText)]
    public required IsoMax12NumericText SystemTraceAuditNumber { get; init; }

    /// <summary>
    /// Reference supplied by the system retaining the original source information and used to assist in locating that information or a copy thereof.
    /// ISO 8583 bit 37
    /// </summary>
    [IsoId("_iqou-1WQEeeiG_nL4vgKnQ")]
    [DisplayName("Retrieval Reference Number")]
    [IsoXmlTag("RtrvlRefNb")]
    [IsoSimpleType(IsoSimpleType.Exact12Text)]
    public required IsoExact12Text RetrievalReferenceNumber { get; init; }

    /// <summary>
    /// Indicate the point in the transaction lifecycle at which the lifecycle identifier was assigned.
    /// </summary>
    [IsoId("_iqou_VWQEeeiG_nL4vgKnQ")]
    [DisplayName("Life Cycle Support Indicator")]
    [IsoXmlTag("LifeCyclSpprtInd")]
    [IsoSimpleType(IsoSimpleType.Exact2NumericText)]
    public IsoExact2NumericText? LifeCycleSupportIndicator { get; init; }

    /// <summary>
    /// Unique global identification structure used to match transactions throughout their lifecycle.
    /// ISO 8583:2003 bit 21
    /// </summary>
    [IsoId("_iqou_1WQEeeiG_nL4vgKnQ")]
    [DisplayName("Life Cycle Trace Identification Data")]
    [IsoXmlTag("LifeCyclTracIdData")]
    public TransactionLifeCycleIdentification1? LifeCycleTraceIdentificationData { get; init; }

    /// <summary>
    /// Reason for not providing a lifecycle trace identification information.
    /// </summary>
    [IsoId("_iqovAVWQEeeiG_nL4vgKnQ")]
    [DisplayName("Life Cycle Trace Identification Missing")]
    [IsoXmlTag("LifeCyclTracIdMssng")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? LifeCycleTraceIdentificationMissing { get; init; }

    /// <summary>
    /// Data supplied by an acquirer in an authorisation or financial request, advice or notification that may be required to be provided in a subsequent transaction.
    /// ISO 8583:93 bit 31
    /// </summary>
    [IsoId("_iqovA1WQEeeiG_nL4vgKnQ")]
    [DisplayName("Acquirer Reference Data")]
    [IsoXmlTag("AcqrrRefData")]
    [IsoSimpleType(IsoSimpleType.Max99Text)]
    [StringLength(maximumLength: 99, MinimumLength = 1)]
    public IsoMax99Text? AcquirerReferenceData { get; init; }

    /// <summary>
    /// Data supplied by an acquirer to assist in identifying a transaction (for example, for researching retrievals and chargebacks).
    /// ISO 8583:2003 bit 31
    /// </summary>
    [IsoId("_iqovBVWQEeeiG_nL4vgKnQ")]
    [DisplayName("Acquirer Reference Number")]
    [IsoXmlTag("AcqrrRefNb")]
    [IsoSimpleType(IsoSimpleType.Max23NumericText)]
    public IsoMax23NumericText? AcquirerReferenceNumber { get; init; }

    /// <summary>
    /// Data supplied by a card issuer in an authorisation response, financial response message or in a chargeback transaction that the acquirer may be required to provide in subsequent transactions.
    /// ISO 8583:1993 and ISO 8583:2003 bit 95.
    /// </summary>
    [IsoId("_iqovB1WQEeeiG_nL4vgKnQ")]
    [DisplayName("Card Issuer Reference Data")]
    [IsoXmlTag("CardIssrRefData")]
    [IsoSimpleType(IsoSimpleType.Max1000Text)]
    [StringLength(maximumLength: 1000, MinimumLength = 1)]
    public IsoMax1000Text? CardIssuerReferenceData { get; init; }
}
