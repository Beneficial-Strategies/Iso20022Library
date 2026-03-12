// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.SecurityIdentification25Choice
{
    /// <summary>
    /// Identifier of a security assigned by the Bloomberg organisation.
    /// </summary>
    [IsoId("_cH1L7TnxEeabspMEjqY5TQ")]
    [DisplayName("Bloomberg")]
    public partial record Bloomberg : SecurityIdentification25Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// An identifier of a security assigned by the Bloomberg organisation.
        /// </summary>
        [IsoXmlTag("Blmbrg")]
        [IsoSimpleType(IsoSimpleType.Bloomberg2Identifier)]
        public required IsoBloomberg2Identifier Value { get; init; } 
        
        
        #nullable disable
        
    }
}
