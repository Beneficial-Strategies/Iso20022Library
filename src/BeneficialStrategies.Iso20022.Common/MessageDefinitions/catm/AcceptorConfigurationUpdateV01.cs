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

namespace BeneficialStrategies.Iso20022.catm;

/// <summary>
/// This record is an implementation of the catm.003.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The AcceptorConfigurationUpdate message is sent by the master terminal manager or delegated terminal manager to the acceptor system for the update of acquirer parameters, merchant parameters, vendor parameters or cryptographic keys of the acquirer.
/// Usage
/// The AcceptorConfigurationUpdate message may embed the information required by the acceptor system for the configuration of:
/// - the application parameters necessary for software applications processed by the POI system,
/// - the acquirer protocol parameters for the message content and message exchange behaviour of the acquirer protocol supported by the POI system,
/// - the host communication parameters to define the addresses of the connected acquirer hosts, and
/// - the merchant parameters needed for the retailer protocol settings of the POI system.
/// </summary>
[Description(
    @"Scope|The AcceptorConfigurationUpdate message is sent by the master terminal manager or delegated terminal manager to the acceptor system for the update of acquirer parameters, merchant parameters, vendor parameters or cryptographic keys of the acquirer.|Usage|The AcceptorConfigurationUpdate message may embed the information required by the acceptor system for the configuration of:|- the application parameters necessary for software applications processed by the POI system,|- the acquirer protocol parameters for the message content and message exchange behaviour of the acquirer protocol supported by the POI system,|- the host communication parameters to define the addresses of the connected acquirer hosts, and|- the merchant parameters needed for the retailer protocol settings of the POI system."
)]
[IsoId("_AgFfYOQXEeCGktPI9k4Dlw_1733626146")]
[DisplayName("Acceptor Configuration Update V")]
public record AcceptorConfigurationUpdateV01 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "catm.003.001.01";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AccptrCfgtnUpd";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:catm.003.001.01";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Set of characteristics related to the transfer of the acceptor parameters.
    /// </summary>
    [IsoId("_AgFfYeQXEeCGktPI9k4Dlw_-1237434314")]
    [DisplayName("Header")]
    [IsoXmlTag("Hdr")]
    public required Header4 Header { get; init; }

    /// <summary>
    /// Acceptor configuration to be downloaded from the terminal management system.
    /// </summary>
    [IsoId("_AgFfYuQXEeCGktPI9k4Dlw_950623241")]
    [DisplayName("Acceptor Configuration")]
    [IsoXmlTag("AccptrCfgtn")]
    public required AcceptorConfiguration1 AcceptorConfiguration { get; init; }

    /// <summary>
    /// Trailer of the message containing a MAC or a digital signature.
    /// </summary>
    [IsoId("_AgFfY-QXEeCGktPI9k4Dlw_543485283")]
    [DisplayName("Security Trailer")]
    [IsoXmlTag("SctyTrlr")]
    public required ContentInformationType1 SecurityTrailer { get; init; }
}

// Since AcceptorConfigurationUpdateV01Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to AcceptorConfigurationUpdateV01.
