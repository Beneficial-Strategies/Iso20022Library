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
[IsoId("_29ZaIcSoEeuBjv5G5kw00g")]
[DisplayName("Context")]
public record Context14
{
    /// <summary>
    /// Context of the card payment transaction at the point of service.
    /// </summary>
    [IsoId("_3C6zUcSoEeuBjv5G5kw00g")]
    [DisplayName("Point Of Service Context")]
    [IsoXmlTag("PtOfSvcCntxt")]
    public PointOfServiceContext5? PointOfServiceContext { get; init; }

    /// <summary>
    /// Context of the card payment transaction.
    /// </summary>
    [IsoId("_3C6zU8SoEeuBjv5G5kw00g")]
    [DisplayName("Transaction Context")]
    [IsoXmlTag("TxCntxt")]
    public TransactionContext9? TransactionContext { get; init; }
}
