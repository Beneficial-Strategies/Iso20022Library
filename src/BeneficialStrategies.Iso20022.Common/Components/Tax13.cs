// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Amount of money due to the government or tax authority, according to various pre-defined parameters such as thresholds or income.
/// </summary>
[IsoId("_RvpWsNp-Ed-ak6NoX_4Aeg_-681693938")]
[DisplayName("Tax")]
public record Tax13
{
    /// <summary>
    /// Type of tax applied.
    /// </summary>
    [IsoId("_RvpWsdp-Ed-ak6NoX_4Aeg_-681693920")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required TaxType9Code Type { get; init; }

    /// <summary>
    /// Specifies types of tax not present in a code list.
    /// </summary>
    [IsoId("_RvpWstp-Ed-ak6NoX_4Aeg_-681693903")]
    [DisplayName("Other Tax Type")]
    [IsoXmlTag("OthrTaxTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text OtherTaxType { get; init; }

    /// <summary>
    /// Amount of money resulting from the calculation of the tax.
    /// </summary>
    [IsoId("_RvpWs9p-Ed-ak6NoX_4Aeg_-681693868")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required CurrencyAndAmount Amount { get; init; }

    /// <summary>
    /// Rate used to calculate the tax.
    /// </summary>
    [IsoId("_RvpWtNp-Ed-ak6NoX_4Aeg_-681693626")]
    [DisplayName("Rate")]
    [IsoXmlTag("Rate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public required IsoPercentageRate Rate { get; init; }
}
