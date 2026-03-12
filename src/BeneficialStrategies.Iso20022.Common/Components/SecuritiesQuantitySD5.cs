// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information about securities quantity linked to a corporate action option.
/// </summary>
[IsoId("_bKYDAecnEei5aPS232E3Mw")]
[DisplayName("Securities Quantity SD")]
public partial record SecuritiesQuantitySD5
{
    #nullable enable
    
    /// <summary>
    /// Instruction quantity for a given transaction sequence number.
    /// </summary>
    [IsoId("_bxgUdecnEei5aPS232E3Mw")]
    [DisplayName("Instruction Quantity")]
    [IsoXmlTag("InstrQty")]
    public FinancialInstrumentQuantity31Choice_? InstructionQuantity { get; init; } 
    
    /// <summary>
    /// For rights subscription events with an oversubscription feature, the quantity of the oversubscription for the given instruction.
    /// </summary>
    [IsoId("_bxgUcecnEei5aPS232E3Mw")]
    [DisplayName("Oversubscription Quantity")]
    [IsoXmlTag("OvrsbcptQty")]
    public FinancialInstrumentQuantity4? OversubscriptionQuantity { get; init; } 
    
    /// <summary>
    /// Total oversubscription quantity of all transaction sequence instructions.
    /// </summary>
    [IsoId("_bxgUc-cnEei5aPS232E3Mw")]
    [DisplayName("Total Oversubscription Quantity")]
    [IsoXmlTag("TtlOvrsbcptQty")]
    public FinancialInstrumentQuantity4? TotalOversubscriptionQuantity { get; init; } 
    
    /// <summary>
    /// Quantity covered but transactions not in &quot;MADE&quot; status.
    /// </summary>
    [IsoId("_bxgUeecnEei5aPS232E3Mw")]
    [DisplayName("Interim Covered Quantity")]
    [IsoXmlTag("IntrmCvrdQty")]
    public FinancialInstrumentQuantity31Choice_? InterimCoveredQuantity { get; init; } 
    
    
    #nullable disable
    
}
