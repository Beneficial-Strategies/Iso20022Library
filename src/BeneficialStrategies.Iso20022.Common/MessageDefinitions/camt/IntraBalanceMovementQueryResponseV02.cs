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

namespace BeneficialStrategies.Iso20022.camt;

/// <summary>
/// This record is an implementation of the camt.079.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// </summary>
[IsoId("_R3OqNTEZEe6kQ-WGAhcVPQ")]
[DisplayName("Intra Balance Movement Query Response V02")]
public record IntraBalanceMovementQueryResponseV02 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "camt.079.001.02";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "IntraBalMvmntQryRspn";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:camt.079.001.02";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Identification.
    /// </summary>
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public DocumentIdentification51? Identification { get; init; }

    /// <summary>
    /// Pagination.
    /// </summary>
    [DisplayName("Pagination")]
    [IsoXmlTag("Pgntn")]
    public required Pagination1 Pagination { get; init; }

    /// <summary>
    /// Report General Details.
    /// </summary>
    [DisplayName("Report General Details")]
    [IsoXmlTag("RptGnlDtls")]
    public required MovementReport1 ReportGeneralDetails { get; init; }

    /// <summary>
    /// Report Or Error.
    /// </summary>
    [DisplayName("Report Or Error")]
    [IsoXmlTag("RptOrErr")]
    public IntraBalanceOrOperationalError11Choice_? ReportOrError { get; init; }
}

// Since IntraBalanceMovementQueryResponseV02Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to IntraBalanceMovementQueryResponseV02.
