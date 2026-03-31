// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ClosingDate4Choice
{
    /// <summary>
    /// Closing date is defined as a choice between a date or a date and time format.
    /// </summary>
    [IsoId("_xTU6gcpdEemQ1o-hyeYV5w")]
    [DisplayName("Date")]
    public record Date : ClosingDate4Choice_ { }
}
