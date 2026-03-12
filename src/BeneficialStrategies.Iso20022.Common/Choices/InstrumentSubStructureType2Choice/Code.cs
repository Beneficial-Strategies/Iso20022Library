// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.InstrumentSubStructureType2Choice
{
    /// <summary>
    /// Instrument sub-structure type expressed as an ISO 20022 code.
    /// </summary>
    [IsoId("_QkVkYeLaEeWFtOV72FbX9w")]
    [DisplayName("Code")]
    public partial record Code : InstrumentSubStructureType2Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Indicates the type of deal for structured finance.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required InstrumentSubStructureType1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
