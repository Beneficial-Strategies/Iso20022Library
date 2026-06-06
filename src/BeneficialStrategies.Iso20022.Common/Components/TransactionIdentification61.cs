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
[IsoId("_7u_QAWPwEfCX7uJiAWHfoQ")]
[DisplayName("Transaction Identification61")]
public record TransactionIdentification61
{
    /// <summary>
    /// Specifies the type of identifier present in the message. P000-P999 reserved for private use, N000-N999 reserved for national use.
    /// </summary>
    [IsoId("_7xkC4WPwEfCX7uJiAWHfoQ")]
    [DisplayName("Purchase Identifier Type")]
    [IsoXmlTag("PurchsIdrTp")]
    public PurchaseIdentifierType3Code? PurchaseIdentifierType { get; init; }

    /// <summary>
    /// Contains a value identifying Invoice Data or Purchase Request Data.
    /// </summary>
    [IsoId("_7xkC5WPwEfCX7uJiAWHfoQ")]
    [DisplayName("Purchase Identifier")]
    [IsoXmlTag("PurchsIdr")]
    public IsoMax99Text? PurchaseIdentifier { get; init; }

    /// <summary>
    /// Date and time expressed in UTC of the message as sent by the initiator.
    /// </summary>
    [IsoId("_7xkC52PwEfCX7uJiAWHfoQ")]
    [DisplayName("Transmission Date Time")]
    [IsoXmlTag("TrnsmssnDtTm")]
    public required IsoISODateTime TransmissionDateTime { get; init; }

    /// <summary>
    /// Number assigned by a transaction originator to assist in identifying a transaction uniquely. The trace number remains unchanged for all messages within a two-message exchange.
    /// </summary>
    [IsoId("_7xkC6WPwEfCX7uJiAWHfoQ")]
    [DisplayName("System Trace Audit Number")]
    [IsoXmlTag("SysTracAudtNb")]
    public IsoMax12NumericText? SystemTraceAuditNumber { get; init; }

    /// <summary>
    /// A reference supplied by the system retaining the original source information and used to assist in locating that information or a copy thereof.
    /// </summary>
    [IsoId("_7xkC62PwEfCX7uJiAWHfoQ")]
    [DisplayName("Retrieval Reference Number")]
    [IsoXmlTag("RtrvlRefNb")]
    public IsoExact12Text? RetrievalReferenceNumber { get; init; }

    /// <summary>
    /// Transaction lifecycle identification.
    /// </summary>
    [IsoId("_7xkC7WPwEfCX7uJiAWHfoQ")]
    [DisplayName("Life Cycle Identification")]
    [IsoXmlTag("LifeCyclId")]
    public IsoExact15Text? LifeCycleIdentification { get; init; }

    /// <summary>
    /// Indicates that additional data will be provided in a separate addendum message.
    /// </summary>
    [IsoId("_7xkC9WPwEfCX7uJiAWHfoQ")]
    [DisplayName("Associated Data")]
    [IsoXmlTag("AssoctdData")]
    public IsoTrueFalseIndicator? AssociatedData { get; init; }

    /// <summary>
    /// Reference to additional transaction details to be conveyed separately from this message.
    /// </summary>
    [IsoId("_7xkC92PwEfCX7uJiAWHfoQ")]
    [DisplayName("Associated Data Reference")]
    [IsoXmlTag("AssoctdDataRef")]
    public IsoMax70Text? AssociatedDataReference { get; init; }

    /// <summary>
    /// Destination value to be used in the subsequent addendum message.
    /// </summary>
    [IsoId("_7xkC-WPwEfCX7uJiAWHfoQ")]
    [DisplayName("Associated Data Destination")]
    [IsoXmlTag("AssoctdDataDstn")]
    public IsoMax35Text? AssociatedDataDestination { get; init; }

    /// <summary>
    /// Reserved for private data. The use of this data element is determined by bilateral agreement.
    /// </summary>
    [IsoId("_-UcPUmPwEfCX7uJiAWHfoQ")]
    [DisplayName("Private Data")]
    [IsoXmlTag("PrvtData")]
    public SimpleValueList<IsoATICALaxProcessing> PrivateData { get; init; } = [];

    /// <summary>
    /// Reserved to define data unique to the country applications.
    /// </summary>
    [IsoId("_-UcPU2PwEfCX7uJiAWHfoQ")]
    [DisplayName("National Data")]
    [IsoXmlTag("NtlData")]
    public SimpleValueList<IsoATICALaxProcessing> NationalData { get; init; } = [];
}
