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
[IsoId("_3uzC8WPuEfCX7uJiAWHfoQ")]
[DisplayName("Transaction Identification59")]
public record TransactionIdentification59
{
    /// <summary>
    /// Local date the transaction takes place at the card acceptor location.
    /// </summary>
    [IsoId("_3yOxcWPuEfCX7uJiAWHfoQ")]
    [DisplayName("Local Date")]
    [IsoXmlTag("LclDt")]
    public required IsoISODate LocalDate { get; init; }

    /// <summary>
    /// Local time the transaction takes place at the card acceptor location.
    /// </summary>
    [IsoId("_3yOxhWPuEfCX7uJiAWHfoQ")]
    [DisplayName("Local Time")]
    [IsoXmlTag("LclTm")]
    public IsoISOTime? LocalTime { get; init; }

    /// <summary>
    /// Time zone name (for example, as defined by IANA - Internet Assigned Numbers Authority - in the time zone database).
    /// </summary>
    [IsoId("_3yOxmWPuEfCX7uJiAWHfoQ")]
    [DisplayName("Time Zone")]
    [IsoXmlTag("TmZone")]
    public IsoMax70Text? TimeZone { get; init; }

    /// <summary>
    /// Specifies the type of identifier present in the message. P000-P999 reserved for private use, N000-N999 reserved for national use.
    /// </summary>
    [IsoId("_3yOxm2PuEfCX7uJiAWHfoQ")]
    [DisplayName("Purchase Identifier Type")]
    [IsoXmlTag("PurchsIdrTp")]
    public PurchaseIdentifierType3Code? PurchaseIdentifierType { get; init; }

    /// <summary>
    /// Contains a value identifying Invoice Data or Purchase Request Data.
    /// </summary>
    [IsoId("_3yOxn2PuEfCX7uJiAWHfoQ")]
    [DisplayName("Purchase Identifier")]
    [IsoXmlTag("PurchsIdr")]
    public IsoMax99Text? PurchaseIdentifier { get; init; }

    /// <summary>
    /// Date and time expressed in UTC of the message as sent by the initiator.
    /// </summary>
    [IsoId("_3yOxoWPuEfCX7uJiAWHfoQ")]
    [DisplayName("Transmission Date Time")]
    [IsoXmlTag("TrnsmssnDtTm")]
    public IsoISODateTime? TransmissionDateTime { get; init; }

    /// <summary>
    /// Number assigned by a transaction originator to assist in identifying a transaction uniquely. The trace number remains unchanged for all messages within a two-message exchange (for example, request/repeat and response).
    /// </summary>
    [IsoId("_3yOxqWPuEfCX7uJiAWHfoQ")]
    [DisplayName("System Trace Audit Number")]
    [IsoXmlTag("SysTracAudtNb")]
    public required IsoMax12NumericText SystemTraceAuditNumber { get; init; }

    /// <summary>
    /// Reference supplied by the system retaining the original source information and used to assist in locating that information or a copy thereof.
    /// </summary>
    [IsoId("_3yOxsWPuEfCX7uJiAWHfoQ")]
    [DisplayName("Retrieval Reference Number")]
    [IsoXmlTag("RtrvlRefNb")]
    public IsoExact12Text? RetrievalReferenceNumber { get; init; }

    /// <summary>
    /// Indicate the point in the transaction lifecycle at which the lifecycle identifier was assigned.
    /// </summary>
    [IsoId("_3yOxuWPuEfCX7uJiAWHfoQ")]
    [DisplayName("Life Cycle Support")]
    [IsoXmlTag("LifeCyclSpprt")]
    public LifeCycleSupport1Code? LifeCycleSupport { get; init; }

    /// <summary>
    /// Transaction lifecycle identification
    /// </summary>
    [IsoId("_3yOxu2PuEfCX7uJiAWHfoQ")]
    [DisplayName("Life Cycle Identification")]
    [IsoXmlTag("LifeCyclId")]
    public IsoExact15Text? LifeCycleIdentification { get; init; }

    /// <summary>
    /// Contains authorisation sequence number. This is related transaction lifecycle data.
    /// </summary>
    [IsoId("_3yOxw2PuEfCX7uJiAWHfoQ")]
    [DisplayName("Authorisation Sequence Number")]
    [IsoXmlTag("AuthstnSeqNb")]
    public IsoExact2NumericText? AuthorisationSequenceNumber { get; init; }

    /// <summary>
    /// Number used with trace identifier to uniquely identify where a single authorisation was obtained covering a number of financial presentments. This is related transaction lifecycle data.
    /// </summary>
    [IsoId("_3yOxy2PuEfCX7uJiAWHfoQ")]
    [DisplayName("Presentment Sequence Number")]
    [IsoXmlTag("PresntmntSeqNb")]
    public IsoExact2NumericText? PresentmentSequenceNumber { get; init; }

    /// <summary>
    /// Expected maximum number of presentments for this transaction. This is related transaction lifecycle data.
    /// </summary>
    [IsoId("_3yOx02PuEfCX7uJiAWHfoQ")]
    [DisplayName("Presentment Sequence Count")]
    [IsoXmlTag("PresntmntSeqCnt")]
    public IsoExact2NumericText? PresentmentSequenceCount { get; init; }

    /// <summary>
    /// Code calculated using an algorithm against key transaction data elements that are common to both authorisation and financial messages. This is related transaction lifecycle data.
    /// </summary>
    [IsoId("_3yOx1WPuEfCX7uJiAWHfoQ")]
    [DisplayName("Authentication Token")]
    [IsoXmlTag("AuthntcnTkn")]
    public IsoMax35Text? AuthenticationToken { get; init; }

    /// <summary>
    /// Reason for not providing a lifecycle trace identification information.
    /// </summary>
    [IsoId("_3yOx3WPuEfCX7uJiAWHfoQ")]
    [DisplayName("Life Cycle Identification Missing")]
    [IsoXmlTag("LifeCyclIdMssng")]
    public IsoMax70Text? LifeCycleIdentificationMissing { get; init; }

    /// <summary>
    /// Data supplied by an acquirer in an authorisation or financial request, advice or notification that may be required to be provided in a subsequent transaction.
    /// </summary>
    [IsoId("_3yOx32PuEfCX7uJiAWHfoQ")]
    [DisplayName("Acquirer Reference Data")]
    [IsoXmlTag("AcqrrRefData")]
    public IsoMax140Text? AcquirerReferenceData { get; init; }

    /// <summary>
    /// Data supplied by an acquirer to assist in identifying a transaction (for example, for researching retrievals and chargebacks).
    /// </summary>
    [IsoId("_3yOx52PuEfCX7uJiAWHfoQ")]
    [DisplayName("Acquirer Reference Number")]
    [IsoXmlTag("AcqrrRefNb")]
    public IsoMax23NumericText? AcquirerReferenceNumber { get; init; }

    /// <summary>
    /// Data supplied by a card issuer in an authorisation response, financial response message or in a chargeback transaction that the acquirer may be required to provide in subsequent transactions.
    /// </summary>
    [IsoId("_3yOx72PuEfCX7uJiAWHfoQ")]
    [DisplayName("Issuer Reference Data")]
    [IsoXmlTag("IssrRefData")]
    public IsoMax1000Text? IssuerReferenceData { get; init; }

    /// <summary>
    /// Indicates that additional data will be provided in a separate addendum message.
    /// </summary>
    [IsoId("_3yOx92PuEfCX7uJiAWHfoQ")]
    [DisplayName("Associated Data")]
    [IsoXmlTag("AssoctdData")]
    public IsoTrueFalseIndicator? AssociatedData { get; init; }

    /// <summary>
    /// Reference to additional transaction details to be conveyed separately from this message.
    /// </summary>
    [IsoId("_3yOx-WPuEfCX7uJiAWHfoQ")]
    [DisplayName("Associated Data Reference")]
    [IsoXmlTag("AssoctdDataRef")]
    public IsoMax70Text? AssociatedDataReference { get; init; }

    /// <summary>
    /// Destination value to be used in the subsequent addendum message.
    /// </summary>
    [IsoId("_3yOx-2PuEfCX7uJiAWHfoQ")]
    [DisplayName("Associated Data Destination")]
    [IsoXmlTag("AssoctdDataDstn")]
    public IsoMax35Text? AssociatedDataDestination { get; init; }

    /// <summary>
    /// Reserved for private data. The use of this data element is determined by bilateral agreement.
    /// </summary>
    [IsoId("_7rVxAWPuEfCX7uJiAWHfoQ")]
    [DisplayName("Private Data")]
    [IsoXmlTag("PrvtData")]
    public SimpleValueList<IsoATICALaxProcessing> PrivateData { get; init; } = [];

    /// <summary>
    /// Reserved to define data unique to the country applications. 
    /// </summary>
    [IsoId("_7rVxAmPuEfCX7uJiAWHfoQ")]
    [DisplayName("National Data")]
    [IsoXmlTag("NtlData")]
    public SimpleValueList<IsoATICALaxProcessing> NationalData { get; init; } = [];
}
