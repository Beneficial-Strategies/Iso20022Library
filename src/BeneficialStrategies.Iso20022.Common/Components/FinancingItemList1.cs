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
/// Specifies a list of financing items exchanged between two parties, for example invoice, credit, financing request.
/// </summary>
[IsoId("_OTgzMTk3-AOSNFX-8224490")]
[DisplayName("Financing Item List")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record FinancingItemList1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a FinancingItemList1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public FinancingItemList1( System.String reqIdentifier,System.DateOnly reqIssueDate,QualifiedPartyIdentification1 reqAssignee,QualifiedPartyIdentification1 reqAssigner,System.String reqItemCount )
    {
        Identifier = reqIdentifier;
        IssueDate = reqIssueDate;
        Assignee = reqAssignee;
        Assigner = reqAssigner;
        ItemCount = reqItemCount;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification assigned to unambiguously identify the financing item list.
    /// </summary>
    [IsoId("_OTgzMzI0-AOSNFX-8224499")]
    [DisplayName("Identifier")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Idr")]
    #endif
    [IsoXmlTag("Idr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text Identifier { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Identifier { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Identifier { get; init; } 
    #else
    public System.String Identifier { get; set; } 
    #endif
    
    /// <summary>
    /// Date of creation of this document.
    /// </summary>
    [IsoId("_OTgzMzI1-AOSNFX-8224499")]
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
    /// Reference to related documents for example to original assignment in a status response or retry.
    /// </summary>
    [IsoId("_OTgzMzI2-AOSNFX-8224500")]
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
    /// Cut off date for items used to establish the total request amount.
    /// </summary>
    [IsoId("_OTgzMzI3-AOSNFX-8224500")]
    [DisplayName("Amount Cut Off Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AmtCutOffDt")]
    #endif
    [IsoXmlTag("AmtCutOffDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? AmountCutOffDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? AmountCutOffDate { get; init; } 
    #else
    public System.DateOnly? AmountCutOffDate { get; set; } 
    #endif
    
    /// <summary>
    /// Party to which the list is assigned.
    /// </summary>
    [IsoId("_OTgzMzI4-AOSNFX-8224500")]
    [DisplayName("Assignee")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Assgne")]
    #endif
    [IsoXmlTag("Assgne")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required QualifiedPartyIdentification1 Assignee { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required QualifiedPartyIdentification1 Assignee { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public QualifiedPartyIdentification1 Assignee { get; init; } 
    #else
    public QualifiedPartyIdentification1 Assignee { get; set; } 
    #endif
    
    /// <summary>
    /// Party assigning the list.
    /// </summary>
    [IsoId("_OTgzMzI5-AOSNFX-8224500")]
    [DisplayName("Assigner")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Assgnr")]
    #endif
    [IsoXmlTag("Assgnr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required QualifiedPartyIdentification1 Assigner { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required QualifiedPartyIdentification1 Assigner { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public QualifiedPartyIdentification1 Assigner { get; init; } 
    #else
    public QualifiedPartyIdentification1 Assigner { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies parties that notify the assignment(s) and the notified parties.
    /// </summary>
    [IsoId("_OTgzMzMx-AOSNFX-8224500")]
    [DisplayName("Notification Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NtfctnInf")]
    #endif
    [IsoXmlTag("NtfctnInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancingNotificationParties1? NotificationInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancingNotificationParties1? NotificationInformation { get; init; } 
    #else
    public FinancingNotificationParties1? NotificationInformation { get; set; } 
    #endif
    
    /// <summary>
    /// List of items/transactions.
    /// </summary>
    [IsoId("_OTgzMzMz-AOSNFX-8224500")]
    [DisplayName("Financial Item")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FinItm")]
    #endif
    [IsoXmlTag("FinItm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialItem1? FinancialItem { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialItem1? FinancialItem { get; init; } 
    #else
    public FinancialItem1? FinancialItem { get; set; } 
    #endif
    
    /// <summary>
    /// Number of individual items contained in the list.
    /// </summary>
    [IsoId("_OTgzMzM0-AOSNFX-8224500")]
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
    [IsoId("_OTgzMzM1-AOSNFX-8224500")]
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
    /// Total amount in all items. Requires same currency, necessary when financing request is in percentage.
    /// </summary>
    [IsoId("_OTgzMzM2-AOSNFX-8224500")]
    [DisplayName("Total Request Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlReqAmt")]
    #endif
    [IsoXmlTag("TtlReqAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? TotalRequestAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? TotalRequestAmount { get; init; } 
    #else
    public ActiveCurrencyAndAmount? TotalRequestAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Total amount requested.
    /// </summary>
    [IsoId("_OTgzMzM3-AOSNFX-8224500")]
    [DisplayName("Total Request Financing")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlReqFincg")]
    #endif
    [IsoXmlTag("TtlReqFincg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancingRateOrAmountChoice_? TotalRequestFinancing { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancingRateOrAmountChoice_? TotalRequestFinancing { get; init; } 
    #else
    public FinancingRateOrAmountChoice_? TotalRequestFinancing { get; set; } 
    #endif
    
    /// <summary>
    /// Acceptable exchange rate for financing by different currency.
    /// </summary>
    [IsoId("_OTgzMzM4-AOSNFX-8224500")]
    [DisplayName("Agreed Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AgrdRate")]
    #endif
    [IsoXmlTag("AgrdRate")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AgreedRate1? AgreedRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AgreedRate1? AgreedRate { get; init; } 
    #else
    public AgreedRate1? AgreedRate { get; set; } 
    #endif
    
    /// <summary>
    /// Instalment for the financing.
    /// </summary>
    [IsoId("_OTgzMzQw-AOSNFX-8224500")]
    [DisplayName("Financing Instalment")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FincgInstlmt")]
    #endif
    [IsoXmlTag("FincgInstlmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Instalment2? FinancingInstalment { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Instalment2? FinancingInstalment { get; init; } 
    #else
    public Instalment2? FinancingInstalment { get; set; } 
    #endif
    
    /// <summary>
    /// Additional free form information concerning the list.
    /// </summary>
    [IsoId("_OTgzMzQx-AOSNFX-8224500")]
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
    [IsoId("_OTgzMzQy-AOSNFX-8224500")]
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
    /// Financing status if applicable to the nature of the items.
    /// </summary>
    [IsoId("_OTgzMzQz-AOSNFX-8224500")]
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
    
    
    #nullable disable
    
}
