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
/// This record is an implementation of the acmt.014.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The AccountReport message is sent from a financial institution to an organisation for reporting purposes. It can be sent unsolicited as part of opening, maintenance, or closing process, or it can be sent as response to an AccountReportRequest message.
/// </summary>
[Description(
    @"The AccountReport message is sent from a financial institution to an organisation for reporting purposes. It can be sent unsolicited as part of opening, maintenance, or closing process, or it can be sent as response to an AccountReportRequest message."
)]
[IsoId("_fBFHUQ1TEeKGXqvMN6jpiw")]
[DisplayName("Account Report V")]
public record AccountReportV02 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "acmt.014.001.02";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AcctRpt";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:acmt.014.001.02";

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
    [IsoId("_fBO4UQ1TEeKGXqvMN6jpiw")]
    [DisplayName("References")]
    [IsoXmlTag("Refs")]
    public required References5 References { get; init; }

    /// <summary>
    /// Identifies the business sender of the message, if it is not the account owner or account servicing financial institution.
    /// </summary>
    [IsoId("_rpYSUA1YEeKGXqvMN6jpiw")]
    [DisplayName("From")]
    [IsoXmlTag("Fr")]
    public OrganisationIdentification8? From { get; init; }

    /// <summary>
    /// Unique and unambiguous identifier of a financial institution, as assigned under an internationally recognised or proprietary identification scheme. |.
    /// </summary>
    [IsoId("_fBO4VQ1TEeKGXqvMN6jpiw")]
    [DisplayName("Account Servicer Identification")]
    [IsoXmlTag("AcctSvcrId")]
    public required BranchAndFinancialInstitutionIdentification5 AccountServicerIdentification { get; init; }

    /// <summary>
    /// Organised structure that is set up for a particular purpose, for example, a business, government body, department, charity, or financial institution.
    /// </summary>
    [IsoId("_fBO4WQ1TEeKGXqvMN6jpiw")]
    [DisplayName("Organisation")]
    [IsoXmlTag("Org")]
    public required Organisation12 Organisation { get; init; }

    /// <summary>
    /// Account report.
    /// </summary>
    [IsoId("_fBO4XQ1TEeKGXqvMN6jpiw")]
    [DisplayName("Report")]
    [IsoXmlTag("Rpt")]
    public AccountReport15? Report { get; init; }

    /// <summary>
    /// Contains the signature with its components, namely signed info, signature value, key info and the object.
    /// </summary>
    [IsoId("_fBO4YQ1TEeKGXqvMN6jpiw")]
    [DisplayName("Digital Signature")]
    [IsoXmlTag("DgtlSgntr")]
    public PartyAndSignature2? DigitalSignature { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_d5SQMA4AEeKGXqvMN6jpiw")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}

// Since AccountReportV02Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to AccountReportV02.
