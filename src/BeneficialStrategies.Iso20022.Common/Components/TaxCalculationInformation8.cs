// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information used to calculate the tax.
/// </summary>
[IsoId("_3_FFgRwcEeOIveEnnb_1-A")]
[DisplayName("Tax Calculation Information")]
public record TaxCalculationInformation8
{
    /// <summary>
    /// Form of the rebate, for example, cash.
    /// </summary>
    [IsoId("_4YqqNRwcEeOIveEnnb_1-A")]
    [DisplayName("Basis")]
    [IsoXmlTag("Bsis")]
    public TaxBasis1Choice_? Basis { get; init; }

    /// <summary>
    /// Amount of money on which the tax is charged.
    /// </summary>
    [IsoId("_Mmue8BwdEeOIveEnnb_1-A")]
    [DisplayName("Taxable Amount")]
    [IsoXmlTag("TaxblAmt")]
    public required ActiveCurrencyAnd13DecimalAmount TaxableAmount { get; init; }
}
