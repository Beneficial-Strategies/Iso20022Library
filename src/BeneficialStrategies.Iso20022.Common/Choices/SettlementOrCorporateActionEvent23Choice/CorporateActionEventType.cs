// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SettlementOrCorporateActionEvent23Choice
{
    /// <summary>
    /// Specifies the type of corporate event.
    /// </summary>
    [IsoId("_x4idWaOAEeeDTpy0mhI4TQ")]
    [DisplayName("Corporate Action Event Type")]
    public record CorporateActionEventType : SettlementOrCorporateActionEvent23Choice_ { }
}
