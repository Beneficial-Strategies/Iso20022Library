// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.VerificationValue1Choice
{
    /// <summary>
    /// Value of the data expressed in text form.
    /// </summary>
    [IsoId("_4EhKqZaNEemfCcEf5rVTyg")]
    [DisplayName("Text Value")]
    public partial record TextValue : VerificationValue1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies a character string with a maximum length of 2048 characters.
        /// </summary>
        [IsoXmlTag("TxtVal")]
        [IsoSimpleType(IsoSimpleType.Max2048Text)]
        [StringLength(maximumLength: 2048 ,MinimumLength = 1)]
        public required IsoMax2048Text Value { get; init; } 
        
        
        #nullable disable
        
    }
}
