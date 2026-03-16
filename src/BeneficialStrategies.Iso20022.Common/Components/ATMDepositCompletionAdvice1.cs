// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to the completion of a deposit transaction on the ATM.
/// </summary>
[IsoId("_YiR2AK4OEeWZgJQOa6iKCQ")]
[DisplayName("ATM Deposit Completion Advice")]
public record ATMDepositCompletionAdvice1
{
    /// <summary>
    /// Environment of the deposit transaction.
    /// </summary>
    [IsoId("_gxRQsK4OEeWZgJQOa6iKCQ")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required ATMEnvironment13 Environment { get; init; }

    /// <summary>
    /// Context in which the transaction is performed.
    /// </summary>
    [IsoId("_nyYjAK4OEeWZgJQOa6iKCQ")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public required ATMContext12 Context { get; init; }

    /// <summary>
    /// Deposit transaction for which the completion is sent.
    /// </summary>
    [IsoId("_S1EmIK4PEeWZgJQOa6iKCQ")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public required ATMTransaction19 Transaction { get; init; }
}
