// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AmountAndRateFormat2Choice
{
    /// <summary>
    /// The rate is not specified.
    /// </summary>
    [IsoId("_UH8Dy9p-Ed-ak6NoX_4Aeg_872458979")]
    [DisplayName("Not Specified Rate")]
    public record NotSpecifiedRate : AmountAndRateFormat2Choice_ { }
}
