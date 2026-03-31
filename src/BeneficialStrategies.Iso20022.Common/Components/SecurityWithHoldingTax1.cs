// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements of a cash distribution that will be withheld by a tax authority.
/// </summary>
[IsoId("_haio02liEeGaMcKyqKNRfQ_-1955007741")]
[DisplayName("Security With Holding Tax")]
public record SecurityWithHoldingTax1
{
    /// <summary>
    /// Value of the withholding tax as rate, amount or not specified.
    /// </summary>
    [IsoId("_haio1GliEeGaMcKyqKNRfQ_-987543376")]
    [DisplayName("Withholding Tax Value")]
    [IsoXmlTag("WhldgTaxVal")]
    public required RateAndAmountFormat1Choice_ WithholdingTaxValue { get; init; }

    /// <summary>
    /// Represents the tax authority.
    /// </summary>
    [IsoId("_haio1WliEeGaMcKyqKNRfQ_1903420370")]
    [DisplayName("Country")]
    [IsoXmlTag("Ctry")]
    public required CountryCode Country { get; init; }
}
