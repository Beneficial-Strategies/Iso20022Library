// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// DTC (The Depository Trust Company) Tax Relief service election details.
/// </summary>
[IsoId("_1b3BsjL3EeKU9IrkkToqcw_-1727266611")]
[DisplayName("DTC Tax Relief SD")]
public partial record DTCTaxReliefSD2
{
    #nullable enable
    
    /// <summary>
    /// xPath to the element that is being extended.
    /// </summary>
    [IsoId("_1b3BszL3EeKU9IrkkToqcw_892961340")]
    [DisplayName("Place And Name")]
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public required IsoMax350Text PlaceAndName { get; init; } 
    
    /// <summary>
    /// Provides information about the defined tax relief categories used by DTC (The Depository Trust Corporation).
    /// </summary>
    [IsoId("_1b3BtDL3EeKU9IrkkToqcw_1733228081")]
    [DisplayName("DTC Tax Relief Category")]
    [IsoXmlTag("DTCTaxRlfCtgy")]
    public required DTCTaxReliefSD1 DTCTaxReliefCategory { get; init; } 
    
    /// <summary>
    /// Instructed quantity for DTC Tax Relief service elections.
    /// </summary>
    [IsoId("_1b3BtTL3EeKU9IrkkToqcw_-633817074")]
    [DisplayName("Instruction Quantity")]
    [IsoXmlTag("InstrQty")]
    public required FinancialInstrumentQuantity15Choice_ InstructionQuantity { get; init; } 
    
    
    #nullable disable
    
}
