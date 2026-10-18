// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="ITaxType"/>
[IsoId("_RvWbxtp-Ed-ak6NoX_4Aeg_1316020660")]
[DisplayName("Tax Type")]
public partial record TaxType
{
    /// <inheritdoc cref="ITaxType.CategoryDescription"/>
    [IsoId("_RvWbx9p-Ed-ak6NoX_4Aeg_1403753704")]
    [DisplayName("Category Description")]
    [IsoXmlTag("CtgyDesc")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? CategoryDescription { get; init; }

    /// <inheritdoc cref="ITaxType.Rate"/>
    [IsoId("_RvWbyNp-Ed-ak6NoX_4Aeg_1403753781")]
    [DisplayName("Rate")]
    [IsoXmlTag("Rate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? Rate { get; init; }

    /// <inheritdoc cref="ITaxType.TaxableBaseAmount"/>
    [IsoId("_RvWbydp-Ed-ak6NoX_4Aeg_1403754228")]
    [DisplayName("Taxable Base Amount")]
    [IsoXmlTag("TaxblBaseAmt")]
    public CurrencyAndAmount? TaxableBaseAmount { get; init; }

    /// <inheritdoc cref="ITaxType.Amount"/>
    [IsoId("_RvWbytp-Ed-ak6NoX_4Aeg_1403754133")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public CurrencyAndAmount? Amount { get; init; }
}
