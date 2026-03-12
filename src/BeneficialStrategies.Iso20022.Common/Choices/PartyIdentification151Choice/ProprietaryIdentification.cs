// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.PartyIdentification151Choice
{
    /// <summary>
    /// Unique and unambiguous identifier, as assigned to a financial institution using a proprietary identification scheme.
    /// </summary>
    [IsoId("_ctD2X_fSEeiNZp_PtLohLw")]
    [DisplayName("Proprietary Identification")]
    public partial record ProprietaryIdentification : PartyIdentification151Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Proprietary information, often a code, issued by the data source scheme issuer.
        /// </summary>
        [IsoId("_cdRpUZKQEeWHWpTQn1FFVg")]
        [DisplayName("Identification")]
        [IsoXmlTag("Id")]
        [IsoSimpleType(IsoSimpleType.RestrictedFINXMax34Text)]
        [StringLength(maximumLength: 34 ,MinimumLength = 1)]
        public required IsoRestrictedFINXMax34Text Identification { get; init; } 
        
        /// <summary>
        /// Entity that assigns the identification.
        /// </summary>
        [IsoId("_cdRpU5KQEeWHWpTQn1FFVg")]
        [DisplayName("Issuer")]
        [IsoXmlTag("Issr")]
        [IsoSimpleType(IsoSimpleType.Max4AlphaNumericText)]
        [StringLength(maximumLength: 4 ,MinimumLength = 1)]
        public required IsoMax4AlphaNumericText Issuer { get; init; } 
        
        /// <summary>
        /// Short textual description of the scheme.
        /// </summary>
        [IsoId("_cdRpVZKQEeWHWpTQn1FFVg")]
        [DisplayName("Scheme Name")]
        [IsoXmlTag("SchmeNm")]
        [IsoSimpleType(IsoSimpleType.Max4AlphaNumericText)]
        [StringLength(maximumLength: 4 ,MinimumLength = 1)]
        public IsoMax4AlphaNumericText? SchemeName { get; init; } 
        
        
        #nullable disable
        
    }
}
