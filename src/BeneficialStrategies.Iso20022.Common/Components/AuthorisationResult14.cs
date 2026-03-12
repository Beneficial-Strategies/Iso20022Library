// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Outcome of the authorisation, and actions to perform.
/// </summary>
[IsoId("_UAzjMQxqEeqdx6buGpCCQw")]
[DisplayName("Authorisation Result")]
public partial record AuthorisationResult14
{
    #nullable enable
    
    /// <summary>
    /// Type of party that has delivered or declined the card payment authorisation (the party is not identified).
    /// </summary>
    [IsoId("_ULphQQxqEeqdx6buGpCCQw")]
    [DisplayName("Authorisation Entity")]
    [IsoXmlTag("AuthstnNtty")]
    public GenericIdentification90? AuthorisationEntity { get; init; } 
    
    /// <summary>
    /// Response to an authorisation request.
    /// </summary>
    [IsoId("_ULphQwxqEeqdx6buGpCCQw")]
    [DisplayName("Response To Authorisation")]
    [IsoXmlTag("RspnToAuthstn")]
    public required ResponseType10 ResponseToAuthorisation { get; init; } 
    
    /// <summary>
    /// Value assigned by the authorising party.
    /// </summary>
    [IsoId("_ULphRQxqEeqdx6buGpCCQw")]
    [DisplayName("Authorisation Code")]
    [IsoXmlTag("AuthstnCd")]
    [IsoSimpleType(IsoSimpleType.Min6Max8Text)]
    [StringLength(maximumLength: 8 ,MinimumLength = 6)]
    public IsoMin6Max8Text? AuthorisationCode { get; init; } 
    
    /// <summary>
    /// Indicates whether the acquirer requires a further exchange completion after the completion of the transaction.
    /// </summary>
    [IsoId("_ULphRwxqEeqdx6buGpCCQw")]
    [DisplayName("Completion Required")]
    [IsoXmlTag("CmpltnReqrd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? CompletionRequired { get; init; } 
    
    /// <summary>
    /// Instructs the point of interaction (POI) how to contact the host to initiate the maintenance of the terminal.
    /// </summary>
    [IsoId("_ULphSQxqEeqdx6buGpCCQw")]
    [DisplayName("TMS Trigger")]
    [IsoXmlTag("TMSTrggr")]
    public TMSTrigger1? TMSTrigger { get; init; } 
    
    
    #nullable disable
    
}
