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
[IsoId("_CPt2gS5JEeunNvJlR_vCbg")]
[DisplayName("Acceptor Diagnostic Response")]
public record AcceptorDiagnosticResponse7
{
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_CdvEYS5JEeunNvJlR_vCbg")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required CardPaymentEnvironment77 Environment { get; init; }

    /// <summary>
    /// Instructions for contacting the terminal management host.
    /// </summary>
    [IsoId("_CdvEYy5JEeunNvJlR_vCbg")]
    [DisplayName("TMS Trigger")]
    [IsoXmlTag("TMSTrggr")]
    public TMSTrigger1? TMSTrigger { get; init; }

    /// <summary>
    /// Indicates if the acquirer is available.
    /// </summary>
    [IsoId("_CdvEZS5JEeunNvJlR_vCbg")]
    [DisplayName("Acquirer Available")]
    [IsoXmlTag("AcqrrAvlbl")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? AcquirerAvailable { get; init; }
}
