// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.IdentificationFormat3Choice
{
    /// <summary>
    /// Format expressed as a long identification.
    /// </summary>
    [IsoId("_qmP-eUEFEeWVgfuHGaKtRQ")]
    [DisplayName("Long Identification")]
    public partial record LongIdentification : IdentificationFormat3Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies a character string with a maximum length of 30 characters.
        /// </summary>
        [IsoXmlTag("LngId")]
        [IsoSimpleType(IsoSimpleType.Max30Text)]
        public required IsoMax30Text Value { get; init; } 
        
        
        #nullable disable
        
    }
}
