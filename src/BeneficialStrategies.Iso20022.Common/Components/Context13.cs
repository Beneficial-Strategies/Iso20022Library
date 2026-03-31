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
[IsoId("_61__UahMEeuOaMA1YOy5YQ")]
[DisplayName("Context")]
public record Context13
{
    /// <summary>
    /// Contains point of interaction information specific to a given transaction that may change from transaction to transaction.
    /// </summary>
    [IsoId("_67DecahMEeuOaMA1YOy5YQ")]
    [DisplayName("Point Of Service Context")]
    [IsoXmlTag("PtOfSvcCntxt")]
    public PointOfServiceContext4? PointOfServiceContext { get; init; }

    /// <summary>
    /// Context of the card payment transaction.
    /// </summary>
    [IsoId("_67Dec6hMEeuOaMA1YOy5YQ")]
    [DisplayName("Transaction Context")]
    [IsoXmlTag("TxCntxt")]
    public TransactionContext8? TransactionContext { get; init; }

    /// <summary>
    /// Method and data intended to be used for this transaction in order to authenticate or verify  the cardholder or his card.
    /// </summary>
    [IsoId("_67DedahMEeuOaMA1YOy5YQ")]
    [DisplayName("Verification")]
    [IsoXmlTag("Vrfctn")]
    public ValueList<Verification4> Verification { get; init; } = [];

    /// <summary>
    /// Context of risk associated with the transaction.
    /// </summary>
    [IsoId("_67Ded6hMEeuOaMA1YOy5YQ")]
    [DisplayName("Risk Context")]
    [IsoXmlTag("RskCntxt")]
    public RiskContext2? RiskContext { get; init; }
}
