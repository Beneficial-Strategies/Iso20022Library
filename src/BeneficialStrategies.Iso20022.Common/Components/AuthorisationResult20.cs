// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Authorisation Result20.
/// </summary>
[IsoId("_JKTUkZ-vEe-nbM0aSPcoiQ")]
[DisplayName("Authorisation Result20")]
public partial record AuthorisationResult20
{
    #nullable enable

    /// <summary>
    /// Action.
    /// </summary>
    [DisplayName("Action")]
    [IsoXmlTag("Actn")]
    public ValueList<Action7> Action { get; init; } = [];

    /// <summary>
    /// Authorisation Code.
    /// </summary>
    [DisplayName("Authorisation Code")]
    [IsoXmlTag("AuthstnCd")]
    public IsoMax8Text? AuthorisationCode { get; init; } 

    /// <summary>
    /// Authorisation Entity.
    /// </summary>
    [DisplayName("Authorisation Entity")]
    [IsoXmlTag("AuthstnNtty")]
    public PartyType16Code? AuthorisationEntity { get; init; } 

    /// <summary>
    /// Authorisation Response.
    /// </summary>
    [DisplayName("Authorisation Response")]
    [IsoXmlTag("AuthstnRspn")]
    public required ResponseType12 AuthorisationResponse { get; init; } 

    /// <summary>
    /// Fee To Add.
    /// </summary>
    [DisplayName("Fee To Add")]
    [IsoXmlTag("FeeToAdd")]
    public ValueList<ATMFeeComponent1> FeeToAdd { get; init; } = [];

    /// <summary>
    /// Response Trace.
    /// </summary>
    [DisplayName("Response Trace")]
    [IsoXmlTag("RspnTrac")]
    public ValueList<ResponseType8> ResponseTrace { get; init; } = [];

    
    #nullable disable
    
}
