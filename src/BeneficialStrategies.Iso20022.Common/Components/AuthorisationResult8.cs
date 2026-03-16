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
[IsoId("_aTE8MXuXEeSVeNXcmBQ4hQ")]
[DisplayName("Authorisation Result")]
public record AuthorisationResult8
{
    /// <summary>
    /// Type of party that has delivered or declined the card payment authorisation (the party is not identified).
    /// </summary>
    [IsoId("_agVVEXuXEeSVeNXcmBQ4hQ")]
    [DisplayName("Authorisation Entity")]
    [IsoXmlTag("AuthstnNtty")]
    public GenericIdentification75? AuthorisationEntity { get; init; }

    /// <summary>
    /// Response to an authorisation request.
    /// </summary>
    [IsoId("_agVVE3uXEeSVeNXcmBQ4hQ")]
    [DisplayName("Transaction Response")]
    [IsoXmlTag("TxRspn")]
    public required ResponseType2 TransactionResponse { get; init; }

    /// <summary>
    /// Set of actions to be performed by the card acceptor.
    /// </summary>
    [IsoId("_EJ63QHuYEeSVeNXcmBQ4hQ")]
    [DisplayName("Action")]
    [IsoXmlTag("Actn")]
    public ValueList<Action4> Action { get; init; } = [];

    /// <summary>
    /// Value assigned by the authorising party.
    /// </summary>
    [IsoId("_agVVFXuXEeSVeNXcmBQ4hQ")]
    [DisplayName("Authorisation Code")]
    [IsoXmlTag("AuthstnCd")]
    [IsoSimpleType(IsoSimpleType.Min6Max8Text)]
    [StringLength(maximumLength: 8, MinimumLength = 6)]
    public IsoMin6Max8Text? AuthorisationCode { get; init; }

    /// <summary>
    /// Additional information relevant for the destination.
    /// </summary>
    [IsoId("_qE0V4C-tEeWfYucYWs4iQg")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public ValueList<ActionMessage3> AdditionalInformation { get; init; } = [];
}
