// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TradeDate4Choice
{
    /// <summary>
    /// Date and time at which the securities are to be traded.
    /// </summary>
    [IsoId("_AXK_UtokEeC60axPepSq7g_1512121673")]
    [DisplayName("Date")]
    public record Date : TradeDate4Choice_ { }
}
