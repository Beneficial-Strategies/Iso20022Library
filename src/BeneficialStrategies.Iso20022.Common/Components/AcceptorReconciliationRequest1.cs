// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Reconciliation request from an acceptor.
/// </summary>
[IsoId("_Svo64AEcEeCQm6a_G2yO_w_-2122811892")]
[DisplayName("Acceptor Reconciliation Request")]
public record AcceptorReconciliationRequest1
{
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_Svo64QEcEeCQm6a_G2yO_w_700251730")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required CardPaymentEnvironment7 Environment { get; init; }

    /// <summary>
    /// Reconciliation transaction between an acceptor an acquirer.
    /// </summary>
    [IsoId("_Svo64gEcEeCQm6a_G2yO_w_716513479")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public required TransactionReconciliation1 Transaction { get; init; }
}
