// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to the completion of an operation on the ATM.
/// </summary>
[IsoId("_THx_Ya4SEeWZgJQOa6iKCQ")]
[DisplayName("ATM Completion Advice")]
public record ATMCompletionAdvice2
{
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_TS0Ksa4SEeWZgJQOa6iKCQ")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required ATMEnvironment13 Environment { get; init; }

    /// <summary>
    /// Context in which the transaction is performed.
    /// </summary>
    [IsoId("_TS0Ks64SEeWZgJQOa6iKCQ")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public required ATMContext13 Context { get; init; }

    /// <summary>
    /// Transaction for which the completion is sent.
    /// </summary>
    [IsoId("_TS0Kta4SEeWZgJQOa6iKCQ")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public required ATMTransaction20 Transaction { get; init; }
}
