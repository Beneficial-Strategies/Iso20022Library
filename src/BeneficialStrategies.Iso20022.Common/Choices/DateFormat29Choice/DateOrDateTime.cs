// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.DateFormat29Choice
{
    /// <summary>
    /// Date expressed as a calendar date.
    /// </summary>
    [IsoId("_n6yXalt_EeSmO6RkXg92Lg")]
    [DisplayName("Date Or Date Time")]
    public record DateOrDateTime : DateFormat29Choice_ { }
}
