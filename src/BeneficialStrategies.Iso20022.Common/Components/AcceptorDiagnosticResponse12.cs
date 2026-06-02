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
[IsoId("_Mzrg8bX_EfCUZfsQO4rYeA")]
[DisplayName("Acceptor Diagnostic Response12")]
public record AcceptorDiagnosticResponse12
{
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_M0v39bX_EfCUZfsQO4rYeA")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required CardPaymentEnvironment82 Environment { get; init; }

    /// <summary>
    /// Instructions for contacting the terminal management host.
    /// </summary>
    [IsoId("_M0v3-7X_EfCUZfsQO4rYeA")]
    [DisplayName("TMS Trigger")]
    [IsoXmlTag("TMSTrggr")]
    public TMSTrigger1? TMSTrigger { get; init; }

    /// <summary>
    /// Indicates if the acquirer is available.
    /// </summary>
    [IsoId("_M0v4AbX_EfCUZfsQO4rYeA")]
    [DisplayName("Acquirer Available")]
    [IsoXmlTag("AcqrrAvlbl")]
    public IsoTrueFalseIndicator? AcquirerAvailable { get; init; }
}
