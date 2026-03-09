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
/// Details of the amendent request.
/// </summary>
[IsoId("_999TsHltEeG7BsjMvd1mEw_-1184372634")]
[DisplayName("Amendment")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Amendment3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Amendment3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Amendment3( System.String reqApplicantRequestNumber,Undertaking9 reqUndertakingIdentification,PartyIdentification43 reqApplicant )
    {
        ApplicantRequestNumber = reqApplicantRequestNumber;
        UndertakingIdentification = reqUndertakingIdentification;
        Applicant = reqApplicant;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identifier assigned by the applicant to the undertaking amendment request.
    /// </summary>
    [IsoId("_999TsXltEeG7BsjMvd1mEw_-1391454126")]
    [DisplayName("Applicant Request Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ApplcntReqNb")]
    #endif
    [IsoXmlTag("ApplcntReqNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text ApplicantRequestNumber { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String ApplicantRequestNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String ApplicantRequestNumber { get; init; } 
    #else
    public System.String ApplicantRequestNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the undertaking.
    /// </summary>
    [IsoId("_999TsnltEeG7BsjMvd1mEw_911944804")]
    [DisplayName("Undertaking Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UdrtkgId")]
    #endif
    [IsoXmlTag("UdrtkgId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Undertaking9 UndertakingIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Undertaking9 UndertakingIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Undertaking9 UndertakingIdentification { get; init; } 
    #else
    public Undertaking9 UndertakingIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Party requesting the issuance of the amendment.
    /// </summary>
    [IsoId("_999Ts3ltEeG7BsjMvd1mEw_1152590564")]
    [DisplayName("Applicant")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Applcnt")]
    #endif
    [IsoXmlTag("Applcnt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PartyIdentification43 Applicant { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PartyIdentification43 Applicant { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification43 Applicant { get; init; } 
    #else
    public PartyIdentification43 Applicant { get; set; } 
    #endif
    
    /// <summary>
    /// Details concerning the requested termination of the undertaking.
    /// </summary>
    [IsoId("_9-HEsHltEeG7BsjMvd1mEw_2064337649")]
    [DisplayName("Termination Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TermntnDtls")]
    #endif
    [IsoXmlTag("TermntnDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public UndertakingTermination3? TerminationDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UndertakingTermination3? TerminationDetails { get; init; } 
    #else
    public UndertakingTermination3? TerminationDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Indication of the amount of increase or decrease to the undertaking amount.
    /// </summary>
    [IsoId("_9-HEsXltEeG7BsjMvd1mEw_-1359539373")]
    [DisplayName("Increase Decrease Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IncrDcrAmt")]
    #endif
    [IsoXmlTag("IncrDcrAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public UndertakingAmount2? IncreaseDecreaseAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UndertakingAmount2? IncreaseDecreaseAmount { get; init; } 
    #else
    public UndertakingAmount2? IncreaseDecreaseAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Requested new expiry terms for the undertaking.
    /// </summary>
    [IsoId("_9-HEsnltEeG7BsjMvd1mEw_-880815384")]
    [DisplayName("New Expiry Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NewXpryDtls")]
    #endif
    [IsoXmlTag("NewXpryDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ExpiryDetails2? NewExpiryDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExpiryDetails2? NewExpiryDetails { get; init; } 
    #else
    public ExpiryDetails2? NewExpiryDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Requested new beneficiary of the undertaking.
    /// </summary>
    [IsoId("_9-HEs3ltEeG7BsjMvd1mEw_1568325617")]
    [DisplayName("New Beneficiary")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NewBnfcry")]
    #endif
    [IsoXmlTag("NewBnfcry")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Beneficiary1? NewBeneficiary { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Beneficiary1? NewBeneficiary { get; init; } 
    #else
    public Beneficiary1? NewBeneficiary { get; set; } 
    #endif
    
    /// <summary>
    /// Requested new terms and conditions of the undertaking.
    /// </summary>
    [IsoId("_9-HEtHltEeG7BsjMvd1mEw_-2101190221")]
    [DisplayName("New Undertaking Terms And Conditions")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NewUdrtkgTermsAndConds")]
    #endif
    [IsoXmlTag("NewUdrtkgTermsAndConds")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Narrative1? NewUndertakingTermsAndConditions { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Narrative1? NewUndertakingTermsAndConditions { get; init; } 
    #else
    public Narrative1? NewUndertakingTermsAndConditions { get; set; } 
    #endif
    
    /// <summary>
    /// Amendment details related to the counter-undertaking.
    /// </summary>
    [IsoId("_rFW_UH76EeGvEbxvurqpIg")]
    [DisplayName("Counter Undertaking")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CntrUdrtkg")]
    #endif
    [IsoXmlTag("CntrUdrtkg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Undertaking10? CounterUndertaking { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Undertaking10? CounterUndertaking { get; init; } 
    #else
    public Undertaking10? CounterUndertaking { get; set; } 
    #endif
    
    /// <summary>
    /// Communication channel for delivery of the amendment.
    /// </summary>
    [IsoId("_9-HEtXltEeG7BsjMvd1mEw_-474768646")]
    [DisplayName("Delivery Channel")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DlvryChanl")]
    #endif
    [IsoXmlTag("DlvryChanl")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CommunicationChannel1? DeliveryChannel { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CommunicationChannel1? DeliveryChannel { get; init; } 
    #else
    public CommunicationChannel1? DeliveryChannel { get; set; } 
    #endif
    
    /// <summary>
    /// Document or template enclosed in the request.
    /// </summary>
    [IsoId("_9-Q1sHltEeG7BsjMvd1mEw_1278799241")]
    [DisplayName("Enclosed File")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NclsdFile")]
    #endif
    [IsoXmlTag("NclsdFile")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Document9? EnclosedFile { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Document9? EnclosedFile { get; init; } 
    #else
    public Document9? EnclosedFile { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information related to the request.
    /// </summary>
    [IsoId("_9-Q1sXltEeG7BsjMvd1mEw_-1410697911")]
    [DisplayName("Additional Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlInf")]
    #endif
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max2000Text)]
    [MinLength(0)]
    [MaxLength(5)]
    public SimpleValueList<System.String> AdditionalInformation { get; init; } = new SimpleValueList<System.String>(){};
    
    
    #nullable disable
    
}
