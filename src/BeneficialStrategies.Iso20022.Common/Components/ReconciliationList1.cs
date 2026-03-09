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
/// Specifies a list of reconciliation information concerning financial items.
/// </summary>
[IsoId("_OTgzMTk5-AOSNFX-8224490")]
[DisplayName("Reconciliation List")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ReconciliationList1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ReconciliationList1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ReconciliationList1( System.DateOnly reqDate,QualifiedPartyIdentification1 reqRecipient,QualifiedPartyIdentification1 reqAdvisor,FinancialItemParameters1 reqParameters,PaymentIdentification1 reqPaymentReference,PaymentMeans1 reqPaymentMeans,System.DateOnly reqPaymentDate,PaymentTerms6 reqPaymentTerms,CurrencyAndAmount reqPaymentAmount,System.String reqItemCount )
    {
        Date = reqDate;
        Recipient = reqRecipient;
        Advisor = reqAdvisor;
        Parameters = reqParameters;
        PaymentReference = reqPaymentReference;
        PaymentMeans = reqPaymentMeans;
        PaymentDate = reqPaymentDate;
        PaymentTerms = reqPaymentTerms;
        PaymentAmount = reqPaymentAmount;
        ItemCount = reqItemCount;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Date of creation of this document.
    /// </summary>
    [IsoId("_OTgzNDE5-AOSNFX-8224504")]
    [DisplayName("Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Dt")]
    #endif
    [IsoXmlTag("Dt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODate Date { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.DateOnly Date { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly Date { get; init; } 
    #else
    public System.DateOnly Date { get; set; } 
    #endif
    
    /// <summary>
    /// Reference to related documents for example to original assignment in a status response or retry.
    /// </summary>
    [IsoId("_OTgzNDIw-AOSNFX-8224504")]
    [DisplayName("Related Document")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RltdDoc")]
    #endif
    [IsoXmlTag("RltdDoc")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public QualifiedDocumentInformation1? RelatedDocument { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public QualifiedDocumentInformation1? RelatedDocument { get; init; } 
    #else
    public QualifiedDocumentInformation1? RelatedDocument { get; set; } 
    #endif
    
    /// <summary>
    /// Party to be advised.
    /// </summary>
    [IsoId("_OTgzNDIx-AOSNFX-8224504")]
    [DisplayName("Recipient")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Rcpt")]
    #endif
    [IsoXmlTag("Rcpt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required QualifiedPartyIdentification1 Recipient { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required QualifiedPartyIdentification1 Recipient { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public QualifiedPartyIdentification1 Recipient { get; init; } 
    #else
    public QualifiedPartyIdentification1 Recipient { get; set; } 
    #endif
    
    /// <summary>
    /// Informing party.
    /// </summary>
    [IsoId("_OTgzNDIy-AOSNFX-8224504")]
    [DisplayName("Advisor")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Advsr")]
    #endif
    [IsoXmlTag("Advsr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required QualifiedPartyIdentification1 Advisor { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required QualifiedPartyIdentification1 Advisor { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public QualifiedPartyIdentification1 Advisor { get; init; } 
    #else
    public QualifiedPartyIdentification1 Advisor { get; set; } 
    #endif
    
    /// <summary>
    /// Identification parameters.
    /// </summary>
    [IsoId("_OTgzNDIz-AOSNFX-8224504")]
    [DisplayName("Parameters")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Params")]
    #endif
    [IsoXmlTag("Params")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required FinancialItemParameters1 Parameters { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required FinancialItemParameters1 Parameters { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialItemParameters1 Parameters { get; init; } 
    #else
    public FinancialItemParameters1 Parameters { get; set; } 
    #endif
    
    /// <summary>
    /// Reference to a payment instruction.
    /// </summary>
    [IsoId("_OTgzNDI0-AOSNFX-8224504")]
    [DisplayName("Payment Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PmtRef")]
    #endif
    [IsoXmlTag("PmtRef")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PaymentIdentification1 PaymentReference { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PaymentIdentification1 PaymentReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PaymentIdentification1 PaymentReference { get; init; } 
    #else
    public PaymentIdentification1 PaymentReference { get; set; } 
    #endif
    
    /// <summary>
    /// Set of elements used to further specify the type of transaction.
    /// </summary>
    [IsoId("_OTgzNDI1-AOSNFX-8224504")]
    [DisplayName("Payment Means")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PmtMeans")]
    #endif
    [IsoXmlTag("PmtMeans")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PaymentMeans1 PaymentMeans { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PaymentMeans1 PaymentMeans { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PaymentMeans1 PaymentMeans { get; init; } 
    #else
    public PaymentMeans1 PaymentMeans { get; set; } 
    #endif
    
    /// <summary>
    /// Effective date of payment.
    /// </summary>
    [IsoId("_OTgzNDI2-AOSNFX-8224504")]
    [DisplayName("Payment Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PmtDt")]
    #endif
    [IsoXmlTag("PmtDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODate PaymentDate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.DateOnly PaymentDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly PaymentDate { get; init; } 
    #else
    public System.DateOnly PaymentDate { get; set; } 
    #endif
    
    /// <summary>
    /// Terms of the payment.
    /// </summary>
    [IsoId("_OTgzNDI3-AOSNFX-8224504")]
    [DisplayName("Payment Terms")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PmtTerms")]
    #endif
    [IsoXmlTag("PmtTerms")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PaymentTerms6 PaymentTerms { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PaymentTerms6 PaymentTerms { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PaymentTerms6 PaymentTerms { get; init; } 
    #else
    public PaymentTerms6 PaymentTerms { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of the referenced payment.
    /// </summary>
    [IsoId("_OTgzNDI4-AOSNFX-8224504")]
    [DisplayName("Payment Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PmtAmt")]
    #endif
    [IsoXmlTag("PmtAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CurrencyAndAmount PaymentAmount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CurrencyAndAmount PaymentAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CurrencyAndAmount PaymentAmount { get; init; } 
    #else
    public CurrencyAndAmount PaymentAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Financial item impacted by the payment.
    /// </summary>
    [IsoId("_OTgzNDI5-AOSNFX-8224504")]
    [DisplayName("Item")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Itm")]
    #endif
    [IsoXmlTag("Itm")]
    public ValueList<FinancialItem1> Item { get; init; } = new ValueList<FinancialItem1>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _OTgzNDI5-AOSNFX-8224504
    
    /// <summary>
    /// Number of individual items contained in the list.
    /// </summary>
    [IsoId("_OTgzNDMw-AOSNFX-8224504")]
    [DisplayName("Item Count")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ItmCnt")]
    #endif
    [IsoXmlTag("ItmCnt")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax15NumericText ItemCount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String ItemCount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String ItemCount { get; init; } 
    #else
    public System.String ItemCount { get; set; } 
    #endif
    
    /// <summary>
    /// Total of all individual amounts included in the list, irrespective of currencies.
    /// </summary>
    [IsoId("_OTgzNDMx-AOSNFX-8224504")]
    [DisplayName("Control Sum")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtrlSum")]
    #endif
    [IsoXmlTag("CtrlSum")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoDecimalNumber? ControlSum { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? ControlSum { get; init; } 
    #else
    public System.UInt64? ControlSum { get; set; } 
    #endif
    
    /// <summary>
    /// Associated free form document.
    /// </summary>
    [IsoId("_OTgzNDMy-AOSNFX-8224504")]
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
    /// Additional proprietary formal information concerning the list.
    /// </summary>
    [IsoId("_OTgzNDMz-AOSNFX-8224505")]
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
    /// Validation status of the list.
    /// </summary>
    [IsoId("_OTgzNDM0-AOSNFX-8224505")]
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
    
    
    #nullable disable
    
}
