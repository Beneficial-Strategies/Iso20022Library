// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Additional Fee Reconciliation3.
/// </summary>
[IsoId("__aw7wY1PEe6S0_1AaJzQCA")]
[DisplayName("Additional Fee Reconciliation3")]
public record AdditionalFeeReconciliation3
{
    /// <summary>
    /// Amount.
    /// </summary>
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ImpliedCurrencyAndAmount Amount { get; init; }

    /// <summary>
    /// Count.
    /// </summary>
    [DisplayName("Count")]
    [IsoXmlTag("Cnt")]
    public required IsoNumber Count { get; init; }

    /// <summary>
    /// Impact.
    /// </summary>
    [DisplayName("Impact")]
    [IsoXmlTag("Impct")]
    public required ReconciliationImpact1Code Impact { get; init; }

    /// <summary>
    /// Other Type.
    /// </summary>
    [DisplayName("Other Type")]
    [IsoXmlTag("OthrTp")]
    public IsoMax35Text? OtherType { get; init; }

    /// <summary>
    /// Type.
    /// </summary>
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required TypeOfAmount21Code Type { get; init; }
}
