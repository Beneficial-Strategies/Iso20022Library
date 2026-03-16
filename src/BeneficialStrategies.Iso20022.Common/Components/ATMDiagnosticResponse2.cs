// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to the response of a diagnostic from an ATM manager.
/// </summary>
[IsoId("_qaE6Aa46EeWRfYPBaeOY8w")]
[DisplayName("ATM Diagnostic Response")]
public record ATMDiagnosticResponse2
{
    /// <summary>
    /// Environment of the ATM.
    /// </summary>
    [IsoId("_qlQPQa46EeWRfYPBaeOY8w")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required ATMEnvironment6 Environment { get; init; }

    /// <summary>
    /// Maintenance command to perform on the ATM.
    /// </summary>
    [IsoId("_qlQPQ646EeWRfYPBaeOY8w")]
    [DisplayName("Command")]
    [IsoXmlTag("Cmd")]
    public ValueList<ATMCommand7> Command { get; init; } = [];
}
