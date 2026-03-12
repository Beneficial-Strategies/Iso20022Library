// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.SecurityIdentification41Choice
{
    /// <summary>
    /// Indicates the index upon which the financial instrument is based.
    /// </summary>
    [IsoId("_idD06Vo2Ee23K4GXSpBSeg")]
    [DisplayName("Index")]
    public partial record Index : SecurityIdentification41Choice_
    {
        #nullable enable
        
        /// <summary>
        /// International Securities Identification Number (ISIN). A numbering system designed by the United Nation&apos;s International Organisation for Standardisation (ISO). The ISIN is composed of a 2-character prefix representing the country of issue, followed by the national security number (if one exists), and a check digit. Each country has a national numbering agency that assigns ISIN numbers for securities in that country.
        /// </summary>
        [IsoId("_bs8aEDN1Ee2gE4h-lpiUxQ")]
        [DisplayName("ISIN")]
        [IsoXmlTag("ISIN")]
        [IsoSimpleType(IsoSimpleType.ISINOct2015Identifier)]
        public IsoISINOct2015Identifier? ISIN { get; init; } 
        
        /// <summary>
        /// Proprietary identification of the index on which the financial instrument is based.
        /// </summary>
        [IsoId("_bs7zATN1Ee2gE4h-lpiUxQ")]
        [DisplayName("Name")]
        [IsoXmlTag("Nm")]
        [IsoSimpleType(IsoSimpleType.Max350Text)]
        [StringLength(maximumLength: 350 ,MinimumLength = 1)]
        public IsoMax350Text? Name { get; init; } 
        
        /// <summary>
        /// Index name where the underlying is an index.
        /// </summary>
        [IsoXmlTag("Indx")]
        public ExternalBenchmarkCurveName1Code? Value { get; init; } 
        
        
        #nullable disable
        
    }
}
