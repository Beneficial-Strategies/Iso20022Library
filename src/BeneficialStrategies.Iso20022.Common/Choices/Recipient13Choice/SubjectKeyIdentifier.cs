// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.Recipient13Choice
{
    /// <summary>
    /// Specifies the recipient&apos;s certificate by a key identifier.
    /// </summary>
    [IsoId("_d9kLgHDDEe2MCaKO5AtGsA")]
    [DisplayName("Subject Key Identifier")]
    public partial record SubjectKeyIdentifier : Recipient13Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies a binary string with a maximum length of 140 binary bytes.
        /// </summary>
        [IsoXmlTag("SbjtKeyIdr")]
        [IsoSimpleType(IsoSimpleType.Max140Binary)]
        public required IsoMax140Binary Value { get; init; } 
        
        
        #nullable disable
        
    }
}
