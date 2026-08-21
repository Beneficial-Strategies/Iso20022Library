// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides details on the amount and type of the referred document.
/// </summary>
[IsoId("_vRiGoDKzEe6dJsbzsnAdDg")]
[Description(@"Provides details on the amount and type of the referred document.")]
[DisplayName("Document Amount1")]
public record DocumentAmount1
{
    /// <summary>
    /// Amount of money for the referred document.
    /// </summary>
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ActiveOrHistoricCurrencyAndAmount Amount { get; init; }

    /// <summary>
    /// Defines the type of amount.
    /// </summary>
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required DocumentAmountType1Choice_ Type { get; init; }
}
