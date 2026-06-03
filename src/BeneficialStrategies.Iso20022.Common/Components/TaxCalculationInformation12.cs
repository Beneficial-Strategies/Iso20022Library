// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information used for the calculation of a tax.
/// </summary>
[IsoId("61b9a6d5-d27b-4cdb-b5df-0ca6a9409801")]
[DisplayName("Tax Calculation Information12")]
public record TaxCalculationInformation12
{
    [IsoId("61b9a6d5-eucg-0001-0001-0ca6a9409801")]
    [DisplayName("EU Capital Gain")]
    [IsoXmlTag("EUCptlGn")]
    public EUCapitalGainType4Choice_? EUCapitalGain { get; init; }

    [IsoId("61b9a6d5-pcdc-0001-0002-0ca6a9409801")]
    [DisplayName("Percentage Of Debt Claim")]
    [IsoXmlTag("PctgOfDbtClm")]
    public IsoPercentageRate? PercentageOfDebtClaim { get; init; }

    [IsoId("61b9a6d5-pggd-0001-0003-0ca6a9409801")]
    [DisplayName("Percentage Grandfathered Debt")]
    [IsoXmlTag("PctgGrndfthrdDbt")]
    public IsoPercentageRate? PercentageGrandfatheredDebt { get; init; }

    [IsoId("61b9a6d5-tidd-0001-0004-0ca6a9409801")]
    [DisplayName("Taxable Income Per Dividend")]
    [IsoXmlTag("TaxblIncmPerDvdd")]
    public ActiveOrHistoricCurrencyAnd13DecimalAmount? TaxableIncomePerDividend { get; init; }

    [IsoId("61b9a6d5-euds-0001-0005-0ca6a9409801")]
    [DisplayName("EU Dividend Status")]
    [IsoXmlTag("EUDvddSts")]
    public EUDividendStatusType3Choice_? EUDividendStatus { get; init; }
}
