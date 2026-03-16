// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Stored Value Request8.
/// </summary>
[IsoId("_7GOAYaEPEe-MRKYsaX6JDg")]
[DisplayName("Stored Value Request8")]
public record StoredValueRequest8
{
    /// <summary>
    /// Data.
    /// </summary>
    [DisplayName("Data")]
    [IsoXmlTag("Data")]
    public ValueList<StoredValueData8> Data { get; init; } = [];

    /// <summary>
    /// Sale Transaction Identification.
    /// </summary>
    [DisplayName("Sale Transaction Identification")]
    [IsoXmlTag("SaleTxId")]
    public TransactionIdentifier1? SaleTransactionIdentification { get; init; }
}
