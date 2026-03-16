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
[IsoId("_qDPEQEbWEeeIjf8aP9KbJA")]
[DisplayName("Context")]
public record Context1
{
    /// <summary>
    /// Contains point of interaction information specific to a given transaction that may change from transaction to transaction.
    /// </summary>
    [IsoId("_8Q-nEEbWEeeIjf8aP9KbJA")]
    [DisplayName("Point Of Service Context")]
    [IsoXmlTag("PtOfSvcCntxt")]
    public required PointOfServiceContext1 PointOfServiceContext { get; init; }

    /// <summary>
    /// Context of the card payment transaction.
    /// </summary>
    [IsoId("_G7Y7UEbXEeeIjf8aP9KbJA")]
    [DisplayName("Transaction Context")]
    [IsoXmlTag("TxCntxt")]
    public required TransactionContext1 TransactionContext { get; init; }

    /// <summary>
    /// Contain validation result and/or data to be validated.
    /// </summary>
    [IsoId("_kSCoEEbeEeeIjf8aP9KbJA")]
    [DisplayName("Verification")]
    [IsoXmlTag("Vrfctn")]
    public Verification1? Verification { get; init; }

    /// <summary>
    /// Context of risk associated with the transaction.
    /// </summary>
    [IsoId("_uRO1EEbeEeeIjf8aP9KbJA")]
    [DisplayName("Risk Context")]
    [IsoXmlTag("RskCntxt")]
    public RiskContext1? RiskContext { get; init; }

    /// <summary>
    /// Context of the sale associated with the card payment transaction.
    /// </summary>
    [IsoId("_6W8CoEbeEeeIjf8aP9KbJA")]
    [DisplayName("Sale Context")]
    [IsoXmlTag("SaleCntxt")]
    public SaleContext7? SaleContext { get; init; }
}
