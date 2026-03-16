// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.RateAndAmountFormat1Choice
{
    /// <summary>
    /// No value is specified.
    /// </summary>
    [IsoId("_UPrqhtp-Ed-ak6NoX_4Aeg_307786287")]
    [DisplayName("Not Specified Rate")]
    public record NotSpecifiedRate : RateAndAmountFormat1Choice_ { }
}
