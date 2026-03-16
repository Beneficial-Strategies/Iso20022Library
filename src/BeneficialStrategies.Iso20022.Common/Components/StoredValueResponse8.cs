// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Stored Value Response8.
/// </summary>
[IsoId("_sfgOoaEPEe-MRKYsaX6JDg")]
[DisplayName("Stored Value Response8")]
public record StoredValueResponse8
{
    /// <summary>
    /// POI Transaction Identification.
    /// </summary>
    [DisplayName("POI Transaction Identification")]
    [IsoXmlTag("POITxId")]
    public required TransactionIdentifier1 POITransactionIdentification { get; init; }

    /// <summary>
    /// Receipt.
    /// </summary>
    [DisplayName("Receipt")]
    [IsoXmlTag("Rct")]
    public ValueList<PaymentReceipt6> Receipt { get; init; } = [];

    /// <summary>
    /// Result.
    /// </summary>
    [DisplayName("Result")]
    [IsoXmlTag("Rslt")]
    public ValueList<StoredValueData8> Result { get; init; } = [];

    /// <summary>
    /// Sale Transaction Identification.
    /// </summary>
    [DisplayName("Sale Transaction Identification")]
    [IsoXmlTag("SaleTxId")]
    public TransactionIdentifier1? SaleTransactionIdentification { get; init; }
}
