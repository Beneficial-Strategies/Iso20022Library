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
/// Trade settlement monetary summation specified for this supply chain trade settlement.
/// </summary>
[IsoId("_SucoHAEcEeCQm6a_G2yO_w_1990739481")]
[DisplayName("Line Item Monetary Summation")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record LineItemMonetarySummation1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Monetary value of the line amount total being reported in this trade settlement monetary summation.
    /// </summary>
    [IsoId("_SucoHQEcEeCQm6a_G2yO_w_203579898")]
    [DisplayName("Line Total Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LineTtlAmt")]
    #endif
    [IsoXmlTag("LineTtlAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CurrencyAndAmount? LineTotalAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CurrencyAndAmount? LineTotalAmount { get; init; } 
    #else
    public CurrencyAndAmount? LineTotalAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Monetary value of the total of all allowance amounts being reported in this line item monetary summation.
    /// </summary>
    [IsoId("_SucoHgEcEeCQm6a_G2yO_w_-156792154")]
    [DisplayName("Allowance Total Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AllwncTtlAmt")]
    #endif
    [IsoXmlTag("AllwncTtlAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CurrencyAndAmount? AllowanceTotalAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CurrencyAndAmount? AllowanceTotalAmount { get; init; } 
    #else
    public CurrencyAndAmount? AllowanceTotalAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Monetary value of the total of all charge amounts being reported in this line item monetary summation.
    /// </summary>
    [IsoId("_SucoHwEcEeCQm6a_G2yO_w_197422641")]
    [DisplayName("Charge Total Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ChrgTtlAmt")]
    #endif
    [IsoXmlTag("ChrgTtlAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CurrencyAndAmount? ChargeTotalAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CurrencyAndAmount? ChargeTotalAmount { get; init; } 
    #else
    public CurrencyAndAmount? ChargeTotalAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Monetary value of the total of all tax amounts being reported in this line item monetary summation.
    /// </summary>
    [IsoId("_SucoIAEcEeCQm6a_G2yO_w_1261442565")]
    [DisplayName("Tax Total Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TaxTtlAmt")]
    #endif
    [IsoXmlTag("TaxTtlAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CurrencyAndAmount? TaxTotalAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CurrencyAndAmount? TaxTotalAmount { get; init; } 
    #else
    public CurrencyAndAmount? TaxTotalAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Monetary value of the total of all tax basis amounts being reported in this line item monetary summation.
    /// </summary>
    [IsoId("_SumZEAEcEeCQm6a_G2yO_w_-860871799")]
    [DisplayName("Tax Basis Total Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TaxBsisTtlAmt")]
    #endif
    [IsoXmlTag("TaxBsisTtlAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CurrencyAndAmount? TaxBasisTotalAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CurrencyAndAmount? TaxBasisTotalAmount { get; init; } 
    #else
    public CurrencyAndAmount? TaxBasisTotalAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Monetary value of an amount being reported for information in this line item monetary summation.
    /// </summary>
    [IsoId("_SumZEQEcEeCQm6a_G2yO_w_1109201490")]
    [DisplayName("Information Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InfAmt")]
    #endif
    [IsoXmlTag("InfAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CurrencyAndAmount? InformationAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CurrencyAndAmount? InformationAmount { get; init; } 
    #else
    public CurrencyAndAmount? InformationAmount { get; set; } 
    #endif
    
    
    #nullable disable
    
}
