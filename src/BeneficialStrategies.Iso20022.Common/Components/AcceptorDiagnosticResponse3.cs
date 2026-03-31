// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Diagnostic response from the acquirer.
/// </summary>
[IsoId("_jVPTETTbEeO5e9wx3yvd8g")]
[DisplayName("Acceptor Diagnostic Response")]
public record AcceptorDiagnosticResponse3
{
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_jlKlcTTbEeO5e9wx3yvd8g")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required CardPaymentEnvironment31 Environment { get; init; }

    /// <summary>
    /// Instructions for contacting the terminal management host.
    /// </summary>
    [IsoId("_jlKlczTbEeO5e9wx3yvd8g")]
    [DisplayName("TMS Trigger")]
    [IsoXmlTag("TMSTrggr")]
    public TMSTrigger1? TMSTrigger { get; init; }
}
