// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Balance of the account involved in the card transaction.
/// </summary>
[IsoId("_nRjgQRQUEfC1ZfCQz0xB3g")]
[DisplayName("Account Balance4")]
public record AccountBalance4
{
    /// <summary>
    /// Account for which a balance is sought.
    /// </summary>
    [IsoId("_nY-98RQUEfC1ZfCQz0xB3g")]
    [DisplayName("Account Type")]
    [IsoXmlTag("AcctTp")]
    public required ISO8583AccountTypeCode AccountType { get; init; }

    /// <summary>
    /// Balance of the account.
    /// </summary>
    [IsoId("_nY-9-RQUEfC1ZfCQz0xB3g")]
    [DisplayName("Balance")]
    [IsoXmlTag("Bal")]
    [MinLength(1)]
    public ValueList<CardAccountBalance1> Balance { get; init; } = [];
}
