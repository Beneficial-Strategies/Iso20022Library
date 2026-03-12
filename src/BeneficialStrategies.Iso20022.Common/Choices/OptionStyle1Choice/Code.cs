// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.OptionStyle1Choice
{
    /// <summary>
    /// Option style is defined using a code.
    /// </summary>
    [IsoId("_Q_EOV9p-Ed-ak6NoX_4Aeg_708155694")]
    [DisplayName("Code")]
    public partial record Code : OptionStyle1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Defines how an option can be exercised.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required OptionStyle1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
