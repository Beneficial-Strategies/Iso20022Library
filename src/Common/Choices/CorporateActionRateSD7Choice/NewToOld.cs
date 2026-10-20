// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CorporateActionRateSD7Choice
{
    /// <summary>
    /// Quantity of new securities for a given quantity of underlying securities, where the underlying securities will be exchanged or debited, for example, 2 for 1: 2 new equities credited for every 1 underlying equity debited = 2 resulting equities.
    /// </summary>
    [IsoId("__QZZOcOTEeeAG4VQMmSqTA")]
    [DisplayName("New To Old")]
    public partial record NewToOld : CorporateActionRateSD7Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("NewToOd")]
        public required RatioFormat24Choice_ Value { get; init; }
    }
}
