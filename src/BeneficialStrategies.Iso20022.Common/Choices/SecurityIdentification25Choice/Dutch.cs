// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.SecurityIdentification25Choice
{
    /// <summary>
    /// Identifier for Dutch securities.
    /// </summary>
    [IsoId("_cH1L9TnxEeabspMEjqY5TQ")]
    [DisplayName("Dutch")]
    public partial record Dutch : SecurityIdentification25Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Identifier for Dutch securities.
        /// </summary>
        [IsoXmlTag("Dtch")]
        [IsoSimpleType(IsoSimpleType.DutchIdentifier)]
        public required IsoDutchIdentifier Value { get; init; } 
        
        
        #nullable disable
        
    }
}
