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
[IsoId("_zv6LYYN2EeuHqfO1LgkE9Q")]
[DisplayName("Context")]
public record Context12
{
    /// <summary>
    /// Context of the card payment transaction at the point of service.
    /// </summary>
    [IsoId("_z0YbsYN2EeuHqfO1LgkE9Q")]
    [DisplayName("Point Of Service Context")]
    [IsoXmlTag("PtOfSvcCntxt")]
    public PointOfServiceContext3? PointOfServiceContext { get; init; }

    /// <summary>
    /// Context of the card payment transaction.
    /// </summary>
    [IsoId("_z0Ybs4N2EeuHqfO1LgkE9Q")]
    [DisplayName("Transaction Context")]
    [IsoXmlTag("TxCntxt")]
    public required TransactionContext7 TransactionContext { get; init; }

    /// <summary>
    /// Method and data intended to be used for this transaction in order to authenticate or verify  the cardholder or his card.
    /// </summary>
    [IsoId("_z0YbtYN2EeuHqfO1LgkE9Q")]
    [DisplayName("Verification")]
    [IsoXmlTag("Vrfctn")]
    public Verification4? Verification { get; init; }

    /// <summary>
    /// Context of risk associated with the transaction.
    /// </summary>
    [IsoId("_z0Ybt4N2EeuHqfO1LgkE9Q")]
    [DisplayName("Risk Context")]
    [IsoXmlTag("RskCntxt")]
    public RiskContext2? RiskContext { get; init; }

    /// <summary>
    /// Context of the sale associated with the card payment transaction.
    /// </summary>
    [IsoId("_z0YbuYN2EeuHqfO1LgkE9Q")]
    [DisplayName("Sale Context")]
    [IsoXmlTag("SaleCntxt")]
    public SaleContext8? SaleContext { get; init; }
}
