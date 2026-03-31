// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Reference data instruments that are no longer valid either through an instrument update or that have passed their termination date.
/// </summary>
[IsoId("_IEREBX5aEea2k7EBUopqxw")]
[DisplayName("Securities Invalid Reference Data Report")]
public record SecuritiesInvalidReferenceDataReport3
{
    /// <summary>
    /// Instrument details at the time this specific details on the financial instrument was invalidated.
    /// </summary>
    [IsoId("_INfRcX5aEea2k7EBUopqxw")]
    [DisplayName("Financial Instrument")]
    [IsoXmlTag("FinInstrm")]
    public required SecuritiesReferenceDataReport5 FinancialInstrument { get; init; }

    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_INfRc35aEea2k7EBUopqxw")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
