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
/// Set of characteristics that unambiguously identify the single invoice financing request.
/// </summary>
[IsoId("_RYGZZdp-Ed-ak6NoX_4Aeg_909721344")]
[DisplayName("Invoice Request Information")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record InvoiceRequestInformation1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a InvoiceRequestInformation1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public InvoiceRequestInformation1( DocumentGeneralInformation1 reqInvoiceGeneralInformation,InvoiceTotals1 reqInvoiceTotalsInformation,PartyAndAccountIdentificationAndContactInformation1 reqSupplier,PartyIdentificationAndContactInformation1 reqBuyer,PaymentInformation15 reqInvoicePaymentInformation )
    {
        InvoiceGeneralInformation = reqInvoiceGeneralInformation;
        InvoiceTotalsInformation = reqInvoiceTotalsInformation;
        Supplier = reqSupplier;
        Buyer = reqBuyer;
        InvoicePaymentInformation = reqInvoicePaymentInformation;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// General information that unambiguously identify the invoice to be financed, such as invoice type, invoice number and issue date.
    /// </summary>
    [IsoId("_RYGZZtp-Ed-ak6NoX_4Aeg_-885319739")]
    [DisplayName("Invoice General Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InvcGnlInf")]
    #endif
    [IsoXmlTag("InvcGnlInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DocumentGeneralInformation1 InvoiceGeneralInformation { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DocumentGeneralInformation1 InvoiceGeneralInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DocumentGeneralInformation1 InvoiceGeneralInformation { get; init; } 
    #else
    public DocumentGeneralInformation1 InvoiceGeneralInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies totals related to the invoice, such as total invoice amount and total tax amount.
    /// </summary>
    [IsoId("_RYGZZ9p-Ed-ak6NoX_4Aeg_88226197")]
    [DisplayName("Invoice Totals Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InvcTtlsInf")]
    #endif
    [IsoXmlTag("InvcTtlsInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required InvoiceTotals1 InvoiceTotalsInformation { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required InvoiceTotals1 InvoiceTotalsInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InvoiceTotals1 InvoiceTotalsInformation { get; init; } 
    #else
    public InvoiceTotals1 InvoiceTotalsInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of credit/debit note related to the invoice to be financed.
    /// </summary>
    [IsoId("_RYGZaNp-Ed-ak6NoX_4Aeg_-1188229274")]
    [DisplayName("Credit Debit Note Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CdtDbtNoteAmt")]
    #endif
    [IsoXmlTag("CdtDbtNoteAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? CreditDebitNoteAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? CreditDebitNoteAmount { get; init; } 
    #else
    public ActiveCurrencyAndAmount? CreditDebitNoteAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Details of a single instalment to be financed, related to an invoice settlement (amount, payment due date).
    /// </summary>
    [IsoId("_RYQKYNp-Ed-ak6NoX_4Aeg_-1603772146")]
    [DisplayName("Instalment Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InstlmtInf")]
    #endif
    [IsoXmlTag("InstlmtInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Instalment1? InstalmentInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Instalment1? InstalmentInformation { get; init; } 
    #else
    public Instalment1? InstalmentInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Amount requested by the requestor party, related to a single invoice to be financed.
    /// </summary>
    [IsoId("_RYQKYdp-Ed-ak6NoX_4Aeg_-1318025183")]
    [DisplayName("Requested Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ReqdAmt")]
    #endif
    [IsoXmlTag("ReqdAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancingRateOrAmountChoice_? RequestedAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancingRateOrAmountChoice_? RequestedAmount { get; init; } 
    #else
    public FinancingRateOrAmountChoice_? RequestedAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Person or organization that represents the creditor for the invoice to be financed.
    /// </summary>
    [IsoId("_RYQKYtp-Ed-ak6NoX_4Aeg_475463417")]
    [DisplayName("Supplier")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Spplr")]
    #endif
    [IsoXmlTag("Spplr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PartyAndAccountIdentificationAndContactInformation1 Supplier { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PartyAndAccountIdentificationAndContactInformation1 Supplier { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyAndAccountIdentificationAndContactInformation1 Supplier { get; init; } 
    #else
    public PartyAndAccountIdentificationAndContactInformation1 Supplier { get; set; } 
    #endif
    
    /// <summary>
    /// Person or organization that represents the debtor for the invoice to be financed.
    /// </summary>
    [IsoId("_RYQKY9p-Ed-ak6NoX_4Aeg_1975466452")]
    [DisplayName("Buyer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Buyr")]
    #endif
    [IsoXmlTag("Buyr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PartyIdentificationAndContactInformation1 Buyer { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PartyIdentificationAndContactInformation1 Buyer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentificationAndContactInformation1 Buyer { get; init; } 
    #else
    public PartyIdentificationAndContactInformation1 Buyer { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies payment terms and conditions related to a single invoice to be financed, including identifier of possible account used for payment.
    /// </summary>
    [IsoId("_RYQKZNp-Ed-ak6NoX_4Aeg_-1314868221")]
    [DisplayName("Invoice Payment Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InvcPmtInf")]
    #endif
    [IsoXmlTag("InvcPmtInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PaymentInformation15 InvoicePaymentInformation { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PaymentInformation15 InvoicePaymentInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PaymentInformation15 InvoicePaymentInformation { get; init; } 
    #else
    public PaymentInformation15 InvoicePaymentInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Information about a document related to the invoice to be financed, in structured form.
    /// </summary>
    [IsoId("_RYQKZdp-Ed-ak6NoX_4Aeg_497864820")]
    [DisplayName("Referred Document")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RfrdDoc")]
    #endif
    [IsoXmlTag("RfrdDoc")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ReferredDocumentInformation2? ReferredDocument { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ReferredDocumentInformation2? ReferredDocument { get; init; } 
    #else
    public ReferredDocumentInformation2? ReferredDocument { get; set; } 
    #endif
    
    
    #nullable disable
    
}
