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
/// This record is an implementation of the seev.017.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// This message is sent by a CSD to an issuer (or its agent) to request the authorisation to process the entitlement movements (cash and/or securities) calculated by the CSD for a given corporate action entire event, a given corporate action option and optionally a given resource.
/// This message can also be sent to request the issuer (or its agent) to make available / deliver the relevant resources to the CSD.
/// Usage
/// This message is used to request the authorisation to process the entitlement movements calculated by the CSD for a given corporate action event and option. An Agent Corporate Action Global Distribution Authorisation Request message must be sent for each option and if several resources are associated to an option, an Agent Corporate Action Global Distribution Authorisation Request message can be sent for each resource.
/// This message can also be used to pre-advise a global distribution authorisation request, in which case the value of the field pre-advice indicator must be set to yes.
/// </summary>
[Description(
    @"Scope|This message is sent by a CSD to an issuer (or its agent) to request the authorisation to process the entitlement movements (cash and/or securities) calculated by the CSD for a given corporate action entire event, a given corporate action option and optionally a given resource.|This message can also be sent to request the issuer (or its agent) to make available / deliver the relevant resources to the CSD.|Usage|This message is used to request the authorisation to process the entitlement movements calculated by the CSD for a given corporate action event and option. An Agent Corporate Action Global Distribution Authorisation Request message must be sent for each option and if several resources are associated to an option, an Agent Corporate Action Global Distribution Authorisation Request message can be sent for each resource.|This message can also be used to pre-advise a global distribution authorisation request, in which case the value of the field pre-advice indicator must be set to yes."
)]
[IsoId("_TNwP1dEwEd-BzquC8wXy7w_690310315")]
[DisplayName("Agent CA Global Distribution Authorisation Request V")]
public record AgentCAGlobalDistributionAuthorisationRequestV01 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "seev.017.001.01";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AgtCAGblDstrbtnAuthstnReq";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:seev.017.001.01";

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
    [IsoId("_TNwP1tEwEd-BzquC8wXy7w_1189279537")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required DocumentIdentification8 Identification { get; init; }

    /// <summary>
    /// General information about the corporate action event.
    /// </summary>
    [IsoId("_TNwP19EwEd-BzquC8wXy7w_806676079")]
    [DisplayName("Corporate Action General Information")]
    [IsoXmlTag("CorpActnGnlInf")]
    public required CorporateActionInformation1 CorporateActionGeneralInformation { get; init; }

    /// <summary>
    /// Provides detailed information about the global distribution.
    /// </summary>
    [IsoId("_TNwP2NEwEd-BzquC8wXy7w_959712876")]
    [DisplayName("Global Distribution Details")]
    [IsoXmlTag("GblDstrbtnDtls")]
    public required GlobalDistributionRequest1 GlobalDistributionDetails { get; init; }
}

// Since AgentCAGlobalDistributionAuthorisationRequestV01Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to AgentCAGlobalDistributionAuthorisationRequestV01.
