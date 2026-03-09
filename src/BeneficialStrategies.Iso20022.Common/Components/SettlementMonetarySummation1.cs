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
/// Specifies a collection of monetary totals for this settlement.
/// </summary>
[IsoId("_S-ZInQEcEeCQm6a_G2yO_w_-2077201907")]
[DisplayName("Settlement Monetary Summation")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SettlementMonetarySummation1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Monetary value of the line amount total being reported for this settlement.
    /// </summary>
    [IsoId("_S-ZIngEcEeCQm6a_G2yO_w_-1438063154")]
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
    /// Monetary value of the allowance total being reported for this settlement.
    /// </summary>
    [IsoId("_S-i5kAEcEeCQm6a_G2yO_w_-1976793835")]
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
    /// Monetary value of the total discount being reported for this settlement.
    /// </summary>
    [IsoId("_S-i5kQEcEeCQm6a_G2yO_w_427851198")]
    [DisplayName("Total Discount Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlDscntAmt")]
    #endif
    [IsoXmlTag("TtlDscntAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CurrencyAndAmount? TotalDiscountAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CurrencyAndAmount? TotalDiscountAmount { get; init; } 
    #else
    public CurrencyAndAmount? TotalDiscountAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Monetary value of the charge amount total being reported for this settlement.
    /// </summary>
    [IsoId("_S-i5kgEcEeCQm6a_G2yO_w_1451423672")]
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
    /// Monetary value of the total prepaid amount being reported for this settlement.
    /// </summary>
    [IsoId("_S-i5kwEcEeCQm6a_G2yO_w_1675528526")]
    [DisplayName("Total Prepaid Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlPrepdAmt")]
    #endif
    [IsoXmlTag("TtlPrepdAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CurrencyAndAmount? TotalPrepaidAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CurrencyAndAmount? TotalPrepaidAmount { get; init; } 
    #else
    public CurrencyAndAmount? TotalPrepaidAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Monetary value of the total of all tax basis amounts being reported for this settlement.
    /// </summary>
    [IsoId("_S-i5lAEcEeCQm6a_G2yO_w_-1622081227")]
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
    /// Monetary value of the total of all tax basis amounts being reported for this settlement.
    /// </summary>
    [IsoId("_S-i5lQEcEeCQm6a_G2yO_w_1868239250")]
    [DisplayName("Tax Basis Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TaxBsisAmt")]
    #endif
    [IsoXmlTag("TaxBsisAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CurrencyAndAmount? TaxBasisAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CurrencyAndAmount? TaxBasisAmount { get; init; } 
    #else
    public CurrencyAndAmount? TaxBasisAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Monetary value of a rounding amount being applied and reported for this settlement.
    /// </summary>
    [IsoId("_S-i5lgEcEeCQm6a_G2yO_w_-575396775")]
    [DisplayName("Rounding Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RndgAmt")]
    #endif
    [IsoXmlTag("RndgAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CurrencyAndAmount? RoundingAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CurrencyAndAmount? RoundingAmount { get; init; } 
    #else
    public CurrencyAndAmount? RoundingAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Monetary value of the grand total being reported for this settlement, to include addition and subtraction of individual summation amounts.
    /// </summary>
    [IsoId("_S-i5lwEcEeCQm6a_G2yO_w_-444855441")]
    [DisplayName("Grand Total Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="GrdTtlAmt")]
    #endif
    [IsoXmlTag("GrdTtlAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CurrencyAndAmount? GrandTotalAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CurrencyAndAmount? GrandTotalAmount { get; init; } 
    #else
    public CurrencyAndAmount? GrandTotalAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Monetary value of an amount being reported as information for this settlement.
    /// </summary>
    [IsoId("_S-i5mAEcEeCQm6a_G2yO_w_310144010")]
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
