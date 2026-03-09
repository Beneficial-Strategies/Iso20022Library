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
[IsoId("_eJ9o3mliEeGaMcKyqKNRfQ_-773420460")]
[DisplayName("Invoice Totals")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record InvoiceTotals2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a InvoiceTotals2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public InvoiceTotals2( ActiveCurrencyAndAmount reqTotalInvoiceAmount,System.DateOnly reqPaymentDueDate )
    {
        TotalInvoiceAmount = reqTotalInvoiceAmount;
        PaymentDueDate = reqPaymentDueDate;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Total amount subject to tax.
    /// </summary>
    [IsoId("_eJ9o32liEeGaMcKyqKNRfQ_-773420429")]
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
    [IsoId("_eJ9o4GliEeGaMcKyqKNRfQ_-773420428")]
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
    /// Variance on invoice amount taking into account discounts, allowances and charges.
    /// </summary>
    [IsoId("_eJ9o4WliEeGaMcKyqKNRfQ_2076378677")]
    [DisplayName("Adjustment")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Adjstmnt")]
    #endif
    [IsoXmlTag("Adjstmnt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Adjustment5? Adjustment { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Adjustment5? Adjustment { get; init; } 
    #else
    public Adjustment5? Adjustment { get; set; } 
    #endif
    
    /// <summary>
    /// Total amount of the invoice, being the sum of total invoice lines amounts, total invoice adjustment amount (discounts, allowances and charges) and total tax amounts.
    /// </summary>
    [IsoId("_eJ9o4mliEeGaMcKyqKNRfQ_-773420399")]
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
    /// Due date for the payment of the invoice.
    /// </summary>
    [IsoId("_eJ9o42liEeGaMcKyqKNRfQ_-773420121")]
    [DisplayName("Payment Due Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PmtDueDt")]
    #endif
    [IsoXmlTag("PmtDueDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODate PaymentDueDate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.DateOnly PaymentDueDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly PaymentDueDate { get; init; } 
    #else
    public System.DateOnly PaymentDueDate { get; set; } 
    #endif
    
    
    #nullable disable
    
}
