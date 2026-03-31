// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SettlementOrCorporateActionEvent25Choice
{
    /// <summary>
    /// Specifies the type of corporate event.
    /// </summary>
    [IsoId("_gdPZSc33Eee5nJBZsW8MFQ")]
    [DisplayName("Corporate Action Event Type")]
    public record CorporateActionEventType : SettlementOrCorporateActionEvent25Choice_ { }
}
