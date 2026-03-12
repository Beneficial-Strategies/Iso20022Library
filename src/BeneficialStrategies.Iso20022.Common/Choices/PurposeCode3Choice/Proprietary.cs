// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.PurposeCode3Choice
{
    /// <summary>
    /// Account type is defined using a data source scheme.
    /// </summary>
    [IsoId("_XN-Ak9p-Ed-ak6NoX_4Aeg_-821611512")]
    [DisplayName("Proprietary")]
    public partial record Proprietary : PurposeCode3Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Identification assigned by an institution.
        /// </summary>
        [IsoId("_WelLBtp-Ed-ak6NoX_4Aeg_-1431823633")]
        [DisplayName("Identification")]
        [IsoXmlTag("Id")]
        [IsoSimpleType(IsoSimpleType.Max4AlphaNumericText)]
        [StringLength(maximumLength: 4 ,MinimumLength = 1)]
        public required IsoMax4AlphaNumericText Identification { get; init; } 
        
        /// <summary>
        /// Name of the identification scheme.
        /// </summary>
        [IsoId("_WelLB9p-Ed-ak6NoX_4Aeg_868998957")]
        [DisplayName("Scheme Name")]
        [IsoXmlTag("SchmeNm")]
        [IsoSimpleType(IsoSimpleType.Max4AlphaNumericText)]
        [StringLength(maximumLength: 4 ,MinimumLength = 1)]
        public IsoMax4AlphaNumericText? SchemeName { get; init; } 
        
        /// <summary>
        /// Entity that assigns the identification.
        /// </summary>
        [IsoId("_WelLCNp-Ed-ak6NoX_4Aeg_573897572")]
        [DisplayName("Issuer")]
        [IsoXmlTag("Issr")]
        [IsoSimpleType(IsoSimpleType.Max4AlphaNumericText)]
        [StringLength(maximumLength: 4 ,MinimumLength = 1)]
        public required IsoMax4AlphaNumericText Issuer { get; init; } 
        
        
        #nullable disable
        
    }
}
