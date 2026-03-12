// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.FinancialInstrumentIdentification6Choice
{
    /// <summary>
    /// Index on which the financial instrument is based.
    /// </summary>
    [IsoId("_Iuqr435aEea2k7EBUopqxw")]
    [DisplayName("Index")]
    public partial record Index : FinancialInstrumentIdentification6Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Identification of the index on which the financial instrument is based.
        /// </summary>
        [IsoId("_HhTg4X5aEea2k7EBUopqxw")]
        [DisplayName("ISIN")]
        [IsoXmlTag("ISIN")]
        [IsoSimpleType(IsoSimpleType.ISINOct2015Identifier)]
        public IsoISINOct2015Identifier? ISIN { get; init; } 
        
        /// <summary>
        /// Name of the index on which the financial instrument is based.
        /// </summary>
        [IsoId("_HhTg435aEea2k7EBUopqxw")]
        [DisplayName("Name")]
        [IsoXmlTag("Nm")]
        public required FloatingInterestRate8 Name { get; init; } 
        
        
        #nullable disable
        
    }
}
