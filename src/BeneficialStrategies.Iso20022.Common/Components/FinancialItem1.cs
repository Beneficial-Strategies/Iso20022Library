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
/// Specifies information about a financing relation between two parties represented by a document, for example invoice, credit.
/// The component may include an external document describing details of the underlying trade object using an external schema.
/// </summary>
[IsoId("_OTgzMzMy-AOSNFX-8224500")]
[DisplayName("Financial Item")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record FinancialItem1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a FinancialItem1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public FinancialItem1( FinancialItemParameters1 reqItemContext,CreditDebitCode reqCreditDebitIndicator,InvoiceTotals1 reqTotalAmount )
    {
        ItemContext = reqItemContext;
        CreditDebitIndicator = reqCreditDebitIndicator;
        TotalAmount = reqTotalAmount;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Parameters identifying the context of the item.
    /// </summary>
    [IsoId("_OTgzMzk3-AOSNFX-8224503")]
    [DisplayName("Item Context")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ItmCntxt")]
    #endif
    [IsoXmlTag("ItmCntxt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required FinancialItemParameters1 ItemContext { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required FinancialItemParameters1 ItemContext { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialItemParameters1 ItemContext { get; init; } 
    #else
    public FinancialItemParameters1 ItemContext { get; set; } 
    #endif
    
    /// <summary>
    /// Identifier of financial document that is the base document for this item, for example an invoice number.
    /// </summary>
    [IsoId("_OTgzMzk4-AOSNFX-8224503")]
    [DisplayName("Financial Document Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FinDocRef")]
    #endif
    [IsoXmlTag("FinDocRef")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public QualifiedDocumentInformation1? FinancialDocumentReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public QualifiedDocumentInformation1? FinancialDocumentReference { get; init; } 
    #else
    public QualifiedDocumentInformation1? FinancialDocumentReference { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the value is a debit or credit.
    /// </summary>
    [IsoId("_OTgzMzk5-AOSNFX-8224503")]
    [DisplayName("Credit Debit Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CdtDbtInd")]
    #endif
    [IsoXmlTag("CdtDbtInd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CreditDebitCode CreditDebitIndicator { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CreditDebitCode CreditDebitIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CreditDebitCode CreditDebitIndicator { get; init; } 
    #else
    public CreditDebitCode CreditDebitIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the total amount related to the financial document.
    /// </summary>
    [IsoId("_OTgzNDAw-AOSNFX-8224503")]
    [DisplayName("Total Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlAmt")]
    #endif
    [IsoXmlTag("TtlAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required InvoiceTotals1 TotalAmount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required InvoiceTotals1 TotalAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InvoiceTotals1 TotalAmount { get; init; } 
    #else
    public InvoiceTotals1 TotalAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the remaining monetary amount.
    /// </summary>
    [IsoId("_OTgzNDAx-AOSNFX-8224503")]
    [DisplayName("Due Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DueAmt")]
    #endif
    [IsoXmlTag("DueAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? DueAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? DueAmount { get; init; } 
    #else
    public ActiveCurrencyAndAmount? DueAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Instalment information for payment.
    /// </summary>
    [IsoId("_OTgzNDAy-AOSNFX-8224503")]
    [DisplayName("Instalment Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InstlmtInf")]
    #endif
    [IsoXmlTag("InstlmtInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Instalment2? InstalmentInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Instalment2? InstalmentInformation { get; init; } 
    #else
    public Instalment2? InstalmentInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Additional proprietary textual information concerning the item.
    /// </summary>
    [IsoId("_OTgzNDA1-AOSNFX-8224503")]
    [DisplayName("Additional Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlInf")]
    #endif
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max2000Text)]
    [StringLength(maximumLength: 2000 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax2000Text? AdditionalInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AdditionalInformation { get; init; } 
    #else
    public System.String? AdditionalInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Associated free form document, for example a delivery confirmation.
    /// </summary>
    [IsoId("_OTgzNDA2-AOSNFX-8224503")]
    [DisplayName("Associated Document")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AssoctdDoc")]
    #endif
    [IsoXmlTag("AssoctdDoc")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public QualifiedDocumentInformation1? AssociatedDocument { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public QualifiedDocumentInformation1? AssociatedDocument { get; init; } 
    #else
    public QualifiedDocumentInformation1? AssociatedDocument { get; set; } 
    #endif
    
    /// <summary>
    /// Validation status of the item.
    /// </summary>
    [IsoId("_OTgzNDA3-AOSNFX-8224503")]
    [DisplayName("Validation Status Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="VldtnStsInf")]
    #endif
    [IsoXmlTag("VldtnStsInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ValidationStatusInformation1? ValidationStatusInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ValidationStatusInformation1? ValidationStatusInformation { get; init; } 
    #else
    public ValidationStatusInformation1? ValidationStatusInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Financing status if applicable for the item.
    /// </summary>
    [IsoId("_OTgzNDA4-AOSNFX-8224503")]
    [DisplayName("Financing Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FincgSts")]
    #endif
    [IsoXmlTag("FincgSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancingInformationAndStatus1? FinancingStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancingInformationAndStatus1? FinancingStatus { get; init; } 
    #else
    public FinancingInformationAndStatus1? FinancingStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Structured proprietary information concerning details of the financial item.
    /// </summary>
    [IsoId("_OTgzNDA0-AOSNFX-8224503")]
    [DisplayName("Proprietary Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrtryDtls")]
    #endif
    [IsoXmlTag("PrtryDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SupplementaryData1? ProprietaryDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SupplementaryData1? ProprietaryDetails { get; init; } 
    #else
    public SupplementaryData1? ProprietaryDetails { get; set; } 
    #endif
    
    
    #nullable disable
    
}
