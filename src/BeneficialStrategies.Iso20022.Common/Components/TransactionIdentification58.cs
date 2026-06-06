// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of the transaction.
/// </summary>
[IsoId("_715D4SHyEfCkq6-p7S3J1Q")]
[DisplayName("Transaction Identification58")]
public record TransactionIdentification58
{
    /// <summary>
    /// Local date the transaction takes place at the card acceptor location.
    /// </summary>
    [IsoId("_74aMYSHyEfCkq6-p7S3J1Q")]
    [DisplayName("Local Date")]
    [IsoXmlTag("LclDt")]
    public IsoISODate? LocalDate { get; init; }

    /// <summary>
    /// Local time the transaction takes place at the card acceptor location.
    /// </summary>
    [IsoId("_74aMdSHyEfCkq6-p7S3J1Q")]
    [DisplayName("Local Time")]
    [IsoXmlTag("LclTm")]
    public IsoISOTime? LocalTime { get; init; }

    /// <summary>
    /// Time zone name (for example, as defined by IANA - Internet Assigned Numbers Authority - in the time zone database).
    /// </summary>
    [IsoId("_74aMiSHyEfCkq6-p7S3J1Q")]
    [DisplayName("Time Zone")]
    [IsoXmlTag("TmZone")]
    public IsoMax70Text? TimeZone { get; init; }

    /// <summary>
    /// Specifies the type of identifier present in the message. P000-P999 reserved for private use, N000-N999 reserved for national use.
    /// </summary>
    [IsoId("_74aMiyHyEfCkq6-p7S3J1Q")]
    [DisplayName("Purchase Identifier Type")]
    [IsoXmlTag("PurchsIdrTp")]
    public PurchaseIdentifierType3Code? PurchaseIdentifierType { get; init; }

    /// <summary>
    /// Contains a value identifying Invoice Data or Purchase Request Data.
    /// </summary>
    [IsoId("_74aMjyHyEfCkq6-p7S3J1Q")]
    [DisplayName("Purchase Identifier")]
    [IsoXmlTag("PurchsIdr")]
    public IsoMax99Text? PurchaseIdentifier { get; init; }

    /// <summary>
    /// Date and time expressed in UTC of the message as sent by the initiator.
    /// </summary>
    [IsoId("_74aMkSHyEfCkq6-p7S3J1Q")]
    [DisplayName("Transmission Date Time")]
    [IsoXmlTag("TrnsmssnDtTm")]
    public IsoISODateTime? TransmissionDateTime { get; init; }

    /// <summary>
    /// Number assigned by a transaction originator to assist in identifying a transaction uniquely. The trace number remains unchanged for all messages within a two-message exchange (for example, request/repeat and response).
    /// </summary>
    [IsoId("_74aMmSHyEfCkq6-p7S3J1Q")]
    [DisplayName("System Trace Audit Number")]
    [IsoXmlTag("SysTracAudtNb")]
    public required IsoMax12NumericText SystemTraceAuditNumber { get; init; }

    /// <summary>
    /// Reference supplied by the system retaining the original source information and used to assist in locating that information or a copy thereof.
    /// </summary>
    [IsoId("_74aMoSHyEfCkq6-p7S3J1Q")]
    [DisplayName("Retrieval Reference Number")]
    [IsoXmlTag("RtrvlRefNb")]
    public IsoExact12Text? RetrievalReferenceNumber { get; init; }

    /// <summary>
    /// Indicate the point in the transaction lifecycle at which the lifecycle identifier was assigned.
    /// </summary>
    [IsoId("_74aMqSHyEfCkq6-p7S3J1Q")]
    [DisplayName("Life Cycle Support")]
    [IsoXmlTag("LifeCyclSpprt")]
    public LifeCycleSupport1Code? LifeCycleSupport { get; init; }

    /// <summary>
    /// Transaction lifecycle identification
    /// </summary>
    [IsoId("_74aMqyHyEfCkq6-p7S3J1Q")]
    [DisplayName("Life Cycle Identification")]
    [IsoXmlTag("LifeCyclId")]
    public IsoMax36Text? LifeCycleIdentification { get; init; }

    /// <summary>
    /// Transaction lifecycle identification of the original transaction associated to current transaction.
    /// </summary>
    [IsoId("_lBiF1CHzEfCkq6-p7S3J1Q")]
    [DisplayName("Associated Transaction Life Cycle Identification")]
    [IsoXmlTag("AssoctdTxLifeCyclId")]
    public IsoMax36Text? AssociatedTransactionLifeCycleIdentification { get; init; }

    /// <summary>
    /// Validation result of Transaction lifecycle identification.
    /// </summary>
    [IsoId("_TDHjBCH0EfCkq6-p7S3J1Q")]
    [DisplayName("Life Cycle Identification Validation")]
    [IsoXmlTag("LifeCyclIdVldtn")]
    public IsoMax37Text? LifeCycleIdentificationValidation { get; init; }

    /// <summary>
    /// Contains authorisation sequence number. This is related transaction lifecycle data.
    /// </summary>
    [IsoId("_74aMsyHyEfCkq6-p7S3J1Q")]
    [DisplayName("Authorisation Sequence Number")]
    [IsoXmlTag("AuthstnSeqNb")]
    public IsoExact2NumericText? AuthorisationSequenceNumber { get; init; }

    /// <summary>
    /// Number used with trace identifier to uniquely identify where a single authorisation was obtained covering a number of financial presentments. This is related transaction lifecycle data.
    /// </summary>
    [IsoId("_74aMuyHyEfCkq6-p7S3J1Q")]
    [DisplayName("Presentment Sequence Number")]
    [IsoXmlTag("PresntmntSeqNb")]
    public IsoExact2NumericText? PresentmentSequenceNumber { get; init; }

    /// <summary>
    /// Expected maximum number of presentments for this transaction. This is related transaction lifecycle data.
    /// </summary>
    [IsoId("_74aMwyHyEfCkq6-p7S3J1Q")]
    [DisplayName("Presentment Sequence Count")]
    [IsoXmlTag("PresntmntSeqCnt")]
    public IsoExact2NumericText? PresentmentSequenceCount { get; init; }

    /// <summary>
    /// Code calculated using an algorithm against key transaction data elements that are common to both authorisation and financial messages. This is related transaction lifecycle data.
    /// </summary>
    [IsoId("_74aMxSHyEfCkq6-p7S3J1Q")]
    [DisplayName("Authentication Token")]
    [IsoXmlTag("AuthntcnTkn")]
    public IsoMax36Text? AuthenticationToken { get; init; }

    /// <summary>
    /// Reason for not providing a lifecycle trace identification information.
    /// </summary>
    [IsoId("_74aMzSHyEfCkq6-p7S3J1Q")]
    [DisplayName("Life Cycle Identification Missing")]
    [IsoXmlTag("LifeCyclIdMssng")]
    public IsoMax70Text? LifeCycleIdentificationMissing { get; init; }

    /// <summary>
    /// Data supplied by an acquirer in an authorisation or financial request, advice or notification that may be required to be provided in a subsequent transaction.
    /// </summary>
    [IsoId("_74aMzyHyEfCkq6-p7S3J1Q")]
    [DisplayName("Acquirer Reference Data")]
    [IsoXmlTag("AcqrrRefData")]
    public IsoMax140Text? AcquirerReferenceData { get; init; }

    /// <summary>
    /// Data supplied by an acquirer to assist in identifying a transaction (for example, for researching retrievals and chargebacks).
    /// </summary>
    [IsoId("_74aM1yHyEfCkq6-p7S3J1Q")]
    [DisplayName("Acquirer Reference Number")]
    [IsoXmlTag("AcqrrRefNb")]
    public IsoMax23NumericText? AcquirerReferenceNumber { get; init; }

    /// <summary>
    /// Data supplied by a card issuer in an authorisation response, financial response message or in a chargeback transaction that the acquirer may be required to provide in subsequent transactions.
    /// </summary>
    [IsoId("_74aM3yHyEfCkq6-p7S3J1Q")]
    [DisplayName("Issuer Reference Data")]
    [IsoXmlTag("IssrRefData")]
    public IsoMax1000Text? IssuerReferenceData { get; init; }

    /// <summary>
    /// Indicates that additional data will be provided in a separate addendum message.
    /// </summary>
    [IsoId("_74aM5yHyEfCkq6-p7S3J1Q")]
    [DisplayName("Associated Data")]
    [IsoXmlTag("AssoctdData")]
    public IsoTrueFalseIndicator? AssociatedData { get; init; }

    /// <summary>
    /// Reference to additional transaction details to be conveyed separately from this message.
    /// </summary>
    [IsoId("_74aM6SHyEfCkq6-p7S3J1Q")]
    [DisplayName("Associated Data Reference")]
    [IsoXmlTag("AssoctdDataRef")]
    public IsoMax70Text? AssociatedDataReference { get; init; }

    /// <summary>
    /// Destination value to be used in the subsequent addendum message.
    /// </summary>
    [IsoId("_74aM6yHyEfCkq6-p7S3J1Q")]
    [DisplayName("Associated Data Destination")]
    [IsoXmlTag("AssoctdDataDstn")]
    public IsoMax35Text? AssociatedDataDestination { get; init; }

    /// <summary>
    /// Reserved for private data. The use of this data element is determined by bilateral agreement.
    /// </summary>
    [IsoId("_XsFLUkVYEfCQAqQ9lolFUg")]
    [DisplayName("Private Data")]
    [IsoXmlTag("PrvtData")]
    public SimpleValueList<IsoATICALaxProcessing> PrivateData { get; init; } = [];

    /// <summary>
    /// Reserved to define data unique to the country applications. 
    /// </summary>
    [IsoId("_XsFLU0VYEfCQAqQ9lolFUg")]
    [DisplayName("National Data")]
    [IsoXmlTag("NtlData")]
    public SimpleValueList<IsoATICALaxProcessing> NationalData { get; init; } = [];
}
