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
/// This record is an implementation of the seev.025.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// This message is sent by a CSD to the issuer (or its agent) to provide the issuer (or its agent) with the CSD&apos;s client details for the distribution of the proceeds of a corporate action event:
/// - Gross or net payments.
/// - Delivery details for securities that have to be delivered outside of the CSD.
/// - Delivery details for cash amounts that have to be delivered outside of the CSD.
/// Usage
/// This message is used to request the issuer (or its agent) to put a standing instruction in place for proceeds.
/// The amendment of a standing instruction is done through a cancel-and-replace mechanism. First a standing instruction cancellation request is sent followed by a new standing instruction request.
/// </summary>
[Description(
    @"Scope|This message is sent by a CSD to the issuer (or its agent) to provide the issuer (or its agent) with the CSD's client details for the distribution of the proceeds of a corporate action event:|- Gross or net payments.|- Delivery details for securities that have to be delivered outside of the CSD.|- Delivery details for cash amounts that have to be delivered outside of the CSD.|Usage|This message is used to request the issuer (or its agent) to put a standing instruction in place for proceeds.|The amendment of a standing instruction is done through a cancel-and-replace mechanism. First a standing instruction cancellation request is sent followed by a new standing instruction request."
)]
[IsoId("_TR6-KdEwEd-BzquC8wXy7w_1831735017")]
[DisplayName("Agent CA Standing Instruction Request V")]
public record AgentCAStandingInstructionRequestV01 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "seev.025.001.01";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AgtCAStgInstrReq";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:seev.025.001.01";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Identification assigned by the Sender to unambiguously identify the request.
    /// </summary>
    [IsoId("_TR6-KtEwEd-BzquC8wXy7w_-325890589")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required DocumentIdentification8 Identification { get; init; }

    /// <summary>
    /// General information about the standing instruction.
    /// </summary>
    [IsoId("_TR6-K9EwEd-BzquC8wXy7w_199276822")]
    [DisplayName("Standing Instruction General Information")]
    [IsoXmlTag("StgInstrGnlInf")]
    public required CorporateActionStandingInstructionGeneralInformation1 StandingInstructionGeneralInformation { get; init; }

    /// <summary>
    /// Provides detailed information about the standing instruction.
    /// </summary>
    [IsoId("_TR6-LNEwEd-BzquC8wXy7w_1084668578")]
    [DisplayName("Standing Instruction Details")]
    [IsoXmlTag("StgInstrDtls")]
    public required CorporateActionStandingInstruction1 StandingInstructionDetails { get; init; }

    /// <summary>
    /// Contact responsible for the transaction identified in the message.
    /// </summary>
    [IsoId("_TR6-LdEwEd-BzquC8wXy7w_1089871682")]
    [DisplayName("Contact Details")]
    [IsoXmlTag("CtctDtls")]
    public ContactPerson1? ContactDetails { get; init; }
}

// Since AgentCAStandingInstructionRequestV01Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to AgentCAStandingInstructionRequestV01.
