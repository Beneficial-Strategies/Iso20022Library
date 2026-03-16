// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PriceFormat1Choice
{
    /// <summary>
    /// The value of the price is not specified.
    /// </summary>
    [IsoId("_QatkGtp-Ed-ak6NoX_4Aeg_-1046180910")]
    [DisplayName("Not Specified")]
    public record NotSpecified : PriceFormat1Choice_ { }
}
