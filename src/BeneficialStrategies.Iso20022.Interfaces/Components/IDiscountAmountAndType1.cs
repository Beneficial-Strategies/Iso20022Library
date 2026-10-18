// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the amount with a specific type.
/// </summary>
[IsoId("_tlhp8VkyEeGeoaLUQk__nA_1198616303")]
public interface IDiscountAmountAndType1 : IIsoComponent
{
    /// <summary>
    /// Specifies the type of the amount.
    /// </summary>
    [IsoId("_tlhp8lkyEeGeoaLUQk__nA_-1773708415")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    IDiscountAmountType1Choice? Type { get; }

    /// <summary>
    /// Amount of money, which has been typed.
    /// </summary>
    [IsoId("_tlhp81kyEeGeoaLUQk__nA_879979740")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    ActiveOrHistoricCurrencyAndAmount Amount { get; }
}
