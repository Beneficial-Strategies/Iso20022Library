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
[IsoId("_Svo65gEcEeCQm6a_G2yO_w_1020149770")]
[DisplayName("Acceptor Diagnostic Request")]
public record AcceptorDiagnosticRequest1
{
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_Svo65wEcEeCQm6a_G2yO_w_1698681798")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required CardPaymentEnvironment8 Environment { get; init; }
}
