// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.Status22Choice
{
    /// <summary>
    /// Status of affirmation of a trade.
    /// </summary>
    [IsoId("_8QboI5NLEeWGlc8L7oPDIg")]
    [DisplayName("Affirmation Status")]
    public partial record AffirmationStatus : Status22Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
