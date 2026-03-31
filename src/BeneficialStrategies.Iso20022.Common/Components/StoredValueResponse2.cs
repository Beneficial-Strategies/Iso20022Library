// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Response data to a Stored Value request.
/// </summary>
[IsoId("_FW05gYYMEemxIqbaFEE8-w")]
[DisplayName("Stored Value Response")]
public record StoredValueResponse2
{
    /// <summary>
    /// Unique identification of a POI transaction.
    /// </summary>
    [IsoId("_FhPZwYYMEemxIqbaFEE8-w")]
    [DisplayName("POI Transaction Identification")]
    [IsoXmlTag("POITxId")]
    public required TransactionIdentifier1 POITransactionIdentification { get; init; }

    /// <summary>
    /// Result of loading/reloading a stored value card.
    /// </summary>
    [IsoId("_FhPZw4YMEemxIqbaFEE8-w")]
    [DisplayName("Result")]
    [IsoXmlTag("Rslt")]
    public ValueList<StoredValueData2> Result { get; init; } = [];

    /// <summary>
    /// Customer or Merchant payment receipt.
    /// </summary>
    [IsoId("_FhPZxYYMEemxIqbaFEE8-w")]
    [DisplayName("Receipt")]
    [IsoXmlTag("Rct")]
    public ValueList<PaymentReceipt1> Receipt { get; init; } = [];
}
