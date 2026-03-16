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
[IsoId("_eDmqETTKEeO5e9wx3yvd8g")]
[DisplayName("Acceptor Diagnostic Request")]
public record AcceptorDiagnosticRequest3
{
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_eSokkTTKEeO5e9wx3yvd8g")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required CardPaymentEnvironment29 Environment { get; init; }
}
