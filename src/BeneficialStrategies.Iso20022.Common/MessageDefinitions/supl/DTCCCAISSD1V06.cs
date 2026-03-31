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
/// This record is an implementation of the supl.030.001.06 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The DTCCCAISSD1 message extends ISO corporate action instruction status advice message with DTCC corporate action elements not covered in the standard message.
/// </summary>
[Description(
    @"The DTCCCAISSD1 message extends ISO corporate action instruction status advice message with DTCC corporate action elements not covered in the standard message."
)]
[IsoId("_Vk6qyzDmEey2N-DB7H7A5A")]
[DisplayName("DTCCCAISSD 1 V")]
public record DTCCCAISSD1V06 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "supl.030.001.06";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "DTCCCAISSD1";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:supl.030.001.06";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Information to be extended as supplementary data to instruction status message for reorganisation events.
    /// </summary>
    [IsoId("_Vk6qzTDmEey2N-DB7H7A5A")]
    [DisplayName("Reorganisation Instruction Details")]
    [IsoXmlTag("ReorgInstrDtls")]
    public ReorganisationInstructionSD12? ReorganisationInstructionDetails { get; init; }
}

// Since DTCCCAISSD1V06Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to DTCCCAISSD1V06.
