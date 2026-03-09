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
/// Defines a list of party management registration and guarantee requests.
/// </summary>
[IsoId("_OTgzMTk1-AOSNFX-8224490")]
[DisplayName("Financing Agreement List")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record FinancingAgreementList1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a FinancingAgreementList1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public FinancingAgreementList1( System.String reqIdentifier,System.DateOnly reqDate,QualifiedPartyIdentification1 reqAgreementRequestor,QualifiedPartyIdentification1 reqAgreementResponder,QualifiedPartyIdentification1 reqGuaranteeApplicant,QualifiedPartyIdentification1 reqGuaranteeBeneficiary,QualifiedPartyIdentification1 reqGuaranteeIssuer,System.String reqItemCount )
    {
        Identifier = reqIdentifier;
        Date = reqDate;
        AgreementRequestor = reqAgreementRequestor;
        AgreementResponder = reqAgreementResponder;
        GuaranteeApplicant = reqGuaranteeApplicant;
        GuaranteeBeneficiary = reqGuaranteeBeneficiary;
        GuaranteeIssuer = reqGuaranteeIssuer;
        ItemCount = reqItemCount;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification assigned to unambiguously identify the agreement list.
    /// </summary>
    [IsoId("_OTgzMzQ4-AOSNFX-8224501")]
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
    /// Creation date of this list.
    /// </summary>
    [IsoId("_OTgzMzQ5-AOSNFX-8224501")]
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
    /// Reference to related document.
    /// </summary>
    [IsoId("_OTgzMzUw-AOSNFX-8224501")]
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
    /// Requestor of the agreement(s).
    /// </summary>
    [IsoId("_OTgzMzUx-AOSNFX-8224501")]
    [DisplayName("Agreement Requestor")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AgrmtRqstr")]
    #endif
    [IsoXmlTag("AgrmtRqstr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required QualifiedPartyIdentification1 AgreementRequestor { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required QualifiedPartyIdentification1 AgreementRequestor { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public QualifiedPartyIdentification1 AgreementRequestor { get; init; } 
    #else
    public QualifiedPartyIdentification1 AgreementRequestor { get; set; } 
    #endif
    
    /// <summary>
    /// Party the agreement(s) are (to be) made with.
    /// </summary>
    [IsoId("_OTgzMzUy-AOSNFX-8224501")]
    [DisplayName("Agreement Responder")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AgrmtRspndr")]
    #endif
    [IsoXmlTag("AgrmtRspndr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required QualifiedPartyIdentification1 AgreementResponder { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required QualifiedPartyIdentification1 AgreementResponder { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public QualifiedPartyIdentification1 AgreementResponder { get; init; } 
    #else
    public QualifiedPartyIdentification1 AgreementResponder { get; set; } 
    #endif
    
    /// <summary>
    /// Applicant of the guarantee.
    /// </summary>
    [IsoId("_OTgzMzUz-AOSNFX-8224501")]
    [DisplayName("Guarantee Applicant")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="GrntApplcnt")]
    #endif
    [IsoXmlTag("GrntApplcnt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required QualifiedPartyIdentification1 GuaranteeApplicant { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required QualifiedPartyIdentification1 GuaranteeApplicant { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public QualifiedPartyIdentification1 GuaranteeApplicant { get; init; } 
    #else
    public QualifiedPartyIdentification1 GuaranteeApplicant { get; set; } 
    #endif
    
    /// <summary>
    /// Beneficiary of the guarantee.
    /// </summary>
    [IsoId("_OTgzMzUZ-AOSNFX-8224501")]
    [DisplayName("Guarantee Beneficiary")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="GrntNbfcry")]
    #endif
    [IsoXmlTag("GrntNbfcry")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required QualifiedPartyIdentification1 GuaranteeBeneficiary { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required QualifiedPartyIdentification1 GuaranteeBeneficiary { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public QualifiedPartyIdentification1 GuaranteeBeneficiary { get; init; } 
    #else
    public QualifiedPartyIdentification1 GuaranteeBeneficiary { get; set; } 
    #endif
    
    /// <summary>
    /// Party that issues the guarantee.
    /// </summary>
    [IsoId("_OTgzMzU0-AOSNFX-8224501")]
    [DisplayName("Guarantee Issuer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="GrntIssr")]
    #endif
    [IsoXmlTag("GrntIssr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required QualifiedPartyIdentification1 GuaranteeIssuer { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required QualifiedPartyIdentification1 GuaranteeIssuer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public QualifiedPartyIdentification1 GuaranteeIssuer { get; init; } 
    #else
    public QualifiedPartyIdentification1 GuaranteeIssuer { get; set; } 
    #endif
    
    /// <summary>
    /// Party or parties to notify and to acknowledge the agreement.
    /// </summary>
    [IsoId("_OTgzMzU1-AOSNFX-8224501")]
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
    /// List of agreement items.
    /// </summary>
    [IsoId("_OTgzMzU3-AOSNFX-8224501")]
    [DisplayName("Item")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Itm")]
    #endif
    [IsoXmlTag("Itm")]
    public ValueList<FinancingAgreementItem1> Item { get; init; } = new ValueList<FinancingAgreementItem1>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _OTgzMzU3-AOSNFX-8224501
    
    /// <summary>
    /// Number of individual items contained in the list.
    /// </summary>
    [IsoId("_OTgzMzU4-AOSNFX-8224501")]
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
    [IsoId("_OTgzMzU5-AOSNFX-8224501")]
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
    /// Additional proprietary formal information concerning the list.
    /// </summary>
    [IsoId("_OTgzMzYw-AOSNFX-8224501")]
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
    [IsoId("_OTgzMzYx-AOSNFX-8224501")]
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
