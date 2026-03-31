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
[IsoId("_ZKulQS4_EeunNvJlR_vCbg")]
[DisplayName("Acceptor Reconciliation Request")]
public record AcceptorReconciliationRequest9
{
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_ZWV_YS4_EeunNvJlR_vCbg")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required CardPaymentEnvironment77 Environment { get; init; }

    /// <summary>
    /// Reconciliation transaction between an acceptor an acquirer.
    /// </summary>
    [IsoId("_ZWV_Yy4_EeunNvJlR_vCbg")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public required TransactionReconciliation5 Transaction { get; init; }
}
