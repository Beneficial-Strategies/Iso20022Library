// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Tax applicable to a securities transaction.
/// </summary>
[IsoId("84a3ce1c-48b6-4540-8c36-5b77709f3523")]
[DisplayName("Tax43")]
public record Tax43
{
    /// <summary>
    /// Type of tax applied.
    /// </summary>
    [IsoId("84a3ce1c-type-0001-0001-5b77709f3523")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required TaxType4Choice_ Type { get; init; }

    /// <summary>
    /// Amount of money resulting from the calculation of the tax.
    /// </summary>
    [IsoId("84a3ce1c-amnt-0001-0002-5b77709f3523")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public ValueList<ActiveOrHistoricCurrencyAnd13DecimalAmount> Amount { get; init; } = [];

    /// <summary>
    /// Rate used to calculate the tax.
    /// </summary>
    [IsoId("84a3ce1c-rate-0001-0003-5b77709f3523")]
    [DisplayName("Rate")]
    [IsoXmlTag("Rate")]
    public IsoPercentageRate? Rate { get; init; }

    /// <summary>
    /// Country where the tax is due.
    /// </summary>
    [IsoId("84a3ce1c-ctry-0001-0004-5b77709f3523")]
    [DisplayName("Country")]
    [IsoXmlTag("Ctry")]
    public required CountryCode Country { get; init; }

    /// <summary>
    /// Information used to calculate the tax.
    /// </summary>
    [IsoId("84a3ce1c-txcd-0001-0005-5b77709f3523")]
    [DisplayName("Tax Calculation Details")]
    [IsoXmlTag("TaxClctnDtls")]
    public TaxCalculationInformation12? TaxCalculationDetails { get; init; }
}
