// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.RatioFormat2Choice
{
    /// <summary>
    /// The value of the ratio is not specified.
    /// </summary>
    [IsoId("_Rj3kiNp-Ed-ak6NoX_4Aeg_1125895713")]
    [DisplayName("Not Specified Rate")]
    public record NotSpecifiedRate : RatioFormat2Choice_ { }
}
