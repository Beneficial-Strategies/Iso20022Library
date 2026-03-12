// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.IdentificationType2Choice
{
    /// <summary>
    /// Type of identification is defined using a data source scheme.
    /// </summary>
    [IsoId("_Q-eYcNp-Ed-ak6NoX_4Aeg_111930734")]
    [DisplayName("Proprietary")]
    public partial record Proprietary : IdentificationType2Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Identification assigned by an institution.
        /// </summary>
        [IsoId("_P_u4Qtp-Ed-ak6NoX_4Aeg_1162128718")]
        [DisplayName("Identification")]
        [IsoXmlTag("Id")]
        [IsoSimpleType(IsoSimpleType.Max4AlphaNumericText)]
        [StringLength(maximumLength: 4 ,MinimumLength = 1)]
        public required IsoMax4AlphaNumericText Identification { get; init; } 
        
        /// <summary>
        /// Name of the identification scheme.
        /// </summary>
        [IsoId("_P_u4Q9p-Ed-ak6NoX_4Aeg_1162128838")]
        [DisplayName("Scheme Name")]
        [IsoXmlTag("SchmeNm")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        public IsoMax35Text? SchemeName { get; init; } 
        
        /// <summary>
        /// Entity that assigns the identification.
        /// </summary>
        [IsoId("_P_u4RNp-Ed-ak6NoX_4Aeg_1162128778")]
        [DisplayName("Issuer")]
        [IsoXmlTag("Issr")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        public required IsoMax35Text Issuer { get; init; } 
        
        
        #nullable disable
        
    }
}
