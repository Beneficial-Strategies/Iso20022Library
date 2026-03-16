// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Outcome of the withdrawal authorisation.
/// </summary>
[IsoId("_TJtuMYp8EeS3NqNpgnMh2w")]
[DisplayName("Authorisation Result")]
public record AuthorisationResult9
{
    /// <summary>
    /// Type of party that has delivered or declined the card payment authorisation (the party is not identified).
    /// </summary>
    [IsoId("_TWFWQYp8EeS3NqNpgnMh2w")]
    [DisplayName("Authorisation Entity")]
    [IsoXmlTag("AuthstnNtty")]
    public PartyType13Code? AuthorisationEntity { get; init; }

    /// <summary>
    /// Result of the authorisation.
    /// </summary>
    [IsoId("_98hTgIqCEeS3NqNpgnMh2w")]
    [DisplayName("Authorisation Response")]
    [IsoXmlTag("AuthstnRspn")]
    public required ResponseType3 AuthorisationResponse { get; init; }

    /// <summary>
    /// Trace of response by the entities in the path from the issuer to the ATM.
    /// </summary>
    [IsoId("_0Kuz4IqDEeS3NqNpgnMh2w")]
    [DisplayName("Response Trace")]
    [IsoXmlTag("RspnTrac")]
    public ResponseType4? ResponseTrace { get; init; }

    /// <summary>
    /// Value assigned by the authorising party.
    /// </summary>
    [IsoId("_TWFWR4p8EeS3NqNpgnMh2w")]
    [DisplayName("Authorisation Code")]
    [IsoXmlTag("AuthstnCd")]
    [IsoSimpleType(IsoSimpleType.Min6Max8Text)]
    [StringLength(maximumLength: 8, MinimumLength = 6)]
    public IsoMin6Max8Text? AuthorisationCode { get; init; }

    /// <summary>
    /// Sequence of actions to be performed by the ATM to complete the transaction.
    /// </summary>
    [IsoId("_TWFWRYp8EeS3NqNpgnMh2w")]
    [DisplayName("Action")]
    [IsoXmlTag("Actn")]
    public Action5? Action { get; init; }
}
