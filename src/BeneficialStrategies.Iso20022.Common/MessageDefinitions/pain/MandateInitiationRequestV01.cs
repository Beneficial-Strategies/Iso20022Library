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

namespace BeneficialStrategies.Iso20022.pain;

/// <summary>
/// This record is an implementation of the pain.009.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The MandateInitiationRequest message is sent by the initiator of the request to his agent. The initiator can either be the debtor or the creditor.
/// The MandateInitiationRequest message is forwarded by the agent of the initiator to the agent of the counterparty.
/// The MandateInitiationRequest message is used to set-up the instruction that allows the debtor agent to accept instructions from the creditor, through the creditor agent, to debit the account of the debtor.
/// Usage
/// The MandateInitiationRequest message can contain only one request to set-up one specific mandate.
/// The messages can be exchanged between creditor and creditor agent or debtor and debtor agent and between creditor agent and debtor agent.
/// The message can also be used by an initiating party that has authority to send the message on behalf of the creditor or debtor.
/// The MandateInitiationRequest message can be used in domestic and cross-border scenarios.
/// </summary>
[Description(
    @"Scope|The MandateInitiationRequest message is sent by the initiator of the request to his agent. The initiator can either be the debtor or the creditor.|The MandateInitiationRequest message is forwarded by the agent of the initiator to the agent of the counterparty.|The MandateInitiationRequest message is used to set-up the instruction that allows the debtor agent to accept instructions from the creditor, through the creditor agent, to debit the account of the debtor.|Usage|The MandateInitiationRequest message can contain only one request to set-up one specific mandate.|The messages can be exchanged between creditor and creditor agent or debtor and debtor agent and between creditor agent and debtor agent.|The message can also be used by an initiating party that has authority to send the message on behalf of the creditor or debtor.|The MandateInitiationRequest message can be used in domestic and cross-border scenarios."
)]
[IsoId("_GYN9SdEvEd-BzquC8wXy7w_93398652")]
[DisplayName("Mandate Initiation Request V")]
public record MandateInitiationRequestV01 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "pain.009.001.01";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "MndtInitnReq";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:pain.009.001.01";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Set of characteristics to identify the message and parties playing a role in the mandate initiation, but which are not part of the mandate.
    /// </summary>
    [IsoId("_GYN9StEvEd-BzquC8wXy7w_508184194")]
    [DisplayName("Group Header")]
    [IsoXmlTag("GrpHdr")]
    public required GroupHeader31 GroupHeader { get; init; }

    /// <summary>
    /// Set of elements used to provide the details of the mandate signed between the (ultimate) creditor and the (ultimate) debtor.
    /// </summary>
    [IsoId("_GYN9S9EvEd-BzquC8wXy7w_77760662")]
    [DisplayName("Mandate")]
    [IsoXmlTag("Mndt")]
    public required MandateInformation2 Mandate { get; init; }
}

// Since MandateInitiationRequestV01Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to MandateInitiationRequestV01.
