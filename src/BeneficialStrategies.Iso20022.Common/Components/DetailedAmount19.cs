// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Breakdown of the transaction amount.
/// </summary>
[IsoId("_D_tC8ESKEeeb1MmUPTrSMw")]
[DisplayName("Detailed Amount")]
public record DetailedAmount19
{
    /// <summary>
    /// Type or class of amount.
    /// </summary>
    [IsoId("_YcPYkESKEeeb1MmUPTrSMw")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required DetailAmount1Code Type { get; init; }

    /// <summary>
    /// Additional information to specify the type of amount.
    /// </summary>
    [IsoId("_hhfF0ESKEeeb1MmUPTrSMw")]
    [DisplayName("Other Type")]
    [IsoXmlTag("OthrTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OtherType { get; init; }

    /// <summary>
    /// Detailed amount expressed in the transaction currency.
    /// </summary>
    [IsoId("_0-AI4ESKEeeb1MmUPTrSMw")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required Amount5 Amount { get; init; }

    /// <summary>
    /// Detailed amount expressed in the cardholder billing currency.
    /// </summary>
    [IsoId("_G2Ww8ZKhEempjNUC7bi_Ng")]
    [DisplayName("Cardholder Billing Amount")]
    [IsoXmlTag("CrdhldrBllgAmt")]
    public Amount5? CardholderBillingAmount { get; init; }

    /// <summary>
    /// Detailed amount expressed in the reconciliation currency.
    /// </summary>
    [IsoId("_abQ7AZKhEempjNUC7bi_Ng")]
    [DisplayName("Reconciliation Amount")]
    [IsoXmlTag("RcncltnAmt")]
    public Amount5? ReconciliationAmount { get; init; }

    /// <summary>
    /// Short description of the detailed amount.
    /// </summary>
    [IsoId("__X7xIESKEeeb1MmUPTrSMw")]
    [DisplayName("Label")]
    [IsoXmlTag("Labl")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? Label { get; init; }
}
