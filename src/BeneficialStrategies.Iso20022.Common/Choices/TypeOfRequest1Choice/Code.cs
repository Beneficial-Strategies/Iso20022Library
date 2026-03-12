// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.TypeOfRequest1Choice
{
    /// <summary>
    /// Type of request expressed as a code.
    /// </summary>
    [IsoId("_1DwE4NvdEeqxGfKJubfhIw")]
    [DisplayName("Code")]
    public partial record Code : TypeOfRequest1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies a type of request.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required TypeOfRequest1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
