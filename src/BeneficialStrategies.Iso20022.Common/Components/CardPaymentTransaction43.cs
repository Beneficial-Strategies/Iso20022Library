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
[IsoId("_e6UdsWl7EeSQMKir9owD5A")]
[DisplayName("Card Payment Transaction")]
public record CardPaymentTransaction43
{
    /// <summary>
    /// Outcome of the authorisation, and actions to perform.
    /// </summary>
    [IsoId("_fHbFkWl7EeSQMKir9owD5A")]
    [DisplayName("Authorisation Result")]
    [IsoXmlTag("AuthstnRslt")]
    public required AuthorisationResult6 AuthorisationResult { get; init; }

    /// <summary>
    /// Set of actions to be performed by the POI (Point Of Interaction) system.
    /// </summary>
    [IsoId("_fHbFk2l7EeSQMKir9owD5A")]
    [DisplayName("Action")]
    [IsoXmlTag("Actn")]
    public ValueList<Action3> Action { get; init; } = [];
}
