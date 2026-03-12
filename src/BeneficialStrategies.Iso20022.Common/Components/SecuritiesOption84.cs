// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the security option of a corporate event.
/// </summary>
[IsoId("_ptJq_Ti7Eeydid5dcNPKvg")]
[DisplayName("Securities Option")]
public partial record SecuritiesOption84
{
    #nullable enable
    
    /// <summary>
    /// Maximum quantity of financial instrument that may be instructed.
    /// </summary>
    [IsoId("_ptJrATi7Eeydid5dcNPKvg")]
    [DisplayName("Maximum Quantity To Instruct")]
    [IsoXmlTag("MaxQtyToInst")]
    public FinancialInstrumentQuantity44Choice_? MaximumQuantityToInstruct { get; init; } 
    
    /// <summary>
    /// Minimum quantity of financial instrument that may be instructed.
    /// </summary>
    [IsoId("_ptJrCTi7Eeydid5dcNPKvg")]
    [DisplayName("Minimum Quantity To Instruct")]
    [IsoXmlTag("MinQtyToInst")]
    public FinancialInstrumentQuantity44Choice_? MinimumQuantityToInstruct { get; init; } 
    
    /// <summary>
    /// Minimum multiple quantity of financial instrument that may be instructed.
    /// </summary>
    [IsoId("_ptJrETi7Eeydid5dcNPKvg")]
    [DisplayName("Minimum Multiple Quantity To Instruct")]
    [IsoXmlTag("MinMltplQtyToInst")]
    public FinancialInstrumentQuantity43Choice_? MinimumMultipleQuantityToInstruct { get; init; } 
    
    /// <summary>
    /// Quantity of equity that makes up the new board lot.
    /// </summary>
    [IsoId("_ptJrGTi7Eeydid5dcNPKvg")]
    [DisplayName("New Board Lot Quantity")]
    [IsoXmlTag("NewBrdLotQty")]
    public FinancialInstrumentQuantity43Choice_? NewBoardLotQuantity { get; init; } 
    
    /// <summary>
    /// New denomination of the equity following, for example, an increase or decrease in nominal value.
    /// </summary>
    [IsoId("_ptJrITi7Eeydid5dcNPKvg")]
    [DisplayName("New Denomination Quantity")]
    [IsoXmlTag("NewDnmtnQty")]
    public FinancialInstrumentQuantity43Choice_? NewDenominationQuantity { get; init; } 
    
    /// <summary>
    /// Specifies that if an order is prorated holders of odd lots who tender their full position will not have tendered position prorated but rather accepted in full.
    /// </summary>
    [IsoId("_ptJrKTi7Eeydid5dcNPKvg")]
    [DisplayName("Front End Odd Lot Quantity")]
    [IsoXmlTag("FrntEndOddLotQty")]
    public FinancialInstrumentQuantity43Choice_? FrontEndOddLotQuantity { get; init; } 
    
    /// <summary>
    /// Represents the presence of a back end odd lot provision and the quantity of equity required after proration to be eligible for this privilege.
    /// </summary>
    [IsoId("_ptJrMTi7Eeydid5dcNPKvg")]
    [DisplayName("Back End Odd Lot Quantity")]
    [IsoXmlTag("BckEndOddLotQty")]
    public FinancialInstrumentQuantity43Choice_? BackEndOddLotQuantity { get; init; } 
    
    
    #nullable disable
    
}
