// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TradeData19Choice
{
    /// <summary>
    /// Reporting of position or transaction for trade lifecycle events.
    /// </summary>
    [IsoId("_nBfoE3g-Eeu3kecHd7QKUQ")]
    [DisplayName("Report")]
    public record Report : TradeData19Choice_ { }
}
