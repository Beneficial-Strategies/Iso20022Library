// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Outcome of the withdrawal authorisation.
/// </summary>
[IsoId("_rG8tga1-EeWMg5rOByfExw")]
[DisplayName("Authorisation Result")]
public partial record AuthorisationResult13
{
    #nullable enable
    
    /// <summary>
    /// Type of party that has delivered or declined the card payment authorisation (the party is not identified).
    /// </summary>
    [IsoId("_rUW3Ya1-EeWMg5rOByfExw")]
    [DisplayName("Authorisation Entity")]
    [IsoXmlTag("AuthstnNtty")]
    public PartyType16Code? AuthorisationEntity { get; init; } 
    
    /// <summary>
    /// Result of the authorisation.
    /// </summary>
    [IsoId("_rUW3Y61-EeWMg5rOByfExw")]
    [DisplayName("Authorisation Response")]
    [IsoXmlTag("AuthstnRspn")]
    public required ResponseType7 AuthorisationResponse { get; init; } 
    
    /// <summary>
    /// Trace of response by the entities in the path from the issuer to the ATM.
    /// </summary>
    [IsoId("_NjiBAK2AEeWMg5rOByfExw")]
    [DisplayName("Response Trace")]
    [IsoXmlTag("RspnTrac")]
    public ResponseType8? ResponseTrace { get; init; } 
    
    /// <summary>
    /// Value assigned by the authorising party.
    /// </summary>
    [IsoId("_rUW3Z61-EeWMg5rOByfExw")]
    [DisplayName("Authorisation Code")]
    [IsoXmlTag("AuthstnCd")]
    [IsoSimpleType(IsoSimpleType.Min6Max8Text)]
    [StringLength(maximumLength: 8 ,MinimumLength = 6)]
    public IsoMin6Max8Text? AuthorisationCode { get; init; } 
    
    /// <summary>
    /// Sequence of actions to be performed by the ATM to complete the transaction.
    /// </summary>
    [IsoId("_rUW3aa1-EeWMg5rOByfExw")]
    [DisplayName("Action")]
    [IsoXmlTag("Actn")]
    public Action7? Action { get; init; } 
    
    
    #nullable disable
    
}
