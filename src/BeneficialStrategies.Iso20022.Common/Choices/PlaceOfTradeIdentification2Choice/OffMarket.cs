// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PlaceOfTradeIdentification2Choice
{
    /// <summary>
    /// Indicates that the trade was executed off -exchange.
    /// </summary>
    [IsoId("_TCfeptp-Ed-ak6NoX_4Aeg_-1421688662")]
    [DisplayName("Off Market")]
    public record OffMarket : PlaceOfTradeIdentification2Choice_ { }
}
