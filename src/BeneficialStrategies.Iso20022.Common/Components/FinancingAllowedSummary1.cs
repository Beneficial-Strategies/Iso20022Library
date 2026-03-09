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
/// Summary information about amount financed.
/// </summary>
[IsoId("_Th7zwdp-Ed-ak6NoX_4Aeg_-1462438308")]
[DisplayName("Financing Allowed Summary")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record FinancingAllowedSummary1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a FinancingAllowedSummary1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public FinancingAllowedSummary1( System.UInt64 reqFinancedItemNumber,ActiveCurrencyAndAmount reqTotalAcceptedItemsAmount,ActiveCurrencyAndAmount reqTotalFinancedAmount )
    {
        FinancedItemNumber = reqFinancedItemNumber;
        TotalAcceptedItemsAmount = reqTotalAcceptedItemsAmount;
        TotalFinancedAmount = reqTotalFinancedAmount;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Number of invoices/instalments financed.
    /// </summary>
    [IsoId("_Th7zwtp-Ed-ak6NoX_4Aeg_-1027457607")]
    [DisplayName("Financed Item Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FincdItmNb")]
    #endif
    [IsoXmlTag("FincdItmNb")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoNumber FinancedItemNumber { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.UInt64 FinancedItemNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64 FinancedItemNumber { get; init; } 
    #else
    public System.UInt64 FinancedItemNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Sum of the original total amounts of the invoices accepted for financing.
    /// </summary>
    [IsoId("_Th7zw9p-Ed-ak6NoX_4Aeg_-525987159")]
    [DisplayName("Total Accepted Items Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlAccptdItmsAmt")]
    #endif
    [IsoXmlTag("TtlAccptdItmsAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActiveCurrencyAndAmount TotalAcceptedItemsAmount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ActiveCurrencyAndAmount TotalAcceptedItemsAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount TotalAcceptedItemsAmount { get; init; } 
    #else
    public ActiveCurrencyAndAmount TotalAcceptedItemsAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Percentage rate applied to calculate the total amount financed related to the total amounts of the invoices accepted for financing. It represents the average percentage rate applied to all single invoice requests financed. It can be calculated as result of &quot;TotalFinancedAmount&quot; divided by &quot;TotalAcceptedItemsAmount&quot;.
    /// </summary>
    [IsoId("_TiFksNp-Ed-ak6NoX_4Aeg_2267645")]
    [DisplayName("Applied Percentage")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ApldPctg")]
    #endif
    [IsoXmlTag("ApldPctg")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPercentageRate? AppliedPercentage { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? AppliedPercentage { get; init; } 
    #else
    public System.Decimal? AppliedPercentage { get; set; } 
    #endif
    
    /// <summary>
    /// Total amount financed, defined as the entire financed amount of the requests.
    /// </summary>
    [IsoId("_TiFksdp-Ed-ak6NoX_4Aeg_319034603")]
    [DisplayName("Total Financed Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlFincdAmt")]
    #endif
    [IsoXmlTag("TtlFincdAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActiveCurrencyAndAmount TotalFinancedAmount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ActiveCurrencyAndAmount TotalFinancedAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount TotalFinancedAmount { get; init; } 
    #else
    public ActiveCurrencyAndAmount TotalFinancedAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Set of dates (eg book date, credit date) related to the crediting of the financed amount.
    /// </summary>
    [IsoId("_TiFkstp-Ed-ak6NoX_4Aeg_-1526604541")]
    [DisplayName("Financing Date Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FincgDtDtls")]
    #endif
    [IsoXmlTag("FincgDtDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancingDateDetails1? FinancingDateDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancingDateDetails1? FinancingDateDetails { get; init; } 
    #else
    public FinancingDateDetails1? FinancingDateDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Unambiguous identification of the account, held by Financing Requestor, actually used for crediting the amount financed.
    /// </summary>
    [IsoId("_TiFks9p-Ed-ak6NoX_4Aeg_-434448310")]
    [DisplayName("Credit Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CdtAcct")]
    #endif
    [IsoXmlTag("CdtAcct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashAccount7? CreditAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashAccount7? CreditAccount { get; init; } 
    #else
    public CashAccount7? CreditAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Unambiguous identification of the internal bank account actually used by First Agent to manage the line of credit granted to Financing Requestor.
    /// </summary>
    [IsoId("_TiFktNp-Ed-ak6NoX_4Aeg_-1667612693")]
    [DisplayName("Financing Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FincgAcct")]
    #endif
    [IsoXmlTag("FincgAcct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashAccount7? FinancingAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashAccount7? FinancingAccount { get; init; } 
    #else
    public CashAccount7? FinancingAccount { get; set; } 
    #endif
    
    
    #nullable disable
    
}
