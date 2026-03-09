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
/// Settlement of the securities in a securities transaction, that is, the instruction to deliver or receive securities, involving the payment of an amount of money or not.
/// </summary>
[IsoId("_dqcAheLxEeWOD7aAy2fAcA")]
[DisplayName("Settlement Information")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SettlementInformation17
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Choice between formats for the quantity of security.
    /// </summary>
    [IsoId("_dzhEAeLxEeWOD7aAy2fAcA")]
    [DisplayName("Securities Quantity Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctiesQtyTp")]
    #endif
    [IsoXmlTag("SctiesQtyTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SettlementUnitType3Choice_? SecuritiesQuantityType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementUnitType3Choice_? SecuritiesQuantityType { get; init; } 
    #else
    public SettlementUnitType3Choice_? SecuritiesQuantityType { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies when the contract (i.e. MBS/TBA) will settle.
    /// </summary>
    [IsoId("_dzhEA-LxEeWOD7aAy2fAcA")]
    [DisplayName("Contract Settlement Month")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtrctSttlmMnth")]
    #endif
    [IsoXmlTag("CtrctSttlmMnth")]
    [IsoSimpleType(IsoSimpleType.ISOYearMonth)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISOYearMonth? ContractSettlementMonth { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt16? ContractSettlementMonth { get; init; } 
    #else
    public System.UInt16? ContractSettlementMonth { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the minimum quantity (unit or nominal) of a security.
    /// </summary>
    [IsoId("_dzhEC-LxEeWOD7aAy2fAcA")]
    [DisplayName("Minimum Denomination")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MinDnmtn")]
    #endif
    [IsoXmlTag("MinDnmtn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentQuantity1Choice_? MinimumDenomination { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity1Choice_? MinimumDenomination { get; init; } 
    #else
    public FinancialInstrumentQuantity1Choice_? MinimumDenomination { get; set; } 
    #endif
    
    /// <summary>
    /// Minimum multiple quantity (unit or nominal) of securities.
    /// </summary>
    [IsoId("_dzhEDeLxEeWOD7aAy2fAcA")]
    [DisplayName("Minimum Multiple Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MinMltplQty")]
    #endif
    [IsoXmlTag("MinMltplQty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentQuantity1Choice_? MinimumMultipleQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity1Choice_? MinimumMultipleQuantity { get; init; } 
    #else
    public FinancialInstrumentQuantity1Choice_? MinimumMultipleQuantity { get; set; } 
    #endif
    
    /// <summary>
    /// Minimum quantity of securities that can be purchased without incurring a larger fee. For example, if the round lot size is 100 and the trade is for 125 shares, then 100 will be processed without a fee and the remaining 25 will incur a service fee for being an odd lot size.
    /// </summary>
    [IsoId("_dzhED-LxEeWOD7aAy2fAcA")]
    [DisplayName("Deviating Settlement Unit")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DevtgSttlmUnit")]
    #endif
    [IsoXmlTag("DevtgSttlmUnit")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentQuantity1Choice_? DeviatingSettlementUnit { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity1Choice_? DeviatingSettlementUnit { get; init; } 
    #else
    public FinancialInstrumentQuantity1Choice_? DeviatingSettlementUnit { get; set; } 
    #endif
    
    
    #nullable disable
    
}
