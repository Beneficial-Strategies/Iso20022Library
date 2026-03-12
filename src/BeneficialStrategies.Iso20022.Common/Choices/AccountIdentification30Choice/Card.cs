// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.AccountIdentification30Choice
{
    /// <summary>
    /// PAN of the card identifying the account.
    /// </summary>
    [IsoId("_ASh-UHs9EeSTS7uHCe8FPQ")]
    [DisplayName("Card")]
    public partial record Card : AccountIdentification30Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies a numeric string with a minimum length of 8 digits, and a maximum length of 28 digits.
        /// </summary>
        [IsoXmlTag("Card")]
        [IsoSimpleType(IsoSimpleType.Min8Max28NumericText)]
        public required IsoMin8Max28NumericText Value { get; init; } 
        
        
        #nullable disable
        
    }
}
