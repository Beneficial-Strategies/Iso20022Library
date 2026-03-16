// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.DateFormat59Choice
{
    /// <summary>
    /// Date expressed as a calendar date.
    /// </summary>
    [IsoId("_8YeEHe3CEeqc-LCjwLsUVg")]
    [DisplayName("Date")]
    public record Date : DateFormat59Choice_ { }
}
