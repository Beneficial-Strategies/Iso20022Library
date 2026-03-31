// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.IdentificationFormat4Choice
{
    /// <summary>
    /// Format expressed as a proprietary identification.
    /// </summary>
    [IsoId("_c5VTR5KQEeWHWpTQn1FFVg")]
    [DisplayName("Proprietary Identification")]
    [IsoXmlTag("PrtryId")]
    public record ProprietaryIdentification : IdentificationFormat4Choice_
    {
        /// <summary>
        /// Proprietary information, often a code, issued by the data source scheme issuer.
        /// </summary>
        [IsoId("_cel3oZKQEeWHWpTQn1FFVg")]
        [DisplayName("Identification")]
        [IsoXmlTag("Id")]
        [IsoSimpleType(IsoSimpleType.RestrictedFINXMax30Text)]
        [StringLength(maximumLength: 30, MinimumLength = 1)]
        public required IsoRestrictedFINXMax30Text Identification { get; init; }

        /// <summary>
        /// Entity that assigns the identification.
        /// </summary>
        [IsoId("_cel3o5KQEeWHWpTQn1FFVg")]
        [DisplayName("Issuer")]
        [IsoXmlTag("Issr")]
        [IsoSimpleType(IsoSimpleType.Max4AlphaNumericText)]
        [StringLength(maximumLength: 4, MinimumLength = 1)]
        public required IsoMax4AlphaNumericText Issuer { get; init; }

        /// <summary>
        /// Short textual description of the scheme.
        /// </summary>
        [IsoId("_cel3pZKQEeWHWpTQn1FFVg")]
        [DisplayName("Scheme Name")]
        [IsoXmlTag("SchmeNm")]
        [IsoSimpleType(IsoSimpleType.Max4AlphaNumericText)]
        [StringLength(maximumLength: 4, MinimumLength = 1)]
        public IsoMax4AlphaNumericText? SchemeName { get; init; }
    }
}
