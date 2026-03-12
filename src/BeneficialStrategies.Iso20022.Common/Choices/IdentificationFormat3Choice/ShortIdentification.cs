// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.IdentificationFormat3Choice
{
    /// <summary>
    /// Format expressed as a short identification.
    /// </summary>
    [IsoId("_qmP-cUEFEeWVgfuHGaKtRQ")]
    [DisplayName("Short Identification")]
    public partial record ShortIdentification : IdentificationFormat3Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies an upper case alphanumeric string with a length of three characters.
        /// </summary>
        [IsoXmlTag("ShrtId")]
        [IsoSimpleType(IsoSimpleType.Exact3UpperCaseAlphaNumericText)]
        public required IsoExact3UpperCaseAlphaNumericText Value { get; init; } 
        
        
        #nullable disable
        
    }
}
