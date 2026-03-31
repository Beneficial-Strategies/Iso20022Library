// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Describes account taxing parameters.
/// </summary>
[IsoId("_6TYLKJqlEeGSON8vddiWzQ_-1311079011")]
[DisplayName("Account Tax")]
public record AccountTax1
{
    /// <summary>
    /// Defines the calculation method on how the taxes are applied on the account.
    /// </summary>
    [IsoId("_6TYLKZqlEeGSON8vddiWzQ_-1424918077")]
    [DisplayName("Calculation Method")]
    [IsoXmlTag("ClctnMtd")]
    public required BillingTaxCalculationMethod1Code CalculationMethod { get; init; }

    /// <summary>
    /// Identifies the tax region in which the account resides.
    /// </summary>
    [IsoId("_6TYLKpqlEeGSON8vddiWzQ_1872976866")]
    [DisplayName("Region")]
    [IsoXmlTag("Rgn")]
    [IsoSimpleType(IsoSimpleType.Max40Text)]
    [StringLength(maximumLength: 40, MinimumLength = 1)]
    public IsoMax40Text? Region { get; init; }

    /// <summary>
    /// Specifies the country of residence, when the account owner does not reside in the account&apos;s tax region.||Usage: If present, the account owner does not reside in the account&apos;s tax region.
    /// </summary>
    [IsoId("_6TYLK5qlEeGSON8vddiWzQ_-765795978")]
    [DisplayName("Non Residence Country")]
    [IsoXmlTag("NonResCtry")]
    public ResidenceLocation1Choice_? NonResidenceCountry { get; init; }
}
