// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements qualifying the interest rate.
/// </summary>
[IsoId("_SRnbU9p-Ed-ak6NoX_4Aeg_36879442")]
[DisplayName("Rate")]
public record Rate1
{
    /// <summary>
    /// Percentage charged for the use of an amount of money, usually expressed at an annual rate. The interest rate is the ratio of the amount of interest paid during a certain period of time compared to the principal amount of the interest bearing financial instrument. |Example percentage rate: Rate expressed as a percentage, ie, in hundredths, eg, 0.7 is 7/10 of a percent, and 7.0 is 7%.|Example Textual rate: Rate is expressed as a text.
    /// </summary>
    [IsoId("_SRnbVNp-Ed-ak6NoX_4Aeg_225276293")]
    [DisplayName("Rate")]
    [IsoXmlTag("Rate")]
    public required RateTypeChoice_ Rate { get; init; }

    /// <summary>
    /// An amount range where the interest rate is applicable.
    /// </summary>
    [IsoId("_SRnbVdp-Ed-ak6NoX_4Aeg_-1476444438")]
    [DisplayName("Validity Range")]
    [IsoXmlTag("VldtyRg")]
    public CurrencyAndAmountRange? ValidityRange { get; init; }
}
