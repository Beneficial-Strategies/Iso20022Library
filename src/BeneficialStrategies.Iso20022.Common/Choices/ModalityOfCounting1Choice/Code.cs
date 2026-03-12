// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.ModalityOfCounting1Choice
{
    /// <summary>
    /// Modality of counting expressed as a code.
    /// </summary>
    [IsoId("_eYiLAK-vEemJ1NnLPsTFaw")]
    [DisplayName("Code")]
    public partial record Code : ModalityOfCounting1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the modality through which the votes that have been recorded and counted.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required ModalityOfCounting1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
