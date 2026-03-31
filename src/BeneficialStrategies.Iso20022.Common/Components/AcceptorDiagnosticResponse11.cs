// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Acceptor Diagnostic Response11.
/// </summary>
[IsoId("_GMwM8aExEe-MRKYsaX6JDg")]
[DisplayName("Acceptor Diagnostic Response11")]
public record AcceptorDiagnosticResponse11
{
    /// <summary>
    /// Acquirer Available.
    /// </summary>
    [DisplayName("Acquirer Available")]
    [IsoXmlTag("AcqrrAvlbl")]
    public IsoTrueFalseIndicator? AcquirerAvailable { get; init; }

    /// <summary>
    /// Environment.
    /// </summary>
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required CardPaymentEnvironment81 Environment { get; init; }

    /// <summary>
    /// TMS Trigger.
    /// </summary>
    [DisplayName("TMS Trigger")]
    [IsoXmlTag("TMSTrggr")]
    public TMSTrigger1? TMSTrigger { get; init; }
}
