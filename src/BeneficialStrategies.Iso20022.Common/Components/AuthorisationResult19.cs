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
[IsoId("_nKgPMU7LEeyGi9JAv6wq7Q")]
[DisplayName("Authorisation Result")]
public record AuthorisationResult19
{
    /// <summary>
    /// Type of party that has delivered or declined the card payment authorisation (the party is not identified).
    /// </summary>
    [IsoId("_nQsWwU7LEeyGi9JAv6wq7Q")]
    [DisplayName("Authorisation Entity")]
    [IsoXmlTag("AuthstnNtty")]
    public GenericIdentification90? AuthorisationEntity { get; init; }

    /// <summary>
    /// Response to an authorisation request.
    /// </summary>
    [IsoId("_nQsWw07LEeyGi9JAv6wq7Q")]
    [DisplayName("Response To Authorisation")]
    [IsoXmlTag("RspnToAuthstn")]
    public required ResponseType10 ResponseToAuthorisation { get; init; }

    /// <summary>
    /// Value assigned by the authorising party.
    /// </summary>
    [IsoId("_nQsWxU7LEeyGi9JAv6wq7Q")]
    [DisplayName("Authorisation Code")]
    [IsoXmlTag("AuthstnCd")]
    [IsoSimpleType(IsoSimpleType.Max8Text)]
    [StringLength(maximumLength: 8, MinimumLength = 1)]
    public IsoMax8Text? AuthorisationCode { get; init; }

    /// <summary>
    /// Acquirer has requested a contact to the maintenance host.
    /// </summary>
    [IsoId("_nQsWx07LEeyGi9JAv6wq7Q")]
    [DisplayName("TMS Trigger")]
    [IsoXmlTag("TMSTrggr")]
    public TMSTrigger1? TMSTrigger { get; init; }
}
