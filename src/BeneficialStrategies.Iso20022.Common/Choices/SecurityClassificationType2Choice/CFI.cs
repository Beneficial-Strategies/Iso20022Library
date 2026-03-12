// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.SecurityClassificationType2Choice
{
    /// <summary>
    /// Classification type of the financial instrument, as per the ISO 10962 Classification of Financial Instrument (CFI) codification.
    /// </summary>
    [IsoId("_T81ZQW1MEeiqaPNRWUnGNA")]
    [DisplayName("CFI")]
    public partial record CFI : SecurityClassificationType2Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Classification type of the financial instrument, as per the ISO 10962 Classification of Financial Instrument (CFI) codification, for example, common share with voting rights, fully paid, or registered.
        /// </summary>
        [IsoXmlTag("CFI")]
        [IsoSimpleType(IsoSimpleType.CFIOct2015Identifier)]
        public required IsoCFIOct2015Identifier Value { get; init; } 
        
        
        #nullable disable
        
    }
}
