// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.SecurityIdentification34Choice
{
    /// <summary>
    /// Indicates that underlying identification is not available.
    /// </summary>
    [IsoId("_Zlr-qw1HEeqV4s5SpzR1dQ")]
    [DisplayName("Identification Not Available")]
    public partial record IdentificationNotAvailable : SecurityIdentification34Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the type of the underlying identification.
        /// </summary>
        [IsoXmlTag("IdNotAvlbl")]
        public required UnderlyingIdentification1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
