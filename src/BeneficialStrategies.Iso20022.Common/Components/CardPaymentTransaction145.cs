// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Card Payment Transaction145.
/// </summary>
[IsoId("_yyK38Z-NEe-nbM0aSPcoiQ")]
[DisplayName("Card Payment Transaction145")]
public record CardPaymentTransaction145
{
    /// <summary>
    /// Action.
    /// </summary>
    [DisplayName("Action")]
    [IsoXmlTag("Actn")]
    public ValueList<Action17> Action { get; init; } = [];

    /// <summary>
    /// Authorisation Result.
    /// </summary>
    [DisplayName("Authorisation Result")]
    [IsoXmlTag("AuthstnRslt")]
    public required AuthorisationResult19 AuthorisationResult { get; init; }
}
