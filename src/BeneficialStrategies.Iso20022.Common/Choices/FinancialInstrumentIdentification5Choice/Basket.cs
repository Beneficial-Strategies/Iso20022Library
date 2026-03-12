// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.FinancialInstrumentIdentification5Choice
{
    /// <summary>
    /// Instrument consists of multiple instruments.
    /// </summary>
    [IsoId("_HQWTw35aEea2k7EBUopqxw")]
    [DisplayName("Basket")]
    public partial record Basket : FinancialInstrumentIdentification5Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Identifies the financial instrument using an ISIN.
        /// </summary>
        [IsoId("_a46r4fBqEeWTAY6i--T_aA")]
        [DisplayName("ISIN")]
        [IsoXmlTag("ISIN")]
        [IsoSimpleType(IsoSimpleType.ISINOct2015Identifier)]
        public IsoISINOct2015Identifier? ISIN { get; init; } 
        
        /// <summary>
        /// The LEI code of the issuer where the instrument is referring to an issuer rather than one single instrument.
        /// </summary>
        [IsoId("_a46r4vBqEeWTAY6i--T_aA")]
        [DisplayName("LEI")]
        [IsoXmlTag("LEI")]
        [IsoSimpleType(IsoSimpleType.LEIIdentifier)]
        public IsoLEIIdentifier? LEI { get; init; } 
        
        
        #nullable disable
        
    }
}
