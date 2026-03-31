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
/// This record is an implementation of the remt.002.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The RemittanceLocationAdvice message allows the originator of the message to identify where the remittance advice is located for a related payment.
/// </summary>
[Description(
    @"The RemittanceLocationAdvice message allows the originator of the message to identify where the remittance advice is located for a related payment."
)]
[IsoId("_10RAoKMDEeKl_NvHIICqIw")]
[DisplayName("Remittance Location Advice V")]
public record RemittanceLocationAdviceV01 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "remt.002.001.01";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "RmtLctnAdvc";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:remt.002.001.01";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Set of characteristics shared by all remittance location information included in the message.
    /// </summary>
    [IsoId("_CPP6oKMEEeKl_NvHIICqIw")]
    [DisplayName("Group Header")]
    [IsoXmlTag("GrpHdr")]
    public required GroupHeader62 GroupHeader { get; init; }

    /// <summary>
    /// Provides information related to location and/or delivery of the remittance information. This information is used to enable the matching of an entry with the items that the associated payment is intended to settle.
    /// </summary>
    [IsoId("_EkZ0IKMEEeKl_NvHIICqIw")]
    [DisplayName("Remittance Location")]
    [IsoXmlTag("RmtLctn")]
    public required RemittanceLocation3 RemittanceLocation { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_jk6zoId2EeOtHe_dAuWsBQ")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}

// Since RemittanceLocationAdviceV01Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to RemittanceLocationAdviceV01.
