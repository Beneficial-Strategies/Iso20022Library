// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Response data to a loyalty service request.
/// </summary>
[IsoId("_vPHvcU7XEeyGi9JAv6wq7Q")]
[DisplayName("Loyalty Response")]
public record LoyaltyResponse3
{
    /// <summary>
    /// Sale System identification of the transaction in an unambiguous way.
    /// </summary>
    [IsoId("_vVVsMU7XEeyGi9JAv6wq7Q")]
    [DisplayName("Sale Transaction Identification")]
    [IsoXmlTag("SaleTxId")]
    public required TransactionIdentifier1 SaleTransactionIdentification { get; init; }

    /// <summary>
    /// POI identification of the transaction in an unambiguous way.
    /// </summary>
    [IsoId("_vVVsM07XEeyGi9JAv6wq7Q")]
    [DisplayName("POI Transaction Identification")]
    [IsoXmlTag("POITxId")]
    public required TransactionIdentifier1 POITransactionIdentification { get; init; }

    /// <summary>
    /// Unique identification of the reconciliation period between the acceptor and the acquirer.
    /// </summary>
    [IsoId("_vVVsNU7XEeyGi9JAv6wq7Q")]
    [DisplayName("POI Reconciliation Identification")]
    [IsoXmlTag("POIRcncltnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? POIReconciliationIdentification { get; init; }

    /// <summary>
    /// Data related to the result of a processed loyalty transaction.
    /// </summary>
    [IsoId("_vVVsN07XEeyGi9JAv6wq7Q")]
    [DisplayName("Result")]
    [IsoXmlTag("Rslt")]
    public ValueList<LoyaltyResult3> Result { get; init; } = [];
}
