// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.AccountIdentification54Choice
{
    /// <summary>
    /// Mobile Subscriber Integrated Service Digital Network (i.e. mobile phone number of the SIM card).
    /// </summary>
    [IsoId("_5q1Fo1HSEey4xOoMoOPSJQ")]
    [DisplayName("MSISDN")]
    public partial record MSISDN : AccountIdentification54Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies a character string with a maximum length of 16 characters.
        /// </summary>
        [IsoXmlTag("MSISDN")]
        [IsoSimpleType(IsoSimpleType.Max16Text)]
        [StringLength(maximumLength: 16 ,MinimumLength = 1)]
        public required IsoMax16Text Value { get; init; } 
        
        
        #nullable disable
        
    }
}
