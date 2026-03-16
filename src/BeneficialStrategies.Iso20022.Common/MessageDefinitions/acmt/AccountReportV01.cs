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

namespace BeneficialStrategies.Iso20022.acmt;

/// <summary>
/// This record is an implementation of the acmt.014.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The AccountReport message is sent from a financial institution to an organisation for reporting purposes.
/// Usage
/// It can be sent unsolicited as part of opening, maintenance, or closing process, or it can be sent as response to an AccountReportRequest message.
/// </summary>
[Description(
    @"Scope|The AccountReport message is sent from a financial institution to an organisation for reporting purposes.|Usage|It can be sent unsolicited as part of opening, maintenance, or closing process, or it can be sent as response to an AccountReportRequest message."
)]
[IsoId("_vtUU2NE9Ed-BzquC8wXy7w_446669337")]
[DisplayName("Account Report V")]
public record AccountReportV01 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "acmt.014.001.01";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AcctRpt";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:acmt.014.001.01";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Set of elements for the identification of the message and related references.
    /// </summary>
    [IsoId("_vtUU2dE9Ed-BzquC8wXy7w_-501291820")]
    [DisplayName("References")]
    [IsoXmlTag("Refs")]
    public required References5 References { get; init; }

    /// <summary>
    /// Unique and unambiguous identifier of a financial institution, as assigned under an internationally recognised or proprietary identification scheme. |.
    /// </summary>
    [IsoId("_vtUU2tE9Ed-BzquC8wXy7w_-1906603151")]
    [DisplayName("Account Servicer Identification")]
    [IsoXmlTag("AcctSvcrId")]
    public required BranchAndFinancialInstitutionIdentification4 AccountServicerIdentification { get; init; }

    /// <summary>
    /// Organised structure that is set up for a particular purpose, for example, a business, government body, department, charity, or financial institution.
    /// </summary>
    [IsoId("_vtdewNE9Ed-BzquC8wXy7w_-1289032009")]
    [DisplayName("Organisation")]
    [IsoXmlTag("Org")]
    public required Organisation6 Organisation { get; init; }

    /// <summary>
    /// Account report.
    /// </summary>
    [IsoId("_vtdewdE9Ed-BzquC8wXy7w_1826995567")]
    [DisplayName("Report")]
    [IsoXmlTag("Rpt")]
    public AccountReport1? Report { get; init; }

    /// <summary>
    /// Contains the signature with its components, namely signed info, signature value, key info and the object.
    /// </summary>
    [IsoId("_vtdewtE9Ed-BzquC8wXy7w_1985192498")]
    [DisplayName("Digital Signature")]
    [IsoXmlTag("DgtlSgntr")]
    public PartyAndSignature1? DigitalSignature { get; init; }
}

// Since AccountReportV01Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to AccountReportV01.
