// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Data to request a stored value service (prepaid card or account).
/// </summary>
[IsoId("_AssuIbZZEfCUZfsQO4rYeA")]
[DisplayName("Stored Value Request9")]
public record StoredValueRequest9
{
    [IsoId("_AtnUJbZZEfCUZfsQO4rYeA")]
    [DisplayName("Sale Transaction Identification")]
    [IsoXmlTag("SaleTxId")]
    public TransactionIdentifier1? SaleTransactionIdentification { get; init; }

    [IsoId("_AtnUK7ZZEfCUZfsQO4rYeA")]
    [DisplayName("Data")]
    [IsoXmlTag("Data")]
    [MinLength(1)]
    public ValueList<StoredValueData9> Data { get; init; } = [];
}
