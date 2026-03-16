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
/// This record is an implementation of the catm.002.001.03 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Terminal maintenance actions to be performed by a point of interaction (POI).
/// </summary>
[Description(@"Terminal maintenance actions to be performed by a point of interaction (POI).")]
[IsoId("_sO3hwTWBEeODSIIQsYYKhw")]
[DisplayName("Management Plan Replacement V")]
public record ManagementPlanReplacementV03 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "catm.002.001.03";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "MgmtPlanRplcmnt";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:catm.002.001.03";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Set of characteristics related to the transfer of the management plan.
    /// </summary>
    [IsoId("_sO3hwzWBEeODSIIQsYYKhw")]
    [DisplayName("Header")]
    [IsoXmlTag("Hdr")]
    public required Header4 Header { get; init; }

    /// <summary>
    /// Sequence of terminal maintenance actions to be performed by a point of interaction (POI).
    /// </summary>
    [IsoId("_sO3hxTWBEeODSIIQsYYKhw")]
    [DisplayName("Management Plan")]
    [IsoXmlTag("MgmtPlan")]
    public required ManagementPlan3 ManagementPlan { get; init; }

    /// <summary>
    /// Trailer of the message containing a MAC or a digital signature.
    /// </summary>
    [IsoId("_sO3hxzWBEeODSIIQsYYKhw")]
    [DisplayName("Security Trailer")]
    [IsoXmlTag("SctyTrlr")]
    public required ContentInformationType9 SecurityTrailer { get; init; }
}

// Since ManagementPlanReplacementV03Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to ManagementPlanReplacementV03.
