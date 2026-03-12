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
[IsoId("_CfMJYeGaEd-1Ktb5rVaajw")]
[DisplayName("Securities Option")]
public partial record SecuritiesOption15
{
    #nullable enable
    
    /// <summary>
    /// Maximum quantity (or lot) of financial instrument that must be exercised or tendered.
    /// </summary>
    [IsoId("_CfMJY-GaEd-1Ktb5rVaajw")]
    [DisplayName("Maximum Exercisable Quantity")]
    [IsoXmlTag("MaxExrcblQty")]
    public FinancialInstrumentQuantity1Choice_? MaximumExercisableQuantity { get; init; } 
    
    /// <summary>
    /// Minimum quantity (or lot) of financial instrument that must be exercised or tendered.
    /// </summary>
    [IsoId("_CfV6YeGaEd-1Ktb5rVaajw")]
    [DisplayName("Minimum Exercisable Quantity")]
    [IsoXmlTag("MinExrcblQty")]
    public FinancialInstrumentQuantity1Choice_? MinimumExercisableQuantity { get; init; } 
    
    /// <summary>
    /// Minimum multiple quantity (or lot) of financial instrument that must be exercised or tendered.
    /// </summary>
    [IsoId("_CfV6Y-GaEd-1Ktb5rVaajw")]
    [DisplayName("Minimum Exercisable Multiple Quantity")]
    [IsoXmlTag("MinExrcblMltplQty")]
    public FinancialInstrumentQuantity1Choice_? MinimumExercisableMultipleQuantity { get; init; } 
    
    /// <summary>
    /// Quantity of equity that makes up the new board lot.
    /// </summary>
    [IsoId("_CfV6ZeGaEd-1Ktb5rVaajw")]
    [DisplayName("New Board Lot Quantity")]
    [IsoXmlTag("NewBrdLotQty")]
    public FinancialInstrumentQuantity1Choice_? NewBoardLotQuantity { get; init; } 
    
    /// <summary>
    /// New denomination of the equity following, for example, an increase or decrease in nominal value.
    /// </summary>
    [IsoId("_CfV6Z-GaEd-1Ktb5rVaajw")]
    [DisplayName("New Denomination Quantity")]
    [IsoXmlTag("NewDnmtnQty")]
    public FinancialInstrumentQuantity1Choice_? NewDenominationQuantity { get; init; } 
    
    /// <summary>
    /// Specifies that if an order is prorated holders of odd lots who tender their full position will not have tendered position prorated but rather accepted in full.
    /// </summary>
    [IsoId("_CfV6aeGaEd-1Ktb5rVaajw")]
    [DisplayName("Front End Odd Lot Quantity")]
    [IsoXmlTag("FrntEndOddLotQty")]
    public FinancialInstrumentQuantity16Choice_? FrontEndOddLotQuantity { get; init; } 
    
    /// <summary>
    /// Represents the presence of a back end odd lot provision and the quantity of equity required after proration to be eligible for this privilege.
    /// </summary>
    [IsoId("_CfV6a-GaEd-1Ktb5rVaajw")]
    [DisplayName("Back End Odd Lot Quantity")]
    [IsoXmlTag("BckEndOddLotQty")]
    public FinancialInstrumentQuantity16Choice_? BackEndOddLotQuantity { get; init; } 
    
    
    #nullable disable
    
}
