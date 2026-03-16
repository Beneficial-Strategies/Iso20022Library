// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.setr;

/// <summary>
/// This record is an implementation of the setr.006.001.04 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The RedemptionOrderConfirmation message is sent by an executing party, for example, a transfer agent, to the instructing party, for example, an investment manager or its authorised representative, to confirm the details of execution for a previously received RedemptionOrder message.
/// Usage
/// The RedemptionOrderConfirmation message is used to confirm the execution of one or more individual orders.
/// A RedemptionOrder message containing more than one individual order may be responded to by more than one RedemptionOrderConfirmation message, as the valuation cycle of the financial instruments in each individual order may be different. When a RedemptionOrderConfirmation message contains fewer confirmations that originally instructed in the original RedemptionOrder message, there is no specification indication in the confirmation for this. Reconciliation must be based on the references.
/// Each individual order confirmation specified is identified in DealReference. The reference of the original individual order is specified in OrderReference. The message identification of the RedemptionOrder message in which the individual order was conveyed may also be quoted in RelatedReference but this is not recommended.
/// A RedemptionOrder must in all cases be responded to by a RedemptionOrderConfirmation message and in no circumstances by a RedemptionBulkOrderConfirmation message.
/// If the executing party needs to confirm one or more redemption orders for the same financial instrument then a RedemptionBulkOrderConfirmation message must be used.
/// When the message is used to convey a confirmation amendment/s, the AmendmentIndicator must be present with the value ‘true’ or ‘1’. When this is the case, the message must only contain a confirmation amendment/s and not contain both a confirmation amendment/s and a ‘new’ confirmation/s.
/// </summary>
[Description(
    @"Scope|The RedemptionOrderConfirmation message is sent by an executing party, for example, a transfer agent, to the instructing party, for example, an investment manager or its authorised representative, to confirm the details of execution for a previously received RedemptionOrder message.|Usage|The RedemptionOrderConfirmation message is used to confirm the execution of one or more individual orders.|A RedemptionOrder message containing more than one individual order may be responded to by more than one RedemptionOrderConfirmation message, as the valuation cycle of the financial instruments in each individual order may be different. When a RedemptionOrderConfirmation message contains fewer confirmations that originally instructed in the original RedemptionOrder message, there is no specification indication in the confirmation for this. Reconciliation must be based on the references.|Each individual order confirmation specified is identified in DealReference. The reference of the original individual order is specified in OrderReference. The message identification of the RedemptionOrder message in which the individual order was conveyed may also be quoted in RelatedReference but this is not recommended.|A RedemptionOrder must in all cases be responded to by a RedemptionOrderConfirmation message and in no circumstances by a RedemptionBulkOrderConfirmation message.|If the executing party needs to confirm one or more redemption orders for the same financial instrument then a RedemptionBulkOrderConfirmation message must be used.|When the message is used to convey a confirmation amendment/s, the AmendmentIndicator must be present with the value ‘true’ or ‘1’. When this is the case, the message must only contain a confirmation amendment/s and not contain both a confirmation amendment/s and a ‘new’ confirmation/s."
)]
[IsoId("_Aab6QzbLEead9bDRE_1DAQ")]
[DisplayName("Redemption Order Confirmation V")]
public record RedemptionOrderConfirmationV04 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "setr.006.001.04";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "RedOrdrConf";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:setr.006.001.04";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Reference that uniquely identifies the message from a business application standpoint.
    /// </summary>
    [IsoId("_Aab6TTbLEead9bDRE_1DAQ")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    public required MessageIdentification1 MessageIdentification { get; init; }

    /// <summary>
    /// Collective reference identifying a set of messages.
    /// </summary>
    [IsoId("_Aab6TzbLEead9bDRE_1DAQ")]
    [DisplayName("Pool Reference")]
    [IsoXmlTag("PoolRef")]
    public AdditionalReference9? PoolReference { get; init; }

    /// <summary>
    /// Reference to a linked message that was previously sent.
    /// </summary>
    [IsoId("_Aab6UTbLEead9bDRE_1DAQ")]
    [DisplayName("Previous Reference")]
    [IsoXmlTag("PrvsRef")]
    public AdditionalReference8? PreviousReference { get; init; }

    /// <summary>
    /// Reference to a linked message that was previously received.
    /// </summary>
    [IsoId("_Aab6UzbLEead9bDRE_1DAQ")]
    [DisplayName("Related Reference")]
    [IsoXmlTag("RltdRef")]
    public AdditionalReference8? RelatedReference { get; init; }

    /// <summary>
    /// General information related to the execution of investment fund orders.
    /// </summary>
    [IsoId("_Aab6VTbLEead9bDRE_1DAQ")]
    [DisplayName("Multiple Execution Details")]
    [IsoXmlTag("MltplExctnDtls")]
    public required RedemptionMultipleExecution5 MultipleExecutionDetails { get; init; }

    /// <summary>
    /// Information provided when the message is a copy of a previous message.
    /// </summary>
    [IsoId("_Aab6WTbLEead9bDRE_1DAQ")]
    [DisplayName("Copy Details")]
    [IsoXmlTag("CpyDtls")]
    public CopyInformation4? CopyDetails { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_Aab6WzbLEead9bDRE_1DAQ")]
    [DisplayName("Extension")]
    [IsoXmlTag("Xtnsn")]
    public Extension1? Extension { get; init; }
}

// Since RedemptionOrderConfirmationV04Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to RedemptionOrderConfirmationV04.
