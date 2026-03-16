// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Context in which the card payment transaction is performed.
/// </summary>
[IsoId("_axPQ8cSpEeuBjv5G5kw00g")]
[DisplayName("Context")]
public record Context15
{
    /// <summary>
    /// Context of the card payment transaction at the point of service.
    /// </summary>
    [IsoId("_a20UgcSpEeuBjv5G5kw00g")]
    [DisplayName("Point Of Service Context")]
    [IsoXmlTag("PtOfSvcCntxt")]
    public PointOfServiceContext5? PointOfServiceContext { get; init; }

    /// <summary>
    /// Context of the transaction.
    /// </summary>
    [IsoId("_a20Ug8SpEeuBjv5G5kw00g")]
    [DisplayName("Transaction Context")]
    [IsoXmlTag("TxCntxt")]
    public required TransactionContext8 TransactionContext { get; init; }

    /// <summary>
    /// Context of the sale associated with the card payment transaction.
    /// </summary>
    [IsoId("_a20UhcSpEeuBjv5G5kw00g")]
    [DisplayName("Sale Context")]
    [IsoXmlTag("SaleCntxt")]
    public SaleContext8? SaleContext { get; init; }
}
