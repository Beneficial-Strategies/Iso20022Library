// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to the response of an ATM withdrawal from an ATM manager.
/// </summary>
[IsoId("_UC0koIp1EeS3NqNpgnMh2w")]
[DisplayName("ATM Withdrawal Response")]
public record ATMWithdrawalResponse1
{
    /// <summary>
    /// Environment of the withdrawal transaction.
    /// </summary>
    [IsoId("_qfWcEIp1EeS3NqNpgnMh2w")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required ATMEnvironment2 Environment { get; init; }

    /// <summary>
    /// Context in which the transaction is performed.
    /// </summary>
    [IsoId("_TjIQkIp4EeS3NqNpgnMh2w")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public required ATMContext2 Context { get; init; }

    /// <summary>
    /// Response to the withdrawal transaction request.
    /// </summary>
    [IsoId("_5I70QIp4EeS3NqNpgnMh2w")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public required ATMTransaction2 Transaction { get; init; }
}
