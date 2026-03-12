// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.SecurityIdentification23Choice
{
    /// <summary>
    /// Identifier for Belgian securities.
    /// </summary>
    [IsoId("_CSq4SyGQEeW7gKYhAMEFCw")]
    [DisplayName("Belgian")]
    public partial record Belgian : SecurityIdentification23Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Identifier for Belgian securities.
        /// </summary>
        [IsoXmlTag("Belgn")]
        [IsoSimpleType(IsoSimpleType.BelgianIdentifier)]
        public required IsoBelgianIdentifier Value { get; init; } 
        
        
        #nullable disable
        
    }
}
