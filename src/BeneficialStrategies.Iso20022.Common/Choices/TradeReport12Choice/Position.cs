// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TradeReport12Choice
{
    /// <summary>
    /// Information concerning the reporting at position level.
    /// </summary>
    [IsoId("_bQpIgRLBEeqctpBfTmLJnw")]
    [DisplayName("Position")]
    public record Position : TradeReport12Choice_ { }
}
