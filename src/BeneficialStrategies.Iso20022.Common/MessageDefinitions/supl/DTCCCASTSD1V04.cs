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
/// This record is an implementation of the supl.031.001.04 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The DTCCCASTSD1 message extends ISO corporate action instruction statement report message with DTCC corporate action elements not covered in the standard message.
/// </summary>
[Description(
    @"The DTCCCASTSD1 message extends ISO corporate action instruction statement report message with DTCC corporate action elements not covered in the standard message."
)]
[IsoId("_q_pK-Q4zEeuIpNw_GxsBOw")]
[DisplayName("DTCCCASTSD 1 V")]
public record DTCCCASTSD1V04 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "supl.031.001.04";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "DTCCCASTSD1";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:supl.031.001.04";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Information to be extended as supplementary data to corporate action balance details at event level.
    /// </summary>
    [IsoId("_q_pK-w4zEeuIpNw_GxsBOw")]
    [DisplayName("Event Balance Details")]
    [IsoXmlTag("EvtBalDtls")]
    public CorporateActionBalanceSD5? EventBalanceDetails { get; init; }

    /// <summary>
    /// Information to be extended as supplementary data to corporate action balance details at option level.
    /// </summary>
    [IsoId("_q_pK_Q4zEeuIpNw_GxsBOw")]
    [DisplayName("Total Instructed Balance Option Balance Details")]
    [IsoXmlTag("TtlInstdBalOptnBalDtls")]
    public CorporateActionInstructedBalanceOptionBalanceSD3? TotalInstructedBalanceOptionBalanceDetails { get; init; }

    /// <summary>
    /// Information to be extended as supplementary data to corporate action balance details at option instruction details level. Option level instruction details are referenced by unique instruction identification, instruction date, quantity and status of instruction.
    /// </summary>
    [IsoId("_q_pK_w4zEeuIpNw_GxsBOw")]
    [DisplayName("Total Instructed Balance Option Instruction Details")]
    [IsoXmlTag("TtlInstdBalOptnInstrDtls")]
    public CorporateActionInstructedBalanceOptionInstructionSD3? TotalInstructedBalanceOptionInstructionDetails { get; init; }

    /// <summary>
    /// Information to be extended as supplementary data to corporate action balance details at option protect instruction details level.
    /// </summary>
    [IsoId("_q_pLAQ4zEeuIpNw_GxsBOw")]
    [DisplayName("Total Instructed Balance Option Protect Instruction Details")]
    [IsoXmlTag("TtlInstdBalOptnPrtctInstrDtls")]
    public CorporateActionInstructedBalanceOptionProtectInstructionSD4? TotalInstructedBalanceOptionProtectInstructionDetails { get; init; }
}

// Since DTCCCASTSD1V04Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to DTCCCASTSD1V04.
