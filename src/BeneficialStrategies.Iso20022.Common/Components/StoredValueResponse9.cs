// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Response data to a stored value request.
/// </summary>
[IsoId("_0pUJ4bZaEfCUZfsQO4rYeA")]
[DisplayName("Stored Value Response9")]
public record StoredValueResponse9
{
    [IsoId("_0qOI1bZaEfCUZfsQO4rYeA")]
    [DisplayName("Sale Transaction Identification")]
    [IsoXmlTag("SaleTxId")]
    public TransactionIdentifier1? SaleTransactionIdentification { get; init; }

    [IsoId("_0qOI27ZaEfCUZfsQO4rYeA")]
    [DisplayName("POI Transaction Identification")]
    [IsoXmlTag("POITxId")]
    public required TransactionIdentifier1 POITransactionIdentification { get; init; }

    [IsoId("_0qOI4bZaEfCUZfsQO4rYeA")]
    [DisplayName("Result")]
    [IsoXmlTag("Rslt")]
    public ValueList<StoredValueData9> Result { get; init; } = [];

    [IsoId("_0qOI57ZaEfCUZfsQO4rYeA")]
    [DisplayName("Receipt")]
    [IsoXmlTag("Rct")]
    public ValueList<PaymentReceipt7> Receipt { get; init; } = [];
}
