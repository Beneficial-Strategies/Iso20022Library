// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Account Balance3.
/// </summary>
[IsoId("_rnyE4XjUEe6YlIMyoxWMJA")]
[DisplayName("Account Balance3")]
public record AccountBalance3
{
    /// <summary>
    /// Account Type.
    /// </summary>
    [DisplayName("Account Type")]
    [IsoXmlTag("AcctTp")]
    public required ISO8583AccountTypeCode AccountType { get; init; }

    /// <summary>
    /// Balance.
    /// </summary>
    [DisplayName("Balance")]
    [IsoXmlTag("Bal")]
    public ValueList<Balance29> Balance { get; init; } = [];
}
