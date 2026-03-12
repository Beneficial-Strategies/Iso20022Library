// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif


namespace BeneficialStrategies.Iso20022.auth;

/// <summary>
/// This record is an implementation of the auth.001.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// This message is sent by the authorities (police, customs, tax authorities, enforcement authorities) to a financial institution to request account and other banking and financial information. Requested information can relate to accounts, their signatories and beneficiaries and co-owners as well as movements plus positions on these accounts.
/// 
/// Requests are underpinned by specific legal texts.
/// </summary>
[Description(@"This message is sent by the authorities (police, customs, tax authorities, enforcement authorities) to a financial institution to request account and other banking and financial information. Requested information can relate to accounts, their signatories and beneficiaries and co-owners as well as movements plus positions on these accounts.||Requests are underpinned by specific legal texts.")]
[IsoId("_ixVXwztbEeGg8InIPRjKog")]
[DisplayName("Information Request Opening V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record InformationRequestOpeningV01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "auth.001.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "InfReqOpng";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:auth.001.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;
    
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a InformationRequestOpeningV01 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public InformationRequestOpeningV01( System.String reqInvestigationIdentification,LegalMandate1 reqLegalMandateBasis,System.String reqConfidentialityStatus,DateOrDateTimePeriodChoice_ reqInvestigationPeriod,SearchCriteria1Choice_ reqSearchCriteria )
    {
        InvestigationIdentification = reqInvestigationIdentification;
        LegalMandateBasis = reqLegalMandateBasis;
        ConfidentialityStatus = reqConfidentialityStatus;
        InvestigationPeriod = reqInvestigationPeriod;
        SearchCriteria = reqSearchCriteria;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique identification for the specific investigation as known by the requesting party.
    /// </summary>
    [IsoId("_MvVY3zteEeGg8InIPRjKog")]
    [DisplayName("Investigation Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InvstgtnId")]
    #endif
    [IsoXmlTag("InvstgtnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text InvestigationIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String InvestigationIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String InvestigationIdentification { get; init; } 
    #else
    public System.String InvestigationIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Provides details on the legal basis of the request.
    /// </summary>
    [IsoId("_Gh6K-0J9EeGuetKibuqsKw")]
    [DisplayName("Legal Mandate Basis")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LglMndtBsis")]
    #endif
    [IsoXmlTag("LglMndtBsis")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required LegalMandate1 LegalMandateBasis { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required LegalMandate1 LegalMandateBasis { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public LegalMandate1 LegalMandateBasis { get; init; } 
    #else
    public LegalMandate1 LegalMandateBasis { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the confidentiality status of the investigation.
    /// </summary>
    [IsoId("_UdsRrz2NEeGG64_ngBNdUg")]
    [DisplayName("Confidentiality Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CnfdtltySts")]
    #endif
    [IsoXmlTag("CnfdtltySts")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoYesNoIndicator ConfidentialityStatus { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String ConfidentialityStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String ConfidentialityStatus { get; init; } 
    #else
    public System.String ConfidentialityStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the date by when the financial institutiion needs to provide a response.
    /// </summary>
    [IsoId("_6Pv_70cVEeGlWcsEChp7QA")]
    [DisplayName("Due Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DueDt")]
    #endif
    [IsoXmlTag("DueDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DueDate1? DueDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DueDate1? DueDate { get; init; } 
    #else
    public DueDate1? DueDate { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the dates between which period the authority requests that the financial institution provides a response to the information request.
    /// </summary>
    [IsoId("_VWAzXzwlEeGUCuI3g5RrVg")]
    [DisplayName("Investigation Period")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InvstgtnPrd")]
    #endif
    [IsoXmlTag("InvstgtnPrd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DateOrDateTimePeriodChoice_ InvestigationPeriod { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DateOrDateTimePeriodChoice_ InvestigationPeriod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateOrDateTimePeriodChoice_ InvestigationPeriod { get; init; } 
    #else
    public DateOrDateTimePeriodChoice_ InvestigationPeriod { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the the search criteria for the financial institution to perform the search on. The search criteria can be an account, a customer identification or a payment instrument type.
    /// </summary>
    [IsoId("_qpVADzthEeGg8InIPRjKog")]
    [DisplayName("Search Criteria")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SchCrit")]
    #endif
    [IsoXmlTag("SchCrit")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SearchCriteria1Choice_ SearchCriteria { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SearchCriteria1Choice_ SearchCriteria { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SearchCriteria1Choice_ SearchCriteria { get; init; } 
    #else
    public SearchCriteria1Choice_ SearchCriteria { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_O_AtrzwoEeGUCuI3g5RrVg")]
    [DisplayName("Supplementary Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SplmtryData")]
    #endif
    [IsoXmlTag("SplmtryData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SupplementaryData1? SupplementaryData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SupplementaryData1? SupplementaryData { get; init; } 
    #else
    public SupplementaryData1? SupplementaryData { get; set; } 
    #endif
    
    
    #nullable disable
    
}


// Since InformationRequestOpeningV01Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to InformationRequestOpeningV01.

