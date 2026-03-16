// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Cancellation response from the acquirer.
/// </summary>
[IsoId("_TEDrugEcEeCQm6a_G2yO_w_-717692170")]
[DisplayName("Card Payment Transaction")]
public record CardPaymentTransaction10
{
    /// <summary>
    /// Outcome of the authorisation, and actions to perform.
    /// </summary>
    [IsoId("_TEDruwEcEeCQm6a_G2yO_w_1135492643")]
    [DisplayName("Authorisation Result")]
    [IsoXmlTag("AuthstnRslt")]
    public required AuthorisationResult1 AuthorisationResult { get; init; }

    /// <summary>
    /// Set of actions to be performed by the POI (Point Of Interaction) system.
    /// </summary>
    [IsoId("_TEDrvAEcEeCQm6a_G2yO_w_-708376346")]
    [DisplayName("Action")]
    [IsoXmlTag("Actn")]
    public Action1? Action { get; init; }
}
