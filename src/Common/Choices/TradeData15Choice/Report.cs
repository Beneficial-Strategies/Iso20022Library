// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TradeData15Choice
{
    /// <summary>
    /// Information concerning the reporting at transaction level.
    /// </summary>
    [IsoId("_34vr8__qEemm3skPVSMJQg")]
    [DisplayName("Report")]
    public partial record Report : TradeData15Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Rpt")]
        public required TradeReport10Choice_ Value { get; init; }
    }
}
