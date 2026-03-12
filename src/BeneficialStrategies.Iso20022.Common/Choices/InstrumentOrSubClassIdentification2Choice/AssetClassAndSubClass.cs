// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.InstrumentOrSubClassIdentification2Choice
{
    /// <summary>
    /// Identifies the asset class and sub-class of non-equity instruments to which the result relates
    /// </summary>
    [IsoId("_BSnWY6aUEeqZmriXpMtonA")]
    [DisplayName("Asset Class And Sub Class")]
    public partial record AssetClassAndSubClass : InstrumentOrSubClassIdentification2Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Asset class of non-equity instruments to which the result relates
        /// </summary>
        [IsoId("_cBU0saaUEeqZmriXpMtonA")]
        [DisplayName("Asset Class")]
        [IsoXmlTag("AsstClss")]
        public required NonEquityAssetClass1Code AssetClass { get; init; } 
        
        /// <summary>
        /// Sub class of non-equity instruments to which the result relates, as defined in the local regulation.
        /// </summary>
        [IsoId("_cBU0s6aUEeqZmriXpMtonA")]
        [DisplayName("Derivative Sub Class")]
        [IsoXmlTag("DerivSubClss")]
        public NonEquitySubClass1? DerivativeSubClass { get; init; } 
        
        /// <summary>
        /// Identification of non-equity financial instruments.
        /// </summary>
        [IsoId("_cBU0taaUEeqZmriXpMtonA")]
        [DisplayName("Financial Instrument Classification")]
        [IsoXmlTag("FinInstrmClssfctn")]
        public NonEquityInstrumentReportingClassification1Code? FinancialInstrumentClassification { get; init; } 
        
        
        #nullable disable
        
    }
}
