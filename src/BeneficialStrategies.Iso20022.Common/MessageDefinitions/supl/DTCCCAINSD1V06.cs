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
/// This record is an implementation of the supl.008.001.06 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The DTCCCAINSD1 message extends ISO corporate action instruction message with DTCC corporate action elements not covered in the standard message.
/// </summary>
[Description(
    @"The DTCCCAINSD1 message extends ISO corporate action instruction message with DTCC corporate action elements not covered in the standard message."
)]
[IsoId("_q_pKgQ4zEeuIpNw_GxsBOw")]
[DisplayName("DTCCCAINSD 1 V")]
public record DTCCCAINSD1V06 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "supl.008.001.06";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "DTCCCAINSD1";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:supl.008.001.06";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// DTC (The Depository Trust Corporation) optional dividend service election.
    /// </summary>
    [IsoId("_q_pKgw4zEeuIpNw_GxsBOw")]
    [DisplayName("Optional Dividend")]
    [IsoXmlTag("OptnlDvdd")]
    public OptionalDividendAccountQuantitySD3? OptionalDividend { get; init; }

    /// <summary>
    /// DTC (The Depository Trust Corporation) tax exempt service election.
    /// </summary>
    [IsoId("_q_pKiw4zEeuIpNw_GxsBOw")]
    [DisplayName("Tax Exempt")]
    [IsoXmlTag("TaxXmpt")]
    public TaxExemptQuantitySD2? TaxExempt { get; init; }

    /// <summary>
    /// Tax category number assigned on the announcement to provide a breakdown at a category level on the inbound instruction to determine tax treatment as required by issuers, their agents, or tax authorities.
    /// </summary>
    [IsoId("_q_pKkw4zEeuIpNw_GxsBOw")]
    [DisplayName("Tax Category")]
    [IsoXmlTag("TaxCtgy")]
    [MinLength(0)]
    [MaxLength(99)]
    public ValueList<TaxCategory2> TaxCategory { get; init; } = [];

    /// <summary>
    /// DTC (The Depository Trust Corporation) foreign currency payment service wire payment instruction.
    /// </summary>
    [IsoId("_q_pKlQ4zEeuIpNw_GxsBOw")]
    [DisplayName("Wire Instruction")]
    [IsoXmlTag("WireInstr")]
    public WireInstructionSD3? WireInstruction { get; init; }

    /// <summary>
    /// Information to be extended as supplementary data to instruction message for reorganisation events.
    /// </summary>
    [IsoId("_q_pKnQ4zEeuIpNw_GxsBOw")]
    [DisplayName("Reorganisation Instruction Details")]
    [IsoXmlTag("ReorgInstrDtls")]
    public ReorganisationInstructionSD10? ReorganisationInstructionDetails { get; init; }
}

// Since DTCCCAINSD1V06Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to DTCCCAINSD1V06.
