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
/// General information about the invoice contained in the original request.
/// </summary>
[IsoId("_ThfHwtp-Ed-ak6NoX_4Aeg_1135889353")]
[DisplayName("Original Invoice Information")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record OriginalInvoiceInformation1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a OriginalInvoiceInformation1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public OriginalInvoiceInformation1( System.String reqDocumentNumber,ActiveCurrencyAndAmount reqTotalInvoiceAmount,System.DateOnly reqIssueDate,System.DateOnly reqPaymentDueDate )
    {
        DocumentNumber = reqDocumentNumber;
        TotalInvoiceAmount = reqTotalInvoiceAmount;
        IssueDate = reqIssueDate;
        PaymentDueDate = reqPaymentDueDate;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique identifier of the document.
    /// </summary>
    [IsoId("_ThfHw9p-Ed-ak6NoX_4Aeg_-710957131")]
    [DisplayName("Document Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DocNb")]
    #endif
    [IsoXmlTag("DocNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text DocumentNumber { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String DocumentNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String DocumentNumber { get; init; } 
    #else
    public System.String DocumentNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Total amount of the invoice, being the sum of total invoice lines amounts, total invoice additional amounts (allowances and charges) and total tax amounts.
    /// </summary>
    [IsoId("_ThfHxNp-Ed-ak6NoX_4Aeg_-601981200")]
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
    /// Issue date of the document.
    /// </summary>
    [IsoId("_ThfHxdp-Ed-ak6NoX_4Aeg_-255658965")]
    [DisplayName("Issue Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IsseDt")]
    #endif
    [IsoXmlTag("IsseDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODate IssueDate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.DateOnly IssueDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly IssueDate { get; init; } 
    #else
    public System.DateOnly IssueDate { get; set; } 
    #endif
    
    /// <summary>
    /// Due date for the payment of the invoice.
    /// </summary>
    [IsoId("_ThfHxtp-Ed-ak6NoX_4Aeg_696882678")]
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
