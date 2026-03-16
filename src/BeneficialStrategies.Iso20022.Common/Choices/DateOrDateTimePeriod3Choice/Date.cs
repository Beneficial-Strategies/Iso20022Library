// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.DateOrDateTimePeriod3Choice
{
    /// <summary>
    /// Period expressed with dates.
    /// </summary>
    [IsoId("_Fk5tlf1bEeiAfJEqh4xF_Q")]
    [DisplayName("Date")]
    public record Date : DateOrDateTimePeriod3Choice_ { }
}
