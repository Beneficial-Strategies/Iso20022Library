// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.IdentificationReference16Choice
{
    /// <summary>
    /// Client Order Link Identification.
    /// </summary>
    [DisplayName("Client Order Link Identification")]
    public partial record ClientOrderLinkIdentification : IdentificationReference16Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("ClntOrdrLkId")]
        public required IsoMax35Text Value { get; init; } 
        
        
        #nullable disable
        
    }
}
