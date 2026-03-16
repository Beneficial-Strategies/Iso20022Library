// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.RatioFormat1Choice
{
    /// <summary>
    /// The value of the ratio is not specified.
    /// </summary>
    [IsoId("_Rj3kgtp-Ed-ak6NoX_4Aeg_-161489605")]
    [DisplayName("Not Specified Rate")]
    public record NotSpecifiedRate : RatioFormat1Choice_ { }
}
