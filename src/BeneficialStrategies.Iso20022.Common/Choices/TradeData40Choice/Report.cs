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
    public record Report : TradeData40Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Rpt")]
        public required TradeReport22Choice_ Value { get; init; }
    }
}
