// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IDocumentAmount1"/>
[IsoId("_vRiGoDKzEe6dJsbzsnAdDg")]
[Description(@"Provides details on the amount and type of the referred document.")]
[DisplayName("Document Amount1")]
public partial record DocumentAmount1
{
    /// <inheritdoc cref="IDocumentAmount1.Amount"/>
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ActiveOrHistoricCurrencyAndAmount Amount { get; init; }

    /// <inheritdoc cref="IDocumentAmount1.Type"/>
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required DocumentAmountType1Choice_ Type { get; init; }
}
