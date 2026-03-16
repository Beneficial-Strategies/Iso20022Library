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
[IsoId("_kbmnYd52EeeCre2qFaLC2A")]
[DisplayName("Acceptor Diagnostic Response")]
public record AcceptorDiagnosticResponse5
{
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_kldG8d52EeeCre2qFaLC2A")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required CardPaymentEnvironment71 Environment { get; init; }

    /// <summary>
    /// Instructions for contacting the terminal management host.
    /// </summary>
    [IsoId("_kldG8952EeeCre2qFaLC2A")]
    [DisplayName("TMS Trigger")]
    [IsoXmlTag("TMSTrggr")]
    public TMSTrigger1? TMSTrigger { get; init; }
}
