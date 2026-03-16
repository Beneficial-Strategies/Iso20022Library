// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// This component define the type of financial services to be used with this message of Reconciliation. There is only one service : ReconciliationRequest.
/// </summary>
[IsoId("_-gZIIQ1NEeqjM-rxn3HuXQ")]
[DisplayName("Reconciliation Request")]
public record ReconciliationRequest3
{
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_-sJFIQ1NEeqjM-rxn3HuXQ")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required CardPaymentEnvironment75 Environment { get; init; }

    /// <summary>
    /// Context in which the transaction is performed (payment and sale).
    /// </summary>
    [IsoId("_-sJFIw1NEeqjM-rxn3HuXQ")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public required CardPaymentContext28 Context { get; init; }

    /// <summary>
    /// Content of the Reconciliation Request message.
    /// </summary>
    [IsoId("_-sJFJQ1NEeqjM-rxn3HuXQ")]
    [DisplayName("Reconciliation Request Data")]
    [IsoXmlTag("RcncltnReqData")]
    public required ReconciliationRequestData1 ReconciliationRequestData { get; init; }

    /// <summary>
    /// Additional information incorporated as an extension to the message.
    /// </summary>
    [IsoId("_-sJFJw1NEeqjM-rxn3HuXQ")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
