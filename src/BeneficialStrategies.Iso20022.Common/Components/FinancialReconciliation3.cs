// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Financial Reconciliation3.
/// </summary>
[IsoId("_aqrfIY1PEe6S0_1AaJzQCA")]
[DisplayName("Financial Reconciliation3")]
public partial record FinancialReconciliation3
{
    #nullable enable

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
    public required ReconciliationCategory1Code Type { get; init; } 

    
    #nullable disable
    
}
