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
/// Details of the amendment.
/// </summary>
[IsoId("_9_TXgXltEeG7BsjMvd1mEw_678552493")]
[DisplayName("Amendment")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Amendment6
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Amendment6 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Amendment6( UndertakingAmendmentMessage1 reqUndertakingAmendmentMessage )
    {
        UndertakingAmendmentMessage = reqUndertakingAmendmentMessage;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Contents of the related proposed Undertaking Amendment message.
    /// </summary>
    [IsoId("_9_TXgnltEeG7BsjMvd1mEw_667453716")]
    [DisplayName("Undertaking Amendment Message")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UdrtkgAmdmntMsg")]
    #endif
    [IsoXmlTag("UdrtkgAmdmntMsg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required UndertakingAmendmentMessage1 UndertakingAmendmentMessage { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required UndertakingAmendmentMessage1 UndertakingAmendmentMessage { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UndertakingAmendmentMessage1 UndertakingAmendmentMessage { get; init; } 
    #else
    public UndertakingAmendmentMessage1 UndertakingAmendmentMessage { get; set; } 
    #endif
    
    /// <summary>
    /// Unique and unambiguous identifier assigned by the applicant to the undertaking.
    /// </summary>
    [IsoId("_9_TXg3ltEeG7BsjMvd1mEw_1382360300")]
    [DisplayName("Applicant Reference Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ApplcntRefNb")]
    #endif
    [IsoXmlTag("ApplcntRefNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? ApplicantReferenceNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ApplicantReferenceNumber { get; init; } 
    #else
    public System.String? ApplicantReferenceNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information related to the notification.
    /// </summary>
    [IsoId("_9_dIgHltEeG7BsjMvd1mEw_105618459")]
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
