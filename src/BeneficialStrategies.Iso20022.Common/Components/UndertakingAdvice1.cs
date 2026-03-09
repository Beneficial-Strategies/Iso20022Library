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
[IsoId("_-AMvZnltEeG7BsjMvd1mEw_-927366247")]
[DisplayName("Undertaking Advice")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record UndertakingAdvice1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a UndertakingAdvice1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public UndertakingAdvice1( UndertakingIssuanceMessage reqUndertakingIssuanceMessage )
    {
        UndertakingIssuanceMessage = reqUndertakingIssuanceMessage;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Contents of the related UndertakingIssuance message.
    /// </summary>
    [IsoId("_-AV5UHltEeG7BsjMvd1mEw_-1964463570")]
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
    /// Additional information related to the first advising party.
    /// </summary>
    [IsoId("_1N8wBT1UEeKvwJ48Wu13ug")]
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
    [IsoId("_32L9lT1UEeKvwJ48Wu13ug")]
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
    /// Details related to the confirmation of the undertaking.
    /// </summary>
    [IsoId("_-AV5UXltEeG7BsjMvd1mEw_616959669")]
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
    /// Digital signature of the party providing additional undertaking advice details.
    /// </summary>
    [IsoId("_AoReQz1VEeKvwJ48Wu13ug")]
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
