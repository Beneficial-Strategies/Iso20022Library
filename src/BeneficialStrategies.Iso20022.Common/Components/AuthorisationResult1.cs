// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Outcome of the authorisation, and actions to perform.
/// </summary>
[IsoId("_TFZvhAEcEeCQm6a_G2yO_w_615383951")]
[DisplayName("Authorisation Result")]
public record AuthorisationResult1
{
    /// <summary>
    /// Type of party that has delivered or declined the card payment authorisation (the party is not identified).
    /// </summary>
    [IsoId("_TFZvhQEcEeCQm6a_G2yO_w_-317652280")]
    [DisplayName("Authorisation Entity")]
    [IsoXmlTag("AuthstnNtty")]
    public GenericIdentification33? AuthorisationEntity { get; init; }

    /// <summary>
    /// Response to an authorisation request.
    /// </summary>
    [IsoId("_TFZvhgEcEeCQm6a_G2yO_w_353257828")]
    [DisplayName("Response To Authorisation")]
    [IsoXmlTag("RspnToAuthstn")]
    public required ResponseType1 ResponseToAuthorisation { get; init; }

    /// <summary>
    /// Value assigned by the authorising party.
    /// </summary>
    [IsoId("_TFZvhwEcEeCQm6a_G2yO_w_-951584415")]
    [DisplayName("Authorisation Code")]
    [IsoXmlTag("AuthstnCd")]
    [IsoSimpleType(IsoSimpleType.Min6Max8Text)]
    [StringLength(maximumLength: 8, MinimumLength = 6)]
    public IsoMin6Max8Text? AuthorisationCode { get; init; }

    /// <summary>
    /// Indicates whether the acquirer requires a further exchange completion after the completion of the transaction.
    /// </summary>
    [IsoId("_TFZviAEcEeCQm6a_G2yO_w_687085502")]
    [DisplayName("Completion Required")]
    [IsoXmlTag("CmpltnReqrd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? CompletionRequired { get; init; }

    /// <summary>
    /// Instructs the point of interaction (POI) how to contact the host to initiate the maintenance of the terminal.
    /// </summary>
    [IsoId("_TFZviQEcEeCQm6a_G2yO_w_-1710398253")]
    [DisplayName("TMS Trigger")]
    [IsoXmlTag("TMSTrggr")]
    public TMSTrigger1? TMSTrigger { get; init; }
}
