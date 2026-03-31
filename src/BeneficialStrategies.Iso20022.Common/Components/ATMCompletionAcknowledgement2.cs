// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to the acknowledgement of an ATM completion from the ATM manager.
/// </summary>
[IsoId("_4MbhUa4TEeWZgJQOa6iKCQ")]
[DisplayName("ATM Completion Acknowledgement")]
public record ATMCompletionAcknowledgement2
{
    /// <summary>
    /// ATM information.
    /// </summary>
    [IsoId("_4W3Psa4TEeWZgJQOa6iKCQ")]
    [DisplayName("ATM")]
    [IsoXmlTag("ATM")]
    public required AutomatedTellerMachine3 ATM { get; init; }

    /// <summary>
    /// Context in which the transaction is performed.
    /// </summary>
    [IsoId("_4W3Ps64TEeWZgJQOa6iKCQ")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public required ATMContext13 Context { get; init; }

    /// <summary>
    /// Acknowledgement of the completion advice.
    /// </summary>
    [IsoId("_4W3Pta4TEeWZgJQOa6iKCQ")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public required ATMTransaction18 Transaction { get; init; }
}
