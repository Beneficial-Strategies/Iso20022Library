// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.PoliticallyExposedPersonStatus1Choice
{
    /// <summary>
    /// Status of the politically exposed person expressed as a code.
    /// </summary>
    [IsoId("_ds6esJUiEemC09f0MxYkRg")]
    [DisplayName("Code")]
    public partial record Code : PoliticallyExposedPersonStatus1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Status of a politically exposed person.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required PoliticallyExposedPersonStatus1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
