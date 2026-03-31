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
[IsoId("_TFi5egEcEeCQm6a_G2yO_w_-873337121")]
[DisplayName("Card Payment Transaction Result")]
public record CardPaymentTransactionResult1
{
    /// <summary>
    /// Type of party that has delivered or declined the card payment authorisation (the party is not identified).
    /// </summary>
    [IsoId("_TFi5ewEcEeCQm6a_G2yO_w_-1313656436")]
    [DisplayName("Authorisation Entity")]
    [IsoXmlTag("AuthstnNtty")]
    public GenericIdentification33? AuthorisationEntity { get; init; }

    /// <summary>
    /// Response to an authorisation from the acquirer.
    /// </summary>
    [IsoId("_TFi5fAEcEeCQm6a_G2yO_w_-1341326750")]
    [DisplayName("Response To Authorisation")]
    [IsoXmlTag("RspnToAuthstn")]
    public required ResponseType1 ResponseToAuthorisation { get; init; }

    /// <summary>
    /// Value assigned by the authorising party.
    /// </summary>
    [IsoId("_TFi5fQEcEeCQm6a_G2yO_w_-100256564")]
    [DisplayName("Authorisation Code")]
    [IsoXmlTag("AuthstnCd")]
    [IsoSimpleType(IsoSimpleType.Min6Max8Text)]
    [StringLength(maximumLength: 8, MinimumLength = 6)]
    public IsoMin6Max8Text? AuthorisationCode { get; init; }
}
