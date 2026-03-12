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
[IsoId("_Hnr6scVJEeeWeZMpNX1JUQ")]
[DisplayName("Securities Quantity Details SD")]
public partial record SecuritiesQuantityDetailsSD3
{
    #nullable enable
    
    /// <summary>
    /// For rights subscription events with an oversubscription feature, the quantity of the oversubscription for the given instruction.
    /// </summary>
    [IsoId("_H4NC88VJEeeWeZMpNX1JUQ")]
    [DisplayName("Oversubscription Quantity")]
    [IsoXmlTag("OvrsbcptQty")]
    public FinancialInstrumentQuantity4? OversubscriptionQuantity { get; init; } 
    
    /// <summary>
    /// Total oversubscription quantity of all transaction sequence instructions.
    /// </summary>
    [IsoId("_dvHr4MVJEeeWeZMpNX1JUQ")]
    [DisplayName("Total Oversubscription Quantity")]
    [IsoXmlTag("TtlOvrsbcptQty")]
    public FinancialInstrumentQuantity4? TotalOversubscriptionQuantity { get; init; } 
    
    /// <summary>
    /// Instruction quantity for a given transaction sequence number.
    /// </summary>
    [IsoId("_X-KicMVgEeeprYdSN88o0Q")]
    [DisplayName("Instruction Quantity")]
    [IsoXmlTag("InstrQty")]
    public FinancialInstrumentQuantity31Choice_? InstructionQuantity { get; init; } 
    
    
    #nullable disable
    
}
