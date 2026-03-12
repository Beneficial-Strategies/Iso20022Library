// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.OptionEventType1Choice
{
    /// <summary>
    /// Specifies the type of event for an option using a code.
    /// </summary>
    [IsoId("_BIRnQJR1Eeeymf3kpbtgrA")]
    [DisplayName("Code")]
    public partial record Code : OptionEventType1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the type of event for an option.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required OptionEventType1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
