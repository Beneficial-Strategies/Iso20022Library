// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information on the type of tax.
/// </summary>
[IsoId("_RvWbxtp-Ed-ak6NoX_4Aeg_1316020660")]
[DisplayName("Tax Type")]
public record TaxType
{
    /// <summary>
    /// Description of the tax that is being paid, including specific representation required by taxing authority.
    /// </summary>
    [IsoId("_RvWbx9p-Ed-ak6NoX_4Aeg_1403753704")]
    [DisplayName("Category Description")]
    [IsoXmlTag("CtgyDesc")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? CategoryDescription { get; init; }

    /// <summary>
    /// Rate used to calculate the tax.
    /// </summary>
    [IsoId("_RvWbyNp-Ed-ak6NoX_4Aeg_1403753781")]
    [DisplayName("Rate")]
    [IsoXmlTag("Rate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? Rate { get; init; }

    /// <summary>
    /// Amount of money on which the tax is based.
    /// </summary>
    [IsoId("_RvWbydp-Ed-ak6NoX_4Aeg_1403754228")]
    [DisplayName("Taxable Base Amount")]
    [IsoXmlTag("TaxblBaseAmt")]
    public CurrencyAndAmount? TaxableBaseAmount { get; init; }

    /// <summary>
    /// Amount of money resulting from the calculation of the tax.
    /// </summary>
    [IsoId("_RvWbytp-Ed-ak6NoX_4Aeg_1403754133")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public CurrencyAndAmount? Amount { get; init; }
}
