// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Choice between formats for the quantity of security.
/// </summary>
[IsoId("_m1LjEWqWEemz04WrKJaMEA")]
[DisplayName("Financial Instrument Quantity Search2")]
public record FinancialInstrumentQuantitySearch2
{
    /// <summary>
    /// Quantity expressed as an amount representing the face amount, that is the principal, of a debt instrument.
    /// </summary>
    [IsoId("_nBVvwWqWEemz04WrKJaMEA")]
    [DisplayName("Face Amount")]
    [IsoXmlTag("FaceAmt")]
    public required ImpliedCurrencyAmountRange1Choice_ FaceAmount { get; init; }

    /// <summary>
    /// Quantity expressed as an amount representing the current amortised face amount of a bond, for example, a periodic reduction/increase of a bond's principal amount.
    /// </summary>
    [IsoId("_nBVvw2qWEemz04WrKJaMEA")]
    [DisplayName("Amortised Value")]
    [IsoXmlTag("AmtsdVal")]
    public required ImpliedCurrencyAmountRange1Choice_ AmortisedValue { get; init; }
}
