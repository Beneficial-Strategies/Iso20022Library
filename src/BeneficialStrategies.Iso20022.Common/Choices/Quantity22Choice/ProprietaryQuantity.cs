// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.Quantity22Choice
{
    /// <summary>
    /// Proprietary quantity of security format.
    /// </summary>
    [IsoId("_cfsEWZKQEeWHWpTQn1FFVg")]
    [DisplayName("Proprietary Quantity")]
    public partial record ProprietaryQuantity : Quantity22Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Sign of the quantity of security.
        /// </summary>
        [IsoId("_cfsEmZKQEeWHWpTQn1FFVg")]
        [DisplayName("Short Long Position")]
        [IsoXmlTag("ShrtLngPos")]
        public ShortLong1Code? ShortLongPosition { get; init; } 
        
        /// <summary>
        /// Provides the proprietary quantity with a decimal number.
        /// </summary>
        [IsoId("_cfsEm5KQEeWHWpTQn1FFVg")]
        [DisplayName("Quantity")]
        [IsoXmlTag("Qty")]
        [IsoSimpleType(IsoSimpleType.RestrictedFINDecimalNumber)]
        public required IsoRestrictedFINDecimalNumber Quantity { get; init; } 
        
        /// <summary>
        /// Identifies the type of proprietary quantity reported.
        /// </summary>
        [IsoId("_cfsEnZKQEeWHWpTQn1FFVg")]
        [DisplayName("Quantity Type")]
        [IsoXmlTag("QtyTp")]
        [IsoSimpleType(IsoSimpleType.Exact4AlphaNumericText)]
        public required IsoExact4AlphaNumericText QuantityType { get; init; } 
        
        /// <summary>
        /// Provides information related to issuer in free format.
        /// </summary>
        [IsoId("_cfsEn5KQEeWHWpTQn1FFVg")]
        [DisplayName("Issuer")]
        [IsoXmlTag("Issr")]
        [IsoSimpleType(IsoSimpleType.Max4AlphaNumericText)]
        [StringLength(maximumLength: 4 ,MinimumLength = 1)]
        public required IsoMax4AlphaNumericText Issuer { get; init; } 
        
        /// <summary>
        /// Name of the identification scheme.
        /// </summary>
        [IsoId("_cfsEp5KQEeWHWpTQn1FFVg")]
        [DisplayName("Scheme Name")]
        [IsoXmlTag("SchmeNm")]
        [IsoSimpleType(IsoSimpleType.Max4AlphaNumericText)]
        [StringLength(maximumLength: 4 ,MinimumLength = 1)]
        public IsoMax4AlphaNumericText? SchemeName { get; init; } 
        
        
        #nullable disable
        
    }
}
