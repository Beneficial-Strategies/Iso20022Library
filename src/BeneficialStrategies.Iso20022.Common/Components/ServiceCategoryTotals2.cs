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
/// Specifies totals related to the invoice.
/// </summary>
[IsoId("_mQH0X-F6EeWCAvUNsZ5u6g")]
[DisplayName("Service Category Totals")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ServiceCategoryTotals2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ServiceCategoryTotals2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ServiceCategoryTotals2( ActiveCurrencyAndAmount reqTotalInvoiceAmount,System.String reqServiceCategory )
    {
        TotalInvoiceAmount = reqTotalInvoiceAmount;
        ServiceCategory = reqServiceCategory;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique identification of an securities account or cash account belonging to billed customer.
    /// </summary>
    [IsoId("_ma_AgeF6EeWCAvUNsZ5u6g")]
    [DisplayName("Account Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctId")]
    #endif
    [IsoXmlTag("AcctId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AccountIdentification38Choice_? AccountIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AccountIdentification38Choice_? AccountIdentification { get; init; } 
    #else
    public AccountIdentification38Choice_? AccountIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// BIC of the party which is invoiced by the CSD/NCB.
    /// </summary>
    [IsoId("_ma_Ag-F6EeWCAvUNsZ5u6g")]
    [DisplayName("Billed Customer Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BlldCstmrId")]
    #endif
    [IsoXmlTag("BlldCstmrId")]
    [IsoSimpleType(IsoSimpleType.BICFIIdentifier)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoBICFIIdentifier? BilledCustomerIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? BilledCustomerIdentification { get; init; } 
    #else
    public System.String? BilledCustomerIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Total amount subject to tax.
    /// </summary>
    [IsoId("_ma_AheF6EeWCAvUNsZ5u6g")]
    [DisplayName("Total Taxable Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlTaxblAmt")]
    #endif
    [IsoXmlTag("TtlTaxblAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? TotalTaxableAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? TotalTaxableAmount { get; init; } 
    #else
    public ActiveCurrencyAndAmount? TotalTaxableAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Sum of all tax amounts related to the invoice.
    /// </summary>
    [IsoId("_ma_Ah-F6EeWCAvUNsZ5u6g")]
    [DisplayName("Total Tax Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlTaxAmt")]
    #endif
    [IsoXmlTag("TtlTaxAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? TotalTaxAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? TotalTaxAmount { get; init; } 
    #else
    public ActiveCurrencyAndAmount? TotalTaxAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Total amount of the invoice, being the sum of total invoice lines amounts, total invoice adjustment amount (discounts, allowances and charges) and total tax amounts.
    /// </summary>
    [IsoId("_ma_AieF6EeWCAvUNsZ5u6g")]
    [DisplayName("Total Invoice Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlInvcAmt")]
    #endif
    [IsoXmlTag("TtlInvcAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActiveCurrencyAndAmount TotalInvoiceAmount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ActiveCurrencyAndAmount TotalInvoiceAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount TotalInvoiceAmount { get; init; } 
    #else
    public ActiveCurrencyAndAmount TotalInvoiceAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Agreement under which or rules under which the transaction should be processed.
    /// </summary>
    [IsoId("_ma_Ai-F6EeWCAvUNsZ5u6g")]
    [DisplayName("Service Category")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SvcCtgy")]
    #endif
    [IsoXmlTag("SvcCtgy")]
    [IsoSimpleType(IsoSimpleType.Max4AlphaNumericText)]
    [StringLength(maximumLength: 4 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax4AlphaNumericText ServiceCategory { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String ServiceCategory { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String ServiceCategory { get; init; } 
    #else
    public System.String ServiceCategory { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies totals related to the invoice.
    /// </summary>
    [IsoId("_ma_AjeF6EeWCAvUNsZ5u6g")]
    [DisplayName("Service Item Totals")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SvcItmTtls")]
    #endif
    [IsoXmlTag("SvcItmTtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ServiceItemTotals1? ServiceItemTotals { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ServiceItemTotals1? ServiceItemTotals { get; init; } 
    #else
    public ServiceItemTotals1? ServiceItemTotals { get; set; } 
    #endif
    
    
    #nullable disable
    
}
