// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TradeDate8Choice
{
    /// <summary>
    /// Date expressed as a code.
    /// </summary>
    [IsoId("_vuB5bLPuEeelzbgsFa3sqQ")]
    [DisplayName("Date Code")]
    public record DateCode : TradeDate8Choice_ { }
}
