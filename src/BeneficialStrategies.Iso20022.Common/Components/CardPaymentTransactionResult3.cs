// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Result of the transaction.
/// </summary>
[IsoId("_gqp5kY0YEeWRYffwL7E13A")]
[DisplayName("Card Payment Transaction Result")]
public record CardPaymentTransactionResult3
{
    /// <summary>
    /// Type of party that has delivered or declined the card payment authorisation (the party is not identified).
    /// </summary>
    [IsoId("_g11O0Y0YEeWRYffwL7E13A")]
    [DisplayName("Authorisation Entity")]
    [IsoXmlTag("AuthstnNtty")]
    public GenericIdentification90? AuthorisationEntity { get; init; }

    /// <summary>
    /// Response to an authorisation from the acquirer.
    /// </summary>
    [IsoId("_g11O040YEeWRYffwL7E13A")]
    [DisplayName("Response To Authorisation")]
    [IsoXmlTag("RspnToAuthstn")]
    public required ResponseType5 ResponseToAuthorisation { get; init; }

    /// <summary>
    /// Value assigned by the authorising party.
    /// </summary>
    [IsoId("_g11O1Y0YEeWRYffwL7E13A")]
    [DisplayName("Authorisation Code")]
    [IsoXmlTag("AuthstnCd")]
    [IsoSimpleType(IsoSimpleType.Min6Max8Text)]
    [StringLength(maximumLength: 8, MinimumLength = 6)]
    public IsoMin6Max8Text? AuthorisationCode { get; init; }
}
