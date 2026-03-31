// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to the acknowledgement of an ATM reconciliation from the ATM. manager.
/// </summary>
[IsoId("_WK71Qa48EeWRfYPBaeOY8w")]
[DisplayName("ATM Reconciliation Acknowledgement")]
public record ATMReconciliationAcknowledgement2
{
    /// <summary>
    /// ATM information.
    /// </summary>
    [IsoId("_WWu1ka48EeWRfYPBaeOY8w")]
    [DisplayName("ATM")]
    [IsoXmlTag("ATM")]
    public required AutomatedTellerMachine3 ATM { get; init; }

    /// <summary>
    /// Information about the reconciliation response.
    /// </summary>
    [IsoId("_WWu1k648EeWRfYPBaeOY8w")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public required ATMTransaction26 Transaction { get; init; }
}
