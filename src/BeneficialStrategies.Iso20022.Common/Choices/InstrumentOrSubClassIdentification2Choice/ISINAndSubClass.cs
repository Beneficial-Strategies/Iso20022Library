// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.InstrumentOrSubClassIdentification2Choice
{
    /// <summary>
    /// Identifies the financial instrument to which the result relates and its sub-class among non-equity instruments
    /// </summary>
    [IsoId("_BSnWYaaUEeqZmriXpMtonA")]
    [DisplayName("ISIN And Sub Class")]
    public partial record ISINAndSubClass : InstrumentOrSubClassIdentification2Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Identifies the financial instrument using an ISIN.
        /// </summary>
        [IsoId("_GWXkIaaUEeqZmriXpMtonA")]
        [DisplayName("ISIN")]
        [IsoXmlTag("ISIN")]
        [IsoSimpleType(IsoSimpleType.ISINOct2015Identifier)]
        public required IsoISINOct2015Identifier ISIN { get; init; } 
        
        /// <summary>
        /// Sub class of non-equity instruments to which the instrument belongs.
        /// </summary>
        [IsoId("_GWXkI6aUEeqZmriXpMtonA")]
        [DisplayName("Derivative Sub Class")]
        [IsoXmlTag("DerivSubClss")]
        public NonEquitySubClass1? DerivativeSubClass { get; init; } 
        
        /// <summary>
        /// Identification of non-equity financial instruments.
        /// </summary>
        [IsoId("_GWXkJaaUEeqZmriXpMtonA")]
        [DisplayName("Financial Instrument Classification")]
        [IsoXmlTag("FinInstrmClssfctn")]
        public NonEquityInstrumentReportingClassification1Code? FinancialInstrumentClassification { get; init; } 
        
        
        #nullable disable
        
    }
}
