// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.FinancialInstrumentIdentification8Choice
{
    /// <summary>
    /// Instrument consists of multiple instruments.
    /// </summary>
    [IsoId("_26V3k53DEeuwmdq0KtnICg")]
    [DisplayName("Basket")]
    public partial record Basket : FinancialInstrumentIdentification8Choice_
    {
        #nullable enable
        
        /// <summary>
        /// International Securities Identification Number (ISIN). A numbering system designed by the United Nation&apos;s International Organisation for Standardisation (ISO). The ISIN is composed of a 2-character prefix representing the country of issue, followed by the national security number (if one exists), and a check digit. Each country has a national numbering agency that assigns ISIN numbers for securities in that country.
        /// </summary>
        [IsoId("_FvixQZ3EEeuwmdq0KtnICg")]
        [DisplayName("ISIN")]
        [IsoXmlTag("ISIN")]
        [IsoSimpleType(IsoSimpleType.ISIN2021Identifier)]
        public IsoISIN2021Identifier? ISIN { get; init; } 
        
        /// <summary>
        /// Index on which the financial instrument is based.
        /// </summary>
        [IsoId("_FvixQ53EEeuwmdq0KtnICg")]
        [DisplayName("Index")]
        [IsoXmlTag("Indx")]
        public FinancialInstrument98? Index { get; init; } 
        
        
        #nullable disable
        
    }
}
