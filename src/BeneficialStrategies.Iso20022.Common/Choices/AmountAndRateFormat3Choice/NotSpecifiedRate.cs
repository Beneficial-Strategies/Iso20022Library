// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AmountAndRateFormat3Choice
{
    /// <summary>
    /// The rate is not specified.
    /// </summary>
    [IsoId("_UIFNtdp-Ed-ak6NoX_4Aeg_896081941")]
    [DisplayName("Not Specified Rate")]
    public record NotSpecifiedRate : AmountAndRateFormat3Choice_ { }
}
