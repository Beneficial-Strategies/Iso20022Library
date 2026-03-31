// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TradeData40Choice
{
    /// <summary>
    /// Information concerning the reporting at transaction level.
    /// </summary>
    [IsoId("_ztk1M8g3EeuGrNSsxk3B0A")]
    [DisplayName("Report")]
    public record Report : TradeData40Choice_ { }
}
