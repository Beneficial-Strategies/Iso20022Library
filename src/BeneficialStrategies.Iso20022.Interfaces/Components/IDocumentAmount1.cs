// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides details on the amount and type of the referred document.
/// </summary>
[IsoId("_vRiGoDKzEe6dJsbzsnAdDg")]
public interface IDocumentAmount1 : IIsoComponent
{
    /// <summary>
    /// Defines the type of amount.
    /// </summary>
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    IDocumentAmountType1Choice Type { get; }

    /// <summary>
    /// Amount of money for the referred document.
    /// </summary>
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    ActiveOrHistoricCurrencyAndAmount Amount { get; }
}
