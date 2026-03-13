// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of the advice for the issuance of an undertaking.
/// </summary>
[IsoId("_-AMvZnltEeG7BsjMvd1mEw_-927366247")]
[DisplayName("Undertaking Advice")]
public partial record UndertakingAdvice1
{
    #nullable enable
    
    /// <summary>
    /// Contents of the related UndertakingIssuance message.
    /// </summary>
    [IsoId("_-AV5UHltEeG7BsjMvd1mEw_-1964463570")]
    [DisplayName("Undertaking Issuance Message")]
    [IsoXmlTag("UdrtkgIssncMsg")]
    public required UndertakingIssuanceMessage UndertakingIssuanceMessage { get; init; } 
    
    /// <summary>
    /// Additional information related to the first advising party.
    /// </summary>
    [IsoId("_1N8wBT1UEeKvwJ48Wu13ug")]
    [DisplayName("First Advising Party Additional Information")]
    [IsoXmlTag("FrstAdvsgPtyAddtlInf")]
    public AdvisingPartyAdditionalInformation1? FirstAdvisingPartyAdditionalInformation { get; init; } 
    
    /// <summary>
    /// Additional information related to the second advising party.
    /// </summary>
    [IsoId("_32L9lT1UEeKvwJ48Wu13ug")]
    [DisplayName("Second Advising Party Additional Information")]
    [IsoXmlTag("ScndAdvsgPtyAddtlInf")]
    public AdvisingPartyAdditionalInformation1? SecondAdvisingPartyAdditionalInformation { get; init; } 
    
    /// <summary>
    /// Details related to the confirmation of the undertaking.
    /// </summary>
    [IsoId("_-AV5UXltEeG7BsjMvd1mEw_616959669")]
    [DisplayName("Confirmation Details")]
    [IsoXmlTag("ConfDtls")]
    public UndertakingConfirmation1? ConfirmationDetails { get; init; } 
    
    /// <summary>
    /// Digital signature of the party providing additional undertaking advice details.
    /// </summary>
    [IsoId("_AoReQz1VEeKvwJ48Wu13ug")]
    [DisplayName("Digital Signature")]
    [IsoXmlTag("DgtlSgntr")]
    [MinLength(0)]
    [MaxLength(3)]
    public ValueList<PartyAndSignature2> DigitalSignature { get; init; } = [];
    
    
    #nullable disable
    
}
