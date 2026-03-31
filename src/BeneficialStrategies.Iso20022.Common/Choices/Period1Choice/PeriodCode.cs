// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Period1Choice
{
    /// <summary>
    /// Standard code to specify the type of period.
    /// </summary>
    [IsoId("_T5xr8Np-Ed-ak6NoX_4Aeg_531796080")]
    [DisplayName("Period Code")]
    public record PeriodCode : Period1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the type of dates.
        /// </summary>
        [IsoXmlTag("PrdCd")]
        public required DateType6Code Value { get; init; }
    }
}
