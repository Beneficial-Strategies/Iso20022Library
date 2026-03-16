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

namespace BeneficialStrategies.Iso20022.seev;

/// <summary>
/// This record is an implementation of the seev.028.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// This message is sent by an issuer (or its agent) to the CSD to instruct the deactivation of a corporate action event or to deactivate one or more specific options of the corporate action. As of the deactivation date, the CSD is allowed to reject any related election instruction received from clients.
/// Usage
/// Deactivation refers only to the empowerment of the CSD to reject further elections. To withdraw an event, the Agent Corporate Action Notification Advice message must be used.
/// This message can be used to deactivate all the options of a corporate action event, in which case, no option should be mentioned in the message.
/// This message can also be used to deactivate one or more specific corporate action options, in which case, the option type and option number must be present.
/// This message can only be used when the deactivation date is after the market deadline. Before the market deadline, an updated notification advice message must be sent with option availability status: inactive or cancelled.
/// An un-effected deactivation (pending deactivation date/time) can be cancelled with an Agent Corporate Action Deactivation Cancellation Request.
/// The amendment of a deactivation is effected by cancel/replace mechanism.
/// </summary>
[Description(
    @"Scope|This message is sent by an issuer (or its agent) to the CSD to instruct the deactivation of a corporate action event or to deactivate one or more specific options of the corporate action. As of the deactivation date, the CSD is allowed to reject any related election instruction received from clients.|Usage|Deactivation refers only to the empowerment of the CSD to reject further elections. To withdraw an event, the Agent Corporate Action Notification Advice message must be used.|This message can be used to deactivate all the options of a corporate action event, in which case, no option should be mentioned in the message.|This message can also be used to deactivate one or more specific corporate action options, in which case, the option type and option number must be present.|This message can only be used when the deactivation date is after the market deadline. Before the market deadline, an updated notification advice message must be sent with option availability status: inactive or cancelled.|An un-effected deactivation (pending deactivation date/time) can be cancelled with an Agent Corporate Action Deactivation Cancellation Request.|The amendment of a deactivation is effected by cancel/replace mechanism."
)]
[IsoId("_TMHRHdEwEd-BzquC8wXy7w_1150162088")]
[DisplayName("Agent CA Deactivation Instruction V")]
public record AgentCADeactivationInstructionV01 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "seev.028.001.01";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AgtCADeactvtnInstr";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:seev.028.001.01";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Identification assigned by the Sender to unambiguously identify the instruction.
    /// </summary>
    [IsoId("_TMQbANEwEd-BzquC8wXy7w_-840620052")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required DocumentIdentification8 Identification { get; init; }

    /// <summary>
    /// General information about the corporate action event.
    /// </summary>
    [IsoId("_TMQbAdEwEd-BzquC8wXy7w_-1767832374")]
    [DisplayName("Corporate Action General Information")]
    [IsoXmlTag("CorpActnGnlInf")]
    public required CorporateActionInformation1 CorporateActionGeneralInformation { get; init; }

    /// <summary>
    /// Information related to the deactivation of a CA event.
    /// </summary>
    [IsoId("_TMQbAtEwEd-BzquC8wXy7w_-1426185033")]
    [DisplayName("Deactivation Details")]
    [IsoXmlTag("DeactvtnDtls")]
    public required CorporateActionDeactivationInstruction1 DeactivationDetails { get; init; }
}

// Since AgentCADeactivationInstructionV01Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to AgentCADeactivationInstructionV01.
