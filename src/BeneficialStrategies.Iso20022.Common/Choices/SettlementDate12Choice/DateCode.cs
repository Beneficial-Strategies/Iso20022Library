// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.SettlementDate12Choice
{
    /// <summary>
    /// Date and time at which the securities are to be delivered or received.
    /// </summary>
    [IsoId("_5TGUr5NLEeWGlc8L7oPDIg")]
    [DisplayName("Date Code")]
    public partial record DateCode : SettlementDate12Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
