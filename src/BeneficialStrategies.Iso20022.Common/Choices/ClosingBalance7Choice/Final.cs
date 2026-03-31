// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ClosingBalance7Choice
{
    /// <summary>
    /// Sum of the opening balance and all entries booked to the account at the close of the statement period.
    /// </summary>
    [IsoId("_gJxajTi8Eeydid5dcNPKvg")]
    [DisplayName("Final")]
    public record Final : ClosingBalance7Choice_ { }
}
