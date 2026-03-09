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
/// Specifies corporate action quantities.
/// </summary>
[IsoId("_p4XbMzi7Eeydid5dcNPKvg")]
[DisplayName("Corporate Action Quantity")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CorporateActionQuantity14
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// The maximum number of securities the offeror/issuer is ready to purchase or redeem. This can be a number or the term &quot;any and all&quot;.
    /// </summary>
    [IsoId("_p4XbOTi7Eeydid5dcNPKvg")]
    [DisplayName("Maximum Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MaxQty")]
    #endif
    [IsoXmlTag("MaxQty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentQuantity44Choice_? MaximumQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity44Choice_? MaximumQuantity { get; init; } 
    #else
    public FinancialInstrumentQuantity44Choice_? MaximumQuantity { get; set; } 
    #endif
    
    /// <summary>
    /// Minimum quantity of securities the offeror/issuer is ready to purchase or redeem under the terms of the event. This can be a number or the term &quot;any and all&quot;.
    /// </summary>
    [IsoId("_p4XbQTi7Eeydid5dcNPKvg")]
    [DisplayName("Minimum Quantity Sought")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MinQtySght")]
    #endif
    [IsoXmlTag("MinQtySght")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentQuantity44Choice_? MinimumQuantitySought { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity44Choice_? MinimumQuantitySought { get; init; } 
    #else
    public FinancialInstrumentQuantity44Choice_? MinimumQuantitySought { get; set; } 
    #endif
    
    /// <summary>
    /// Quantity of equity that makes up the new board lot.
    /// </summary>
    [IsoId("_p4XbSTi7Eeydid5dcNPKvg")]
    [DisplayName("New Board Lot Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NewBrdLotQty")]
    #endif
    [IsoXmlTag("NewBrdLotQty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentQuantity43Choice_? NewBoardLotQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity43Choice_? NewBoardLotQuantity { get; init; } 
    #else
    public FinancialInstrumentQuantity43Choice_? NewBoardLotQuantity { get; set; } 
    #endif
    
    /// <summary>
    /// New denomination of the equity following, for example, an increase or decrease in nominal value.
    /// </summary>
    [IsoId("_p4XbUTi7Eeydid5dcNPKvg")]
    [DisplayName("New Denomination Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NewDnmtnQty")]
    #endif
    [IsoXmlTag("NewDnmtnQty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentQuantity43Choice_? NewDenominationQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity43Choice_? NewDenominationQuantity { get; init; } 
    #else
    public FinancialInstrumentQuantity43Choice_? NewDenominationQuantity { get; set; } 
    #endif
    
    /// <summary>
    /// Minimum integral amount of securities that each account owner must have remaining after the called amounts are applied.
    /// </summary>
    [IsoId("_p4XbWTi7Eeydid5dcNPKvg")]
    [DisplayName("Base Denomination")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BaseDnmtn")]
    #endif
    [IsoXmlTag("BaseDnmtn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentQuantity43Choice_? BaseDenomination { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity43Choice_? BaseDenomination { get; init; } 
    #else
    public FinancialInstrumentQuantity43Choice_? BaseDenomination { get; set; } 
    #endif
    
    /// <summary>
    /// Amount used when the called amount is not met by running the lottery with the base denomination.
    /// </summary>
    [IsoId("_p4XbYTi7Eeydid5dcNPKvg")]
    [DisplayName("Incremental Denomination")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IncrmtlDnmtn")]
    #endif
    [IsoXmlTag("IncrmtlDnmtn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentQuantity43Choice_? IncrementalDenomination { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity43Choice_? IncrementalDenomination { get; init; } 
    #else
    public FinancialInstrumentQuantity43Choice_? IncrementalDenomination { get; set; } 
    #endif
    
    
    #nullable disable
    
}
