// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.SettlementOrCorporateActionEvent16Choice
{
    /// <summary>
    /// Specifies the type of corporate event.
    /// </summary>
    [IsoId("_8bir95NLEeWGlc8L7oPDIg")]
    [DisplayName("Corporate Action Event Type")]
    public partial record CorporateActionEventType : SettlementOrCorporateActionEvent16Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
