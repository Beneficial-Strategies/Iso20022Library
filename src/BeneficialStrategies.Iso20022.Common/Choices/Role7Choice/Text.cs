// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.Role7Choice
{
    /// <summary>
    /// Role of the party in the activity.
    /// </summary>
    [IsoId("_5WyhB5NLEeWGlc8L7oPDIg")]
    [DisplayName("Text")]
    public partial record Text : Role7Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies a character string with a maximum length of 350 characters limited to character set X, that is, a-z A-Z / - ? : ( ) . , ‘ + .
        /// </summary>
        [IsoXmlTag("Txt")]
        [IsoSimpleType(IsoSimpleType.RestrictedFINXMax350Text)]
        [StringLength(maximumLength: 350 ,MinimumLength = 1)]
        public required IsoRestrictedFINXMax350Text Value { get; init; } 
        
        
        #nullable disable
        
    }
}
