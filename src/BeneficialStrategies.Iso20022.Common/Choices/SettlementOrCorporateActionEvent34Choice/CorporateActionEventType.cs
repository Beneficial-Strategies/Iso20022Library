// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SettlementOrCorporateActionEvent34Choice
{
    /// <summary>
    /// Corporate Action Event Type.
    /// </summary>
    [DisplayName("Corporate Action Event Type")]
    public record CorporateActionEventType : SettlementOrCorporateActionEvent34Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("CorpActnEvtTp")]
        public required CorporateActionEventType110Choice_ Value { get; init; }
    }
}
