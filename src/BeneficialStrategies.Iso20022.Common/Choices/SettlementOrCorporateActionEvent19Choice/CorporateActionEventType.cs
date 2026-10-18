// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SettlementOrCorporateActionEvent19Choice
{
    /// <summary>
    /// Specifies the type of corporate event.
    /// </summary>
    [IsoId("_547LWZBPEeakHoV5BVecAQ")]
    [DisplayName("Corporate Action Event Type")]
    public partial record CorporateActionEventType : SettlementOrCorporateActionEvent19Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("CorpActnEvtTp")]
        public required CorporateActionEventType56Choice_ Value { get; init; }
    }
}
