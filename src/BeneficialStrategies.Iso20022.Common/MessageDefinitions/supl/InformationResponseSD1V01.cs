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

namespace BeneficialStrategies.Iso20022.supl;

/// <summary>
/// This record is an implementation of the supl.027.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// This extends the message InformationRequestResponse.
/// </summary>
[Description(@"This extends the message InformationRequestResponse.")]
[IsoId("_8nOCwC_7EeOKib24wnHaFg")]
[DisplayName("Information Response SD 1 V")]
public record InformationResponseSD1V01 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "supl.027.001.01";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "InfRspnSD1";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:supl.027.001.01";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Information used to identify the request.
    /// </summary>
    [IsoId("_hWzaoJirEeO4o528ngEXuw")]
    [DisplayName("Investigation Identification")]
    [IsoXmlTag("InvstgtnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text InvestigationIdentification { get; init; }

    /// <summary>
    /// Date and time of creation of the extension.
    /// </summary>
    [IsoId("_pfuCgJirEeO4o528ngEXuw")]
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime CreationDateTime { get; init; }

    /// <summary>
    /// Identifies the account servicing institution.
    /// </summary>
    [IsoId("_oUIuoC_8EeOKib24wnHaFg")]
    [DisplayName("Account Servicer Identification")]
    [IsoXmlTag("AcctSvcrId")]
    public required BranchAndFinancialInstitutionIdentification4 AccountServicerIdentification { get; init; }

    /// <summary>
    /// Requested account and its owners.
    /// </summary>
    [IsoId("_jqrv4C__EeOKib24wnHaFg")]
    [DisplayName("Account And Parties")]
    [IsoXmlTag("AcctAndPties")]
    public required AccountAndParties2 AccountAndParties { get; init; }
}

// Since InformationResponseSD1V01Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to InformationResponseSD1V01.
