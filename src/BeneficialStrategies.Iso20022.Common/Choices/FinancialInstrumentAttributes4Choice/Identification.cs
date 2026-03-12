// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.FinancialInstrumentAttributes4Choice
{
    /// <summary>
    /// Identification of a financial instrument admitted to trading.
    /// </summary>
    [IsoId("_GMbzgZ3CEeuwmdq0KtnICg")]
    [DisplayName("Identification")]
    public partial record Identification : FinancialInstrumentAttributes4Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// International Securities Identification Number (ISIN). A numbering system designed by the United Nation&apos;s International Organisation for Standardisation (ISO). The ISIN is composed of a 2-character prefix representing the country of issue, followed by the national security number (if one exists), and a check digit. Each country has a national numbering agency that assigns ISIN numbers for securities in that country.
        /// </summary>
        [IsoXmlTag("Id")]
        [IsoSimpleType(IsoSimpleType.ISIN2021Identifier)]
        public required IsoISIN2021Identifier Value { get; init; } 
        
        
        #nullable disable
        
    }
}
