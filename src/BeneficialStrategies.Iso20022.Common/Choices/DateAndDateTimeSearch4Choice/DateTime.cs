// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.DateAndDateTimeSearch4Choice
{
    /// <summary>
    /// Patterns to search a date time.
    /// </summary>
    [IsoId("_68F8QX3sEeibM9CPDGCw0g")]
    [DisplayName("Date Time")]
    public record DateTime : DateAndDateTimeSearch4Choice_ { }
}
