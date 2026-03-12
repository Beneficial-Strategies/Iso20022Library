// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.Purpose3Choice
{
    /// <summary>
    /// Underlying reason for the SSI instruction, expressed as a code.
    /// </summary>
    [IsoId("_KU6yQyUOEeOgKIHGINc2Uw")]
    [DisplayName("Securities Purpose Code")]
    public partial record SecuritiesPurposeCode : Purpose3Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the underlying reason code for an SSI instruction, in the format of character string with a maximum length of 4 characters.
        /// The list of valid codes is an external code list published separately. External code sets can be downloaded from www.iso20022.org.
        /// External code sets can be downloaded from www.iso20022.org.
        /// </summary>
        [IsoXmlTag("SctiesPurpCd")]
        public required ExternalSecuritiesPurpose1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
