// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Outcome of the authorisation.
/// </summary>
[IsoId("_XqFccS5AEeunNvJlR_vCbg")]
[DisplayName("Authorisation Result")]
public record AuthorisationResult15
{
    /// <summary>
    /// Type of party that has delivered or declined the card payment authorisation (the party is not identified).
    /// </summary>
    [IsoId("_X5oUUS5AEeunNvJlR_vCbg")]
    [DisplayName("Authorisation Entity")]
    [IsoXmlTag("AuthstnNtty")]
    public GenericIdentification90? AuthorisationEntity { get; init; }

    /// <summary>
    /// Response to an authorisation request.
    /// </summary>
    [IsoId("_X5oUUy5AEeunNvJlR_vCbg")]
    [DisplayName("Response To Authorisation")]
    [IsoXmlTag("RspnToAuthstn")]
    public required ResponseType10 ResponseToAuthorisation { get; init; }

    /// <summary>
    /// Value assigned by the authorising party.
    /// </summary>
    [IsoId("_X5oUVS5AEeunNvJlR_vCbg")]
    [DisplayName("Authorisation Code")]
    [IsoXmlTag("AuthstnCd")]
    [IsoSimpleType(IsoSimpleType.Min6Max8Text)]
    [StringLength(maximumLength: 8, MinimumLength = 6)]
    public IsoMin6Max8Text? AuthorisationCode { get; init; }
}
