// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Stored Value Request7.
/// </summary>
[IsoId("_f6FtkZLREe6-zvj9Dw-ctg")]
[DisplayName("Stored Value Request7")]
public record StoredValueRequest7
{
    /// <summary>
    /// Data.
    /// </summary>
    [DisplayName("Data")]
    [IsoXmlTag("Data")]
    public ValueList<StoredValueData7> Data { get; init; } = [];

    /// <summary>
    /// Sale Transaction Identification.
    /// </summary>
    [DisplayName("Sale Transaction Identification")]
    [IsoXmlTag("SaleTxId")]
    public TransactionIdentifier1? SaleTransactionIdentification { get; init; }
}
