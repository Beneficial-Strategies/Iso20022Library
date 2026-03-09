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
/// Details of the advice for the issuance of an undertaking.
/// </summary>
[IsoId("_-AfqUnltEeG7BsjMvd1mEw_27275144")]
[DisplayName("Undertaking Advice")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record UndertakingAdvice2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a UndertakingAdvice2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public UndertakingAdvice2( System.String reqApplicantReferenceNumber,UndertakingIssuanceMessage reqUndertakingIssuanceMessage )
    {
        ApplicantReferenceNumber = reqApplicantReferenceNumber;
        UndertakingIssuanceMessage = reqUndertakingIssuanceMessage;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identifier assigned by the applicant to the undertaking.
    /// </summary>
    [IsoId("_-AfqU3ltEeG7BsjMvd1mEw_682292746")]
    [DisplayName("Applicant Reference Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ApplcntRefNb")]
    #endif
    [IsoXmlTag("ApplcntRefNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text ApplicantReferenceNumber { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String ApplicantReferenceNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String ApplicantReferenceNumber { get; init; } 
    #else
    public System.String ApplicantReferenceNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Party obligated to reimburse the issuer.
    /// </summary>
    [IsoId("_6-mNY4ABEeGOn4dfTT_QdQ")]
    [DisplayName("Obligor")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Oblgr")]
    #endif
    [IsoXmlTag("Oblgr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification43? Obligor { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification43? Obligor { get; init; } 
    #else
    public PartyIdentification43? Obligor { get; set; } 
    #endif
    
    /// <summary>
    /// Contents of the related UndertakingIssuance message.
    /// </summary>
    [IsoId("_-AfqVHltEeG7BsjMvd1mEw_674201231")]
    [DisplayName("Undertaking Issuance Message")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UdrtkgIssncMsg")]
    #endif
    [IsoXmlTag("UdrtkgIssncMsg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required UndertakingIssuanceMessage UndertakingIssuanceMessage { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required UndertakingIssuanceMessage UndertakingIssuanceMessage { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UndertakingIssuanceMessage UndertakingIssuanceMessage { get; init; } 
    #else
    public UndertakingIssuanceMessage UndertakingIssuanceMessage { get; set; } 
    #endif
    
    /// <summary>
    /// Medium used to issue the original undertaking.
    /// </summary>
    [IsoId("_-ApbUHltEeG7BsjMvd1mEw_-1209989499")]
    [DisplayName("Original Issued Medium")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlIssdMdm")]
    #endif
    [IsoXmlTag("OrgnlIssdMdm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PresentationMedium1Code? OriginalIssuedMedium { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PresentationMedium1Code? OriginalIssuedMedium { get; init; } 
    #else
    public PresentationMedium1Code? OriginalIssuedMedium { get; set; } 
    #endif
    
    /// <summary>
    /// Document or template enclosed in the notification.
    /// </summary>
    [IsoId("_-ApbUXltEeG7BsjMvd1mEw_637726234")]
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
    /// Additional information related to the undertaking notification.
    /// </summary>
    [IsoId("_-ApbUnltEeG7BsjMvd1mEw_776941520")]
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
