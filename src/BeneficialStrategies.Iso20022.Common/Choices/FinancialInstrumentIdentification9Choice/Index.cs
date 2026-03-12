// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.FinancialInstrumentIdentification9Choice
{
    /// <summary>
    /// Index on which the financial instrument is based.
    /// </summary>
    [IsoId("_3V6ZQ53DEeuwmdq0KtnICg")]
    [DisplayName("Index")]
    public partial record Index : FinancialInstrumentIdentification9Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Identification of the index on which the financial instrument is based.
        /// </summary>
        [IsoId("_GHFukZ3EEeuwmdq0KtnICg")]
        [DisplayName("ISIN")]
        [IsoXmlTag("ISIN")]
        [IsoSimpleType(IsoSimpleType.ISIN2021Identifier)]
        public IsoISIN2021Identifier? ISIN { get; init; } 
        
        /// <summary>
        /// Name of the index on which the financial instrument is based.
        /// </summary>
        [IsoId("_GHFuk53EEeuwmdq0KtnICg")]
        [DisplayName("Name")]
        [IsoXmlTag("Nm")]
        public required FloatingInterestRate8 Name { get; init; } 
        
        
        #nullable disable
        
    }
}
