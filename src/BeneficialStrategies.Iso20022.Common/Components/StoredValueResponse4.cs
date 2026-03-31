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
[IsoId("_JvBDUS8-Eeu125Ip9zFcsQ")]
[DisplayName("Stored Value Response")]
public record StoredValueResponse4
{
    /// <summary>
    /// Unique identification of a POI transaction.
    /// </summary>
    [IsoId("_J8FO8S8-Eeu125Ip9zFcsQ")]
    [DisplayName("POI Transaction Identification")]
    [IsoXmlTag("POITxId")]
    public required TransactionIdentifier1 POITransactionIdentification { get; init; }

    /// <summary>
    /// Result of loading/reloading a stored value card.
    /// </summary>
    [IsoId("_J8FO8y8-Eeu125Ip9zFcsQ")]
    [DisplayName("Result")]
    [IsoXmlTag("Rslt")]
    public ValueList<StoredValueData4> Result { get; init; } = [];

    /// <summary>
    /// Customer or Merchant payment receipt.
    /// </summary>
    [IsoId("_J8FO9S8-Eeu125Ip9zFcsQ")]
    [DisplayName("Receipt")]
    [IsoXmlTag("Rct")]
    public ValueList<PaymentReceipt3> Receipt { get; init; } = [];
}
