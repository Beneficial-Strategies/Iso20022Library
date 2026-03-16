// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to the response of an ATM PIN Management from an ATM manager.
/// </summary>
[IsoId("_-b5YgIrBEeSgLpgNvMAP2g")]
[DisplayName("ATMPIN Management Response")]
public record ATMPINManagementResponse1
{
    /// <summary>
    /// Environment of the PIN management transaction.
    /// </summary>
    [IsoId("_QrFs0IrCEeSgLpgNvMAP2g")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required ATMEnvironment2 Environment { get; init; }

    /// <summary>
    /// Context in which the transaction is performed.
    /// </summary>
    [IsoId("_fDG7QIrCEeSgLpgNvMAP2g")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public required ATMContext4 Context { get; init; }

    /// <summary>
    /// Response to the PIN management transaction.
    /// </summary>
    [IsoId("_c34kYIrDEeSgLpgNvMAP2g")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public required ATMTransaction10 Transaction { get; init; }
}
