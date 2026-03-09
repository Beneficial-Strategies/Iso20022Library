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
[IsoId("_9-Q1snltEeG7BsjMvd1mEw_-687774575")]
[DisplayName("Amendment")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Amendment2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Amendment2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Amendment2( UndertakingAmendmentMessage1 reqUndertakingAmendmentMessage )
    {
        UndertakingAmendmentMessage = reqUndertakingAmendmentMessage;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Contents of the related Undertaking Amendment message.
    /// </summary>
    [IsoId("_9-Z_oXltEeG7BsjMvd1mEw_-922767707")]
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
    /// Additional information related to the first advising party.
    /// </summary>
    [IsoId("__Ruatz1XEeKWjKfYlNE7jQ")]
    [DisplayName("First Advising Party Additional Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FrstAdvsgPtyAddtlInf")]
    #endif
    [IsoXmlTag("FrstAdvsgPtyAddtlInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdvisingPartyAdditionalInformation1? FirstAdvisingPartyAdditionalInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdvisingPartyAdditionalInformation1? FirstAdvisingPartyAdditionalInformation { get; init; } 
    #else
    public AdvisingPartyAdditionalInformation1? FirstAdvisingPartyAdditionalInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information related to the second advising party.
    /// </summary>
    [IsoId("_BTNxVz1YEeKWjKfYlNE7jQ")]
    [DisplayName("Second Advising Party Additional Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ScndAdvsgPtyAddtlInf")]
    #endif
    [IsoXmlTag("ScndAdvsgPtyAddtlInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdvisingPartyAdditionalInformation1? SecondAdvisingPartyAdditionalInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdvisingPartyAdditionalInformation1? SecondAdvisingPartyAdditionalInformation { get; init; } 
    #else
    public AdvisingPartyAdditionalInformation1? SecondAdvisingPartyAdditionalInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Details concerning the confirmation of the proposed amendment.
    /// </summary>
    [IsoId("_9-Z_onltEeG7BsjMvd1mEw_1012422079")]
    [DisplayName("Confirmation Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ConfDtls")]
    #endif
    [IsoXmlTag("ConfDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public UndertakingConfirmation1? ConfirmationDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UndertakingConfirmation1? ConfirmationDetails { get; init; } 
    #else
    public UndertakingConfirmation1? ConfirmationDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Digital signature of the party providing additional undertaking amendment advice details.
    /// </summary>
    [IsoId("_9-Z_o3ltEeG7BsjMvd1mEw_1663412254")]
    [DisplayName("Digital Signature")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DgtlSgntr")]
    #endif
    [IsoXmlTag("DgtlSgntr")]
    [MinLength(0)]
    [MaxLength(3)]
    public ValueList<PartyAndSignature2> DigitalSignature { get; init; } = new ValueList<PartyAndSignature2>(){};
    
    
    #nullable disable
    
}
