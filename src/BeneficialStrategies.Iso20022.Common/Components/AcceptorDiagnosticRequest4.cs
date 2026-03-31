// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Diagnostic request from an acceptor.
/// </summary>
[IsoId("_VliDEWpAEeS4VPLpYyQgxQ")]
[DisplayName("Acceptor Diagnostic Request")]
public record AcceptorDiagnosticRequest4
{
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_WA8zwWpAEeS4VPLpYyQgxQ")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required CardPaymentEnvironment42 Environment { get; init; }
}
