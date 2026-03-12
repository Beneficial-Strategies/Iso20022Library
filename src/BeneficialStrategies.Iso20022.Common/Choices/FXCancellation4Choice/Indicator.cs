// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.FXCancellation4Choice
{
    /// <summary>
    /// Specifies whether the underlying forex transaction should also be cancelled. Yes means forex is to be cancelled. No means forex is to be retained.
    /// </summary>
    [IsoId("_8T_Sw5NLEeWGlc8L7oPDIg")]
    [DisplayName("Indicator")]
    public partial record Indicator : FXCancellation4Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Indicates a &quot;Yes&quot; or &quot;No&quot; type of answer for an element.
        /// </summary>
        [IsoXmlTag("Ind")]
        [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
        public required IsoYesNoIndicator Value { get; init; } 
        
        
        #nullable disable
        
    }
}
