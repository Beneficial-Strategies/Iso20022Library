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
/// Specifies the billing price of a service.
/// </summary>
[IsoId("_6TrGHJqlEeGSON8vddiWzQ_-1572616191")]
[DisplayName("Billing Price")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record BillingPrice1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Currency code in which the unit price and original charge price are expressed.
    /// </summary>
    [IsoId("_6T03EJqlEeGSON8vddiWzQ_-1686455257")]
    [DisplayName("Currency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Ccy")]
    #endif
    [IsoXmlTag("Ccy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveOrHistoricCurrencyCode? Currency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? Currency { get; init; } 
    #else
    public string? Currency { get; set; } 
    #endif
    
    /// <summary>
    /// Price per item or unit used to calculate the charge expressed in the pricing currency.
    /// </summary>
    [IsoId("_6T03EZqlEeGSON8vddiWzQ_1611439686")]
    [DisplayName("Unit Price")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UnitPric")]
    #endif
    [IsoXmlTag("UnitPric")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection34? UnitPrice { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection34? UnitPrice { get; init; } 
    #else
    public AmountAndDirection34? UnitPrice { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies how the charge was calculated. ||Usage: The absence of this code assumes that the charge is calculated as the product of (volume x unit price).
    /// </summary>
    [IsoId("_6T03EpqlEeGSON8vddiWzQ_1347426093")]
    [DisplayName("Method")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Mtd")]
    #endif
    [IsoXmlTag("Mtd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BillingChargeMethod1Code? Method { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BillingChargeMethod1Code? Method { get; init; } 
    #else
    public BillingChargeMethod1Code? Method { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates that the charge calculation is based on a particular rule. The rule name is carried here and is defined by the trading partners.
    /// </summary>
    [IsoId("_6T03E5qlEeGSON8vddiWzQ_-937813392")]
    [DisplayName("Rule")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Rule")]
    #endif
    [IsoXmlTag("Rule")]
    [IsoSimpleType(IsoSimpleType.Max20Text)]
    [StringLength(maximumLength: 20 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax20Text? Rule { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Rule { get; init; } 
    #else
    public System.String? Rule { get; set; } 
    #endif
    
    
    #nullable disable
    
}
