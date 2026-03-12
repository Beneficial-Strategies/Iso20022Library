// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.SecurityIdentification23Choice
{
    /// <summary>
    /// Identifier for Dutch securities.
    /// </summary>
    [IsoId("_CSq4RSGQEeW7gKYhAMEFCw")]
    [DisplayName("Dutch")]
    public partial record Dutch : SecurityIdentification23Choice_
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
