// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.UniqueTransactionIdentifier1Choice
{
    /// <summary>
    /// Frequency expressed in a proprietary notation.
    /// </summary>
    [IsoId("_yq1bcQxeEeuoAcnnpX2x_w")]
    [DisplayName("Proprietary")]
    public partial record Proprietary : UniqueTransactionIdentifier1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Identification of the lot, according to a data source scheme. Used to indicate which processing to apply to the corresponding market value amount.
        /// </summary>
        [IsoId("_fe2HtQxeEeuoAcnnpX2x_w")]
        [DisplayName("Identification")]
        [IsoXmlTag("Id")]
        [IsoSimpleType(IsoSimpleType.Max52Text)]
        [StringLength(maximumLength: 52 ,MinimumLength = 1)]
        public required IsoMax52Text Identification { get; init; } 
        
        /// <summary>
        /// Entity that assigns the identification.
        /// </summary>
        [IsoId("_fe2HtAxeEeuoAcnnpX2x_w")]
        [DisplayName("Issuer")]
        [IsoXmlTag("Issr")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        public IsoMax35Text? Issuer { get; init; } 
        
        
        #nullable disable
        
    }
}
