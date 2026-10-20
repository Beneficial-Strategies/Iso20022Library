// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SettlementOrCorporateActionEvent15Choice
{
    /// <summary>
    /// Specifies the type of corporate event.
    /// </summary>
    [IsoId("_8VKXd5NLEeWGlc8L7oPDIg")]
    [DisplayName("Corporate Action Event Type")]
    public partial record CorporateActionEventType : SettlementOrCorporateActionEvent15Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("CorpActnEvtTp")]
        public required CorporateActionEventType48Choice_ Value { get; init; }
    }
}
