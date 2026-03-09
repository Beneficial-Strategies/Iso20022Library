// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the security option of a corporate event.
/// </summary>
[IsoId("_CfMJYeGaEd-1Ktb5rVaajw")]
[DisplayName("Securities Option")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SecuritiesOption15
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Maximum quantity (or lot) of financial instrument that must be exercised or tendered.
    /// </summary>
    [IsoId("_CfMJY-GaEd-1Ktb5rVaajw")]
    [DisplayName("Maximum Exercisable Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MaxExrcblQty")]
    #endif
    [IsoXmlTag("MaxExrcblQty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentQuantity1Choice_? MaximumExercisableQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity1Choice_? MaximumExercisableQuantity { get; init; } 
    #else
    public FinancialInstrumentQuantity1Choice_? MaximumExercisableQuantity { get; set; } 
    #endif
    
    /// <summary>
    /// Minimum quantity (or lot) of financial instrument that must be exercised or tendered.
    /// </summary>
    [IsoId("_CfV6YeGaEd-1Ktb5rVaajw")]
    [DisplayName("Minimum Exercisable Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MinExrcblQty")]
    #endif
    [IsoXmlTag("MinExrcblQty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentQuantity1Choice_? MinimumExercisableQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity1Choice_? MinimumExercisableQuantity { get; init; } 
    #else
    public FinancialInstrumentQuantity1Choice_? MinimumExercisableQuantity { get; set; } 
    #endif
    
    /// <summary>
    /// Minimum multiple quantity (or lot) of financial instrument that must be exercised or tendered.
    /// </summary>
    [IsoId("_CfV6Y-GaEd-1Ktb5rVaajw")]
    [DisplayName("Minimum Exercisable Multiple Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MinExrcblMltplQty")]
    #endif
    [IsoXmlTag("MinExrcblMltplQty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentQuantity1Choice_? MinimumExercisableMultipleQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity1Choice_? MinimumExercisableMultipleQuantity { get; init; } 
    #else
    public FinancialInstrumentQuantity1Choice_? MinimumExercisableMultipleQuantity { get; set; } 
    #endif
    
    /// <summary>
    /// Quantity of equity that makes up the new board lot.
    /// </summary>
    [IsoId("_CfV6ZeGaEd-1Ktb5rVaajw")]
    [DisplayName("New Board Lot Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NewBrdLotQty")]
    #endif
    [IsoXmlTag("NewBrdLotQty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentQuantity1Choice_? NewBoardLotQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity1Choice_? NewBoardLotQuantity { get; init; } 
    #else
    public FinancialInstrumentQuantity1Choice_? NewBoardLotQuantity { get; set; } 
    #endif
    
    /// <summary>
    /// New denomination of the equity following, for example, an increase or decrease in nominal value.
    /// </summary>
    [IsoId("_CfV6Z-GaEd-1Ktb5rVaajw")]
    [DisplayName("New Denomination Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NewDnmtnQty")]
    #endif
    [IsoXmlTag("NewDnmtnQty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentQuantity1Choice_? NewDenominationQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity1Choice_? NewDenominationQuantity { get; init; } 
    #else
    public FinancialInstrumentQuantity1Choice_? NewDenominationQuantity { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies that if an order is prorated holders of odd lots who tender their full position will not have tendered position prorated but rather accepted in full.
    /// </summary>
    [IsoId("_CfV6aeGaEd-1Ktb5rVaajw")]
    [DisplayName("Front End Odd Lot Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FrntEndOddLotQty")]
    #endif
    [IsoXmlTag("FrntEndOddLotQty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentQuantity16Choice_? FrontEndOddLotQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity16Choice_? FrontEndOddLotQuantity { get; init; } 
    #else
    public FinancialInstrumentQuantity16Choice_? FrontEndOddLotQuantity { get; set; } 
    #endif
    
    /// <summary>
    /// Represents the presence of a back end odd lot provision and the quantity of equity required after proration to be eligible for this privilege.
    /// </summary>
    [IsoId("_CfV6a-GaEd-1Ktb5rVaajw")]
    [DisplayName("Back End Odd Lot Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BckEndOddLotQty")]
    #endif
    [IsoXmlTag("BckEndOddLotQty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentQuantity16Choice_? BackEndOddLotQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity16Choice_? BackEndOddLotQuantity { get; init; } 
    #else
    public FinancialInstrumentQuantity16Choice_? BackEndOddLotQuantity { get; set; } 
    #endif
    
    
    #nullable disable
    
}
