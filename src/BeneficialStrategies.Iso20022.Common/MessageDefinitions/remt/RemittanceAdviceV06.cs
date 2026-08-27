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

namespace BeneficialStrategies.Iso20022.remt;

/// <summary>
/// This record is an implementation of the remt.001.001.06 ISO standard message type.
/// The RemittanceAdvice message allows the originator to provide remittance details that can be associated with a payment.
/// </summary>
[Description(
    @"The RemittanceAdvice message allows the originator to provide remittance details that can be associated with a payment."
)]
[IsoId("_R3SUrTEZEe6kQ-WGAhcVPQ")]
[DisplayName("Remittance Advice V06")]
public record RemittanceAdviceV06 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "remt.001.001.06";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "RmtAdvc";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:remt.001.001.06";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Set of characteristics shared by all remittance information included in the message.
    /// </summary>
    [IsoId("_R3SUtzEZEe6kQ-WGAhcVPQ")]
    [DisplayName("Group Header")]
    [IsoXmlTag("GrpHdr")]
    public required GroupHeader122 GroupHeader { get; init; }

    /// <summary>
    /// Provides information to enable the matching of an entry with the items that the associated payment is intended to settle, such as commercial invoices in an accounts' receivable system, tax obligations, or garnishment orders.
    /// </summary>
    [IsoId("_R3SUuTEZEe6kQ-WGAhcVPQ")]
    [DisplayName("Remittance Information")]
    [IsoXmlTag("RmtInf")]
    public ValueList<RemittanceInformation23> RemittanceInformation { get; init; } = [];

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_R3SUuzEZEe6kQ-WGAhcVPQ")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
