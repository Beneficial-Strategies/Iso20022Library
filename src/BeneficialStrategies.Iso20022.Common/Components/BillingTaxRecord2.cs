// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides details for taxes.
/// </summary>
[IsoId("_DeEyifsYEemYNq6Sxm5nlg")]
[DisplayName("Billing Tax Record2")]
public record BillingTaxRecord2
{
    /// <summary>
    /// Rate used to calculate the tax.
    /// </summary>
    [IsoId("_DySvAfsYEemYNq6Sxm5nlg")]
    [DisplayName("Rate")]
    [IsoXmlTag("Rate")]
    public required IsoPercentageRate Rate { get; init; }

    /// <summary>
    /// Name used to describe the tax (such as the national value added tax).
    /// </summary>
    [IsoId("_DySvA_sYEemYNq6Sxm5nlg")]
    [DisplayName("Description")]
    [IsoXmlTag("Desc")]
    public IsoMax40Text? Description { get; init; }

    /// <summary>
    /// Amount subject to tax.
    /// </summary>
    [IsoId("_DySvBfsYEemYNq6Sxm5nlg")]
    [DisplayName("Taxable Amount")]
    [IsoXmlTag("TaxblAmt")]
    public required ActiveCurrencyAndAmount TaxableAmount { get; init; }

    /// <summary>
    /// Amount exempted from tax.
    /// </summary>
    [IsoId("_MNH7YfsaEemYNq6Sxm5nlg")]
    [DisplayName("Tax Exemption")]
    [IsoXmlTag("TaxXmptn")]
    public ValueList<TaxExemption1> TaxExemption { get; init; } = [];

    /// <summary>
    /// Calculated tax amount.
    /// </summary>
    [IsoId("_DySvB_sYEemYNq6Sxm5nlg")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ActiveCurrencyAndAmount Amount { get; init; }

    /// <summary>
    /// Further details on the charges and fees related to the tax data.
    /// </summary>
    [IsoId("_GzYhcvsYEemYNq6Sxm5nlg")]
    [DisplayName("Charges And Fees")]
    [IsoXmlTag("ChrgsAndFees")]
    public ValueList<BillingFeeRecord1> ChargesAndFees { get; init; } = [];
}
