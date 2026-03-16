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
[IsoId("_tdRDod8PEeeNTcLLmuYy-w")]
[DisplayName("Context")]
public record Context5
{
    /// <summary>
    /// Context of the card payment transaction at the point of service.
    /// </summary>
    [IsoId("_tsa58d8PEeeNTcLLmuYy-w")]
    [DisplayName("Point Of Service Context")]
    [IsoXmlTag("PtOfSvcCntxt")]
    public required PointOfServiceContext1 PointOfServiceContext { get; init; }

    /// <summary>
    /// Context of the card payment transaction.
    /// </summary>
    [IsoId("_tsa5898PEeeNTcLLmuYy-w")]
    [DisplayName("Transaction Context")]
    [IsoXmlTag("TxCntxt")]
    public required TransactionContext1 TransactionContext { get; init; }

    /// <summary>
    /// Method and data intended to be used for this transaction in order to authenticate or verify the cardholder or his card.
    /// </summary>
    [IsoId("_tsa59d8PEeeNTcLLmuYy-w")]
    [DisplayName("Verification")]
    [IsoXmlTag("Vrfctn")]
    public Verification1? Verification { get; init; }

    /// <summary>
    /// Context of risk associated with the transaction.
    /// </summary>
    [IsoId("_tsa5998PEeeNTcLLmuYy-w")]
    [DisplayName("Risk Context")]
    [IsoXmlTag("RskCntxt")]
    public RiskContext1? RiskContext { get; init; }
}
