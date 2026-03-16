// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to the acknowledgement of an ATM deposit transaction from the ATM manager.
/// </summary>
[IsoId("_tSpmQK4REeWZgJQOa6iKCQ")]
[DisplayName("ATM Deposit Completion Acknowledgement")]
public record ATMDepositCompletionAcknowledgement1
{
    /// <summary>
    /// ATM information.
    /// </summary>
    [IsoId("_1tCYoK4REeWZgJQOa6iKCQ")]
    [DisplayName("ATM")]
    [IsoXmlTag("ATM")]
    public required AutomatedTellerMachine3 ATM { get; init; }

    /// <summary>
    /// Context in which the transaction is performed.
    /// </summary>
    [IsoId("_5XAwAK4REeWZgJQOa6iKCQ")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public required ATMContext12 Context { get; init; }

    /// <summary>
    /// Acknowledgement of the deposit completion advice.
    /// </summary>
    [IsoId("_84f5wK4REeWZgJQOa6iKCQ")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public required ATMTransaction18 Transaction { get; init; }
}
