// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information about securities quantity linked to a corporate action option.
/// </summary>
[IsoId("_b5LodMYOEeexPc-mfUU5zQ")]
[DisplayName("Securities Quantity Details SD")]
public record SecuritiesQuantityDetailsSD4
{
    /// <summary>
    /// For rights subscription events with an oversubscription feature, the quantity of the oversubscription for the given instruction.
    /// </summary>
    [IsoId("_b5LodsYOEeexPc-mfUU5zQ")]
    [DisplayName("Oversubscription Quantity")]
    [IsoXmlTag("OvrsbcptQty")]
    public FinancialInstrumentQuantity4? OversubscriptionQuantity { get; init; }

    /// <summary>
    /// Total oversubscription quantity of all transaction sequence instructions.
    /// </summary>
    [IsoId("_b5LodcYOEeexPc-mfUU5zQ")]
    [DisplayName("Total Oversubscription Quantity")]
    [IsoXmlTag("TtlOvrsbcptQty")]
    public FinancialInstrumentQuantity4? TotalOversubscriptionQuantity { get; init; }

    /// <summary>
    /// Instruction quantity for a given transaction sequence number.
    /// </summary>
    [IsoId("_b5Lod8YOEeexPc-mfUU5zQ")]
    [DisplayName("Instruction Quantity")]
    [IsoXmlTag("InstrQty")]
    public FinancialInstrumentQuantity31Choice_? InstructionQuantity { get; init; }

    /// <summary>
    /// Quantity not fully covered.
    /// </summary>
    [IsoId("_sPgWoMYOEeexPc-mfUU5zQ")]
    [DisplayName("Open Uncovered Quantity")]
    [IsoXmlTag("OpnUcvrdQty")]
    public FinancialInstrumentQuantity31Choice_? OpenUncoveredQuantity { get; init; }

    /// <summary>
    /// Quantity covered but transactions not in &quot;MADE&quot; status.
    /// </summary>
    [IsoId("_u1-poMYOEeexPc-mfUU5zQ")]
    [DisplayName("Interim Covered Quantity")]
    [IsoXmlTag("IntrmCvrdQty")]
    public FinancialInstrumentQuantity31Choice_? InterimCoveredQuantity { get; init; }
}
