// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// ATM Completion Acknowledgement3.
/// </summary>
[IsoId("_3BbREaEWEe-MRKYsaX6JDg")]
[DisplayName("ATM Completion Acknowledgement3")]
public record ATMCompletionAcknowledgement3
{
    /// <summary>
    /// ATM.
    /// </summary>
    [DisplayName("ATM")]
    [IsoXmlTag("ATM")]
    public required AutomatedTellerMachine3 ATM { get; init; }

    /// <summary>
    /// Context.
    /// </summary>
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public required ATMContext13 Context { get; init; }

    /// <summary>
    /// Transaction.
    /// </summary>
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public required ATMTransaction45 Transaction { get; init; }
}
