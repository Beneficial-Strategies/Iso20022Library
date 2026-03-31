// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to the acknowledgement of an ATM exception.
/// </summary>
[IsoId("_slQhsK5GEeWCgYcWSNgX5g")]
[DisplayName("ATM Exception Acknowledgement")]
public record ATMExceptionAcknowledgement1
{
    /// <summary>
    /// ATM information.
    /// </summary>
    [IsoId("_1PZnUK5GEeWCgYcWSNgX5g")]
    [DisplayName("ATM")]
    [IsoXmlTag("ATM")]
    public required AutomatedTellerMachine3 ATM { get; init; }

    /// <summary>
    /// Context in which the transaction is performed, if any.
    /// </summary>
    [IsoId("_7Ool4K5GEeWCgYcWSNgX5g")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public required ATMContext20 Context { get; init; }

    /// <summary>
    /// Acknowledgement of the exception advice.
    /// </summary>
    [IsoId("_DDzLUK5HEeWCgYcWSNgX5g")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public required ATMTransaction28 Transaction { get; init; }
}
