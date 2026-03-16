// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.OptionBarrierLevel1Choice
{
    /// <summary>
    /// Multiple.
    /// </summary>
    [DisplayName("Multiple")]
    public partial record Multiple : OptionBarrierLevel1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("Mltpl")]
        public required OptionMultipleBarrierLevels1 Value { get; init; } 
        
        
        #nullable disable
        
    }
}
