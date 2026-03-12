// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Contents of an UndertakingAmendmentResponse message.
/// </summary>
[IsoId("_98n283ltEeG7BsjMvd1mEw_1014525589")]
[DisplayName("Undertaking Amendment Response Message")]
public partial record UndertakingAmendmentResponseMessage1
{
    #nullable enable
    
    /// <summary>
    /// Details of the proposed amendment response.
    /// </summary>
    [IsoId("_98xA4XltEeG7BsjMvd1mEw_-1912411864")]
    [DisplayName("Undertaking Amendment Response Details")]
    [IsoXmlTag("UdrtkgAmdmntRspnDtls")]
    public required Amendment7 UndertakingAmendmentResponseDetails { get; init; } 
    
    /// <summary>
    /// Digital signature of the response.
    /// </summary>
    [IsoId("_ASLHQ387EeGx884K2iQOLg")]
    [DisplayName("Digital Signature")]
    [IsoXmlTag("DgtlSgntr")]
    public PartyAndSignature2? DigitalSignature { get; init; } 
    
    
    #nullable disable
    
}
