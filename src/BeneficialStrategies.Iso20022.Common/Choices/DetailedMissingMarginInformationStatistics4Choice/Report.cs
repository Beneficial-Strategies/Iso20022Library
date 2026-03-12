// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.DetailedMissingMarginInformationStatistics4Choice
{
    /// <summary>
    /// Detailed information on statistics per combination of counterparties.
    /// </summary>
    [IsoId("_rsDiw1owEe23K4GXSpBSeg")]
    [DisplayName("Report")]
    public partial record Report : DetailedMissingMarginInformationStatistics4Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Number of outstanding derivatives. 
        /// </summary>
        [IsoId("_rtPOgVowEe23K4GXSpBSeg")]
        [DisplayName("Number Of Outstanding Derivatives")]
        [IsoXmlTag("NbOfOutsdngDerivs")]
        [IsoSimpleType(IsoSimpleType.Number)]
        public required IsoNumber NumberOfOutstandingDerivatives { get; init; } 
        
        /// <summary>
        /// Number of outstanding derivatives with no margin information.
        /// </summary>
        [IsoId("_rtPOg1owEe23K4GXSpBSeg")]
        [DisplayName("Number Of Outstanding Derivatives With No Margin Information")]
        [IsoXmlTag("NbOfOutsdngDerivsWthNoMrgnInf")]
        [IsoSimpleType(IsoSimpleType.Number)]
        public required IsoNumber NumberOfOutstandingDerivativesWithNoMarginInformation { get; init; } 
        
        /// <summary>
        /// Number of outstanding derivatives with outdated margin information.
        /// </summary>
        [IsoId("_rtPOhVowEe23K4GXSpBSeg")]
        [DisplayName("Number Of Outstanding Derivatives With Outdated Margin Information")]
        [IsoXmlTag("NbOfOutsdngDerivsWthOutdtdMrgnInf")]
        [IsoSimpleType(IsoSimpleType.Number)]
        public required IsoNumber NumberOfOutstandingDerivativesWithOutdatedMarginInformation { get; init; } 
        
        /// <summary>
        /// Details of the outstanding derivatives for which no margin information has been reported, or the margin information that was reported is dated more than fourteen calendar days earlier than the day.
        /// </summary>
        [IsoId("_rtPOh1owEe23K4GXSpBSeg")]
        [DisplayName("Warnings")]
        [IsoXmlTag("Wrnngs")]
        public ValueList<MissingMarginData2> Warnings { get; init; } = new ValueList<MissingMarginData2>(){}; // Warning: Don't know multiplicity.
        // ID for the above is _rtPOh1owEe23K4GXSpBSeg
        
        
        #nullable disable
        
    }
}
