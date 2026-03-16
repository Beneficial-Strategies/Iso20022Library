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
/// This record is an implementation of the setr.015.001.04 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The SwitchOrderConfirmation message is sent by an executing party, for example, a transfer agent, to the instructing party, for example, an investment manager or its authorised representative, to confirm the details of the execution of a previously received SwitchOrder instruction.
/// Usage
/// The SwitchOrderConfirmation message is used to confirm that all the legs of the previously instructed switch order have been executed. The reference of the switch order confirmation is identified in DealReference.
/// The reference of the original switch order is specified in OrderReference. The message identification of the SwitchOrder message in which the switch order was conveyed may also be quoted in RelatedReference but this is not recommended.
/// When the message is used to convey a confirmation amendment/s, the AmendmentIndicator must be present with the value ‘true’ or ‘1’. When this is the case, the message must only contain a confirmation amendment/s and not contain both a confirmation amendment/s and a ‘new’ confirmation/s.
/// </summary>
[Description(
    @"Scope|The SwitchOrderConfirmation message is sent by an executing party, for example, a transfer agent, to the instructing party, for example, an investment manager or its authorised representative, to confirm the details of the execution of a previously received SwitchOrder instruction.|Usage|The SwitchOrderConfirmation message is used to confirm that all the legs of the previously instructed switch order have been executed. The reference of the switch order confirmation is identified in DealReference.|The reference of the original switch order is specified in OrderReference. The message identification of the SwitchOrder message in which the switch order was conveyed may also be quoted in RelatedReference but this is not recommended.|When the message is used to convey a confirmation amendment/s, the AmendmentIndicator must be present with the value ‘true’ or ‘1’. When this is the case, the message must only contain a confirmation amendment/s and not contain both a confirmation amendment/s and a ‘new’ confirmation/s."
)]
[IsoId("_Aab7DTbLEead9bDRE_1DAQ")]
[DisplayName("Switch Order Confirmation V")]
public record SwitchOrderConfirmationV04 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "setr.015.001.04";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "SwtchOrdrConf";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:setr.015.001.04";

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
    [IsoId("_Aab7FzbLEead9bDRE_1DAQ")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    public required MessageIdentification1 MessageIdentification { get; init; }

    /// <summary>
    /// Collective reference identifying a set of messages.
    /// </summary>
    [IsoId("_Aab7GTbLEead9bDRE_1DAQ")]
    [DisplayName("Pool Reference")]
    [IsoXmlTag("PoolRef")]
    public AdditionalReference9? PoolReference { get; init; }

    /// <summary>
    /// Reference to a linked message that was previously sent.
    /// </summary>
    [IsoId("_Aab7GzbLEead9bDRE_1DAQ")]
    [DisplayName("Previous Reference")]
    [IsoXmlTag("PrvsRef")]
    public AdditionalReference8? PreviousReference { get; init; }

    /// <summary>
    /// Reference to a linked message that was previously received.
    /// </summary>
    [IsoId("_Aab7HTbLEead9bDRE_1DAQ")]
    [DisplayName("Related Reference")]
    [IsoXmlTag("RltdRef")]
    public AdditionalReference8? RelatedReference { get; init; }

    /// <summary>
    /// Information related to a switch execution.
    /// </summary>
    [IsoId("_Aab7HzbLEead9bDRE_1DAQ")]
    [DisplayName("Switch Execution Details")]
    [IsoXmlTag("SwtchExctnDtls")]
    public required SwitchExecution7 SwitchExecutionDetails { get; init; }

    /// <summary>
    /// Information provided when the message is a copy of a previous message.
    /// </summary>
    [IsoId("_Aab7ITbLEead9bDRE_1DAQ")]
    [DisplayName("Copy Details")]
    [IsoXmlTag("CpyDtls")]
    public CopyInformation4? CopyDetails { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_Aab7IzbLEead9bDRE_1DAQ")]
    [DisplayName("Extension")]
    [IsoXmlTag("Xtnsn")]
    public Extension1? Extension { get; init; }
}

// Since SwitchOrderConfirmationV04Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to SwitchOrderConfirmationV04.
