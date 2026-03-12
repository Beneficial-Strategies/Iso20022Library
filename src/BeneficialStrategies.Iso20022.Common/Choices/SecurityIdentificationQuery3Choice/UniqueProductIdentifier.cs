// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.SecurityIdentificationQuery3Choice
{
    /// <summary>
    /// Identification through a unique product identifier.
    /// </summary>
    [IsoId("_P-19B9GgEeaQk737TH1Fzw")]
    [DisplayName("Unique Product Identifier")]
    public partial record UniqueProductIdentifier : SecurityIdentificationQuery3Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies a character string with a maximum length of 52 characters.
        /// </summary>
        [IsoXmlTag("UnqPdctIdr")]
        [IsoSimpleType(IsoSimpleType.Max52Text)]
        [StringLength(maximumLength: 52 ,MinimumLength = 1)]
        public required IsoMax52Text Value { get; init; } 
        
        
        #nullable disable
        
    }
}
