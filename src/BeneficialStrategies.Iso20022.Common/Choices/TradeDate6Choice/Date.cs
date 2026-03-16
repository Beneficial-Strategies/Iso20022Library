// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TradeDate6Choice
{
    /// <summary>
    /// Date expressed as a ISO date.
    /// </summary>
    [IsoId("_5TGUW5NLEeWGlc8L7oPDIg")]
    [DisplayName("Date")]
    public record Date : TradeDate6Choice_ { }
}
