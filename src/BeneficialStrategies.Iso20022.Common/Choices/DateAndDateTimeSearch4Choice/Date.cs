// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.DateAndDateTimeSearch4Choice
{
    /// <summary>
    /// Patterns to search a date.
    /// </summary>
    [IsoId("_68F8Q33sEeibM9CPDGCw0g")]
    [DisplayName("Date")]
    public record Date : DateAndDateTimeSearch4Choice_ { }
}
