// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides further details on the interest that applies to the account at a particular moment in time.
/// </summary>
[IsoId("_wDb1Aa6FEeexrtTFgmVD3Q")]
[DisplayName("Account Interest")]
public record AccountInterest4
{
    /// <summary>
    /// Specifies the type of interest.
    /// </summary>
    [IsoId("_wL7Co66FEeexrtTFgmVD3Q")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public InterestType1Choice_? Type { get; init; }

    /// <summary>
    /// Set of elements used to qualify the interest rate.
    /// </summary>
    [IsoId("_wL7Cpa6FEeexrtTFgmVD3Q")]
    [DisplayName("Rate")]
    [IsoXmlTag("Rate")]
    public Rate4? Rate { get; init; }

    /// <summary>
    /// Range of time between a start date and an end date for the calculation of the interest.
    /// </summary>
    [IsoId("_wL7Cp66FEeexrtTFgmVD3Q")]
    [DisplayName("From To Date")]
    [IsoXmlTag("FrToDt")]
    public DateTimePeriod1? FromToDate { get; init; }

    /// <summary>
    /// Specifies the reason for the interest.
    /// </summary>
    [IsoId("_wL7Cqa6FEeexrtTFgmVD3Q")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Reason { get; init; }

    /// <summary>
    /// Provides details on the tax applied to charges.
    /// </summary>
    [IsoId("_wL7Cq66FEeexrtTFgmVD3Q")]
    [DisplayName("Tax")]
    [IsoXmlTag("Tax")]
    public TaxCharges2? Tax { get; init; }
}
