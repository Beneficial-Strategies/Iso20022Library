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
[IsoId("_l_QUoXJxEe299ZbWCkdR_w")]
[DisplayName("Card Payment Transaction")]
public record CardPaymentTransaction130
{
    /// <summary>
    /// Outcome of the authorisation, and actions to perform.
    /// </summary>
    [IsoId("_mFvXIXJxEe299ZbWCkdR_w")]
    [DisplayName("Authorisation Result")]
    [IsoXmlTag("AuthstnRslt")]
    public required AuthorisationResult19 AuthorisationResult { get; init; }

    /// <summary>
    /// Set of actions to be performed by the POI (Point Of Interaction) system.
    /// </summary>
    [IsoId("_mFvXI3JxEe299ZbWCkdR_w")]
    [DisplayName("Action")]
    [IsoXmlTag("Actn")]
    public ValueList<Action14> Action { get; init; } = [];
}
