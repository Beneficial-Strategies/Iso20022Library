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
[IsoId("_m2kq4UEJEeWVgfuHGaKtRQ")]
[DisplayName("Securities Option")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SecuritiesOption51
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Maximum quantity of financial instrument that may be instructed.
    /// </summary>
    [IsoId("_nDqrtUEJEeWVgfuHGaKtRQ")]
    [DisplayName("Maximum Quantity To Instruct")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MaxQtyToInst")]
    #endif
    [IsoXmlTag("MaxQtyToInst")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentQuantity19Choice_? MaximumQuantityToInstruct { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity19Choice_? MaximumQuantityToInstruct { get; init; } 
    #else
    public FinancialInstrumentQuantity19Choice_? MaximumQuantityToInstruct { get; set; } 
    #endif
    
    /// <summary>
    /// Minimum quantity of financial instrument that may be instructed.
    /// </summary>
    [IsoId("_nDqrvUEJEeWVgfuHGaKtRQ")]
    [DisplayName("Minimum Quantity To Instruct")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MinQtyToInst")]
    #endif
    [IsoXmlTag("MinQtyToInst")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentQuantity19Choice_? MinimumQuantityToInstruct { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity19Choice_? MinimumQuantityToInstruct { get; init; } 
    #else
    public FinancialInstrumentQuantity19Choice_? MinimumQuantityToInstruct { get; set; } 
    #endif
    
    /// <summary>
    /// Minimum multiple quantity of financial instrument that may be instructed.
    /// </summary>
    [IsoId("_nDqrxUEJEeWVgfuHGaKtRQ")]
    [DisplayName("Minimum Multiple Quantity To Instruct")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MinMltplQtyToInst")]
    #endif
    [IsoXmlTag("MinMltplQtyToInst")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentQuantity20Choice_? MinimumMultipleQuantityToInstruct { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity20Choice_? MinimumMultipleQuantityToInstruct { get; init; } 
    #else
    public FinancialInstrumentQuantity20Choice_? MinimumMultipleQuantityToInstruct { get; set; } 
    #endif
    
    /// <summary>
    /// Quantity of equity that makes up the new board lot.
    /// </summary>
    [IsoId("_nDqrzUEJEeWVgfuHGaKtRQ")]
    [DisplayName("New Board Lot Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NewBrdLotQty")]
    #endif
    [IsoXmlTag("NewBrdLotQty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentQuantity20Choice_? NewBoardLotQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity20Choice_? NewBoardLotQuantity { get; init; } 
    #else
    public FinancialInstrumentQuantity20Choice_? NewBoardLotQuantity { get; set; } 
    #endif
    
    /// <summary>
    /// New denomination of the equity following, for example, an increase or decrease in nominal value.
    /// </summary>
    [IsoId("_nDqr1UEJEeWVgfuHGaKtRQ")]
    [DisplayName("New Denomination Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NewDnmtnQty")]
    #endif
    [IsoXmlTag("NewDnmtnQty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentQuantity20Choice_? NewDenominationQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity20Choice_? NewDenominationQuantity { get; init; } 
    #else
    public FinancialInstrumentQuantity20Choice_? NewDenominationQuantity { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies that if an order is prorated holders of odd lots who tender their full position will not have tendered position prorated but rather accepted in full.
    /// </summary>
    [IsoId("_nDqr3UEJEeWVgfuHGaKtRQ")]
    [DisplayName("Front End Odd Lot Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FrntEndOddLotQty")]
    #endif
    [IsoXmlTag("FrntEndOddLotQty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentQuantity20Choice_? FrontEndOddLotQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity20Choice_? FrontEndOddLotQuantity { get; init; } 
    #else
    public FinancialInstrumentQuantity20Choice_? FrontEndOddLotQuantity { get; set; } 
    #endif
    
    /// <summary>
    /// Represents the presence of a back end odd lot provision and the quantity of equity required after proration to be eligible for this privilege.
    /// </summary>
    [IsoId("_nDqr5UEJEeWVgfuHGaKtRQ")]
    [DisplayName("Back End Odd Lot Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BckEndOddLotQty")]
    #endif
    [IsoXmlTag("BckEndOddLotQty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentQuantity20Choice_? BackEndOddLotQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity20Choice_? BackEndOddLotQuantity { get; init; } 
    #else
    public FinancialInstrumentQuantity20Choice_? BackEndOddLotQuantity { get; set; } 
    #endif
    
    
    #nullable disable
    
}
