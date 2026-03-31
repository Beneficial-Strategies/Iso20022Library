// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SettlementOrCorporateActionEvent6Choice
{
    /// <summary>
    /// Specifies the type of corporate event.
    /// </summary>
    [IsoId("_fw8YD_vmEeCBQp5TnX1XKQ")]
    [DisplayName("Corporate Action Event Type")]
    public record CorporateActionEventType : SettlementOrCorporateActionEvent6Choice_ { }
}
