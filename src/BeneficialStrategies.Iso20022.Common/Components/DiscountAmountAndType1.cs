// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IDiscountAmountAndType1"/>
[IsoId("_tlhp8VkyEeGeoaLUQk__nA_1198616303")]
[DisplayName("Discount Amount And Type")]
public partial record DiscountAmountAndType1
{
    /// <inheritdoc cref="IDiscountAmountAndType1.Type"/>
    [IsoId("_tlhp8lkyEeGeoaLUQk__nA_-1773708415")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public DiscountAmountType1Choice_? Type { get; init; }

    /// <inheritdoc cref="IDiscountAmountAndType1.Amount"/>
    [IsoId("_tlhp81kyEeGeoaLUQk__nA_879979740")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ActiveOrHistoricCurrencyAndAmount Amount { get; init; }
}
