// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.FXCancellation1Choice
{
    /// <summary>
    /// Specifies whether the underlying FX transaction should also be cancelled. Yes means FX is to be cancelled. No means FX is to be retained.
    /// </summary>
    [IsoId("_QtVlItp-Ed-ak6NoX_4Aeg_615585034")]
    [DisplayName("Indicator")]
    public partial record Indicator : FXCancellation1Choice_
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
