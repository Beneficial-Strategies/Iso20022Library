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
[IsoId("_KEpmwXJ4Ee299ZbWCkdR_w")]
[DisplayName("Acceptor Diagnostic Response")]
public record AcceptorDiagnosticResponse9
{
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_KK-4QXJ4Ee299ZbWCkdR_w")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required CardPaymentEnvironment79 Environment { get; init; }

    /// <summary>
    /// Instructions for contacting the terminal management host.
    /// </summary>
    [IsoId("_KK-4Q3J4Ee299ZbWCkdR_w")]
    [DisplayName("TMS Trigger")]
    [IsoXmlTag("TMSTrggr")]
    public TMSTrigger1? TMSTrigger { get; init; }

    /// <summary>
    /// Indicates if the acquirer is available.
    /// </summary>
    [IsoId("_KK-4RXJ4Ee299ZbWCkdR_w")]
    [DisplayName("Acquirer Available")]
    [IsoXmlTag("AcqrrAvlbl")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? AcquirerAvailable { get; init; }
}
