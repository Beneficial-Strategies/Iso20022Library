// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.Quantity48Choice
{
    /// <summary>
    /// Proprietary quantity of security format.
    /// </summary>
    [IsoId("_KADDMxuyEeyhRdHRjakS2w")]
    [DisplayName("Proprietary Quantity")]
    public partial record ProprietaryQuantity : Quantity48Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Provides the proprietary quantity with a decimal number.
        /// </summary>
        [IsoId("_zPUVFTq6EeWQ1Y7f8kds2A")]
        [DisplayName("Quantity")]
        [IsoXmlTag("Qty")]
        [IsoSimpleType(IsoSimpleType.DecimalNumber)]
        public required IsoDecimalNumber Quantity { get; init; } 
        
        /// <summary>
        /// Identifies the type of proprietary quantity reported.
        /// </summary>
        [IsoId("_zPUVFzq6EeWQ1Y7f8kds2A")]
        [DisplayName("Quantity Type")]
        [IsoXmlTag("QtyTp")]
        [IsoSimpleType(IsoSimpleType.Exact4AlphaNumericText)]
        public required IsoExact4AlphaNumericText QuantityType { get; init; } 
        
        /// <summary>
        /// Provides information related to issuer in free format.
        /// </summary>
        [IsoId("_zPUVGTq6EeWQ1Y7f8kds2A")]
        [DisplayName("Issuer")]
        [IsoXmlTag("Issr")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        public required IsoMax35Text Issuer { get; init; } 
        
        /// <summary>
        /// Name of the identification scheme.
        /// </summary>
        [IsoId("_zPUVITq6EeWQ1Y7f8kds2A")]
        [DisplayName("Scheme Name")]
        [IsoXmlTag("SchmeNm")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        public IsoMax35Text? SchemeName { get; init; } 
        
        
        #nullable disable
        
    }
}
