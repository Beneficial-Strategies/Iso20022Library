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
/// Details about the investment fund class.
/// </summary>
[IsoId("_m-vKpvNBEeCuA5Tr22BnwA_337995700")]
[DisplayName("Investment Fund")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record InvestmentFund1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the investment fund or investment fund class.
    /// </summary>
    [IsoId("_m-vKp_NBEeCuA5Tr22BnwA_-1318599223")]
    [DisplayName("Financial Instrument Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FinInstrmId")]
    #endif
    [IsoXmlTag("FinInstrmId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SecurityIdentification14? FinancialInstrumentIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecurityIdentification14? FinancialInstrumentIdentification { get; init; } 
    #else
    public SecurityIdentification14? FinancialInstrumentIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Features of units offered by a fund. For example, a unit may have a specific load structure, eg, front end or back end, an income policy, eg, pay out or accumulate, or a trailer policy, eg, with or without. Fund classes are typically denoted by a single character, for example, &apos;Class A&apos;, &apos;Class 2&apos;.
    /// </summary>
    [IsoId("_m-vKqPNBEeCuA5Tr22BnwA_693141038")]
    [DisplayName("Class Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClssTp")]
    #endif
    [IsoXmlTag("ClssTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? ClassType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ClassType { get; init; } 
    #else
    public System.String? ClassType { get; set; } 
    #endif
    
    /// <summary>
    /// Number of shares outstanding for the investment fund or investment fund share class.
    /// </summary>
    [IsoId("_m-vKqfNBEeCuA5Tr22BnwA_-744176110")]
    [DisplayName("Total Units Outstanding")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlUnitsOutsdng")]
    #endif
    [IsoXmlTag("TtlUnitsOutsdng")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoDecimalNumber? TotalUnitsOutstanding { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? TotalUnitsOutstanding { get; init; } 
    #else
    public System.UInt64? TotalUnitsOutstanding { get; set; } 
    #endif
    
    /// <summary>
    /// Total transactional units (subscriptions and redemptions) which are applied to the investment fund or investment fund share class for the report period.
    /// </summary>
    [IsoId("_m-47oPNBEeCuA5Tr22BnwA_1556646480")]
    [DisplayName("Transactional Units")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxnlUnits")]
    #endif
    [IsoXmlTag("TxnlUnits")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoDecimalNumber? TransactionalUnits { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? TransactionalUnits { get; init; } 
    #else
    public System.UInt64? TransactionalUnits { get; set; } 
    #endif
    
    /// <summary>
    /// Total value of the investment fund or investment fund share class units.
    /// </summary>
    [IsoId("_m-47ofNBEeCuA5Tr22BnwA_-2045687")]
    [DisplayName("Total Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlVal")]
    #endif
    [IsoXmlTag("TtlVal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection30? TotalValue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection30? TotalValue { get; init; } 
    #else
    public AmountAndDirection30? TotalValue { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money for which goods or services are offered, sold, or bought.
    /// </summary>
    [IsoId("_m-47ovNBEeCuA5Tr22BnwA_-574968216")]
    [DisplayName("Price")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Pric")]
    #endif
    [IsoXmlTag("Pric")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PriceInformation10? Price { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PriceInformation10? Price { get; init; } 
    #else
    public PriceInformation10? Price { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_m-47o_NBEeCuA5Tr22BnwA_-14332001")]
    [DisplayName("Supplementary Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SplmtryData")]
    #endif
    [IsoXmlTag("SplmtryData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SupplementaryData1? SupplementaryData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SupplementaryData1? SupplementaryData { get; init; } 
    #else
    public SupplementaryData1? SupplementaryData { get; set; } 
    #endif
    
    
    #nullable disable
    
}
