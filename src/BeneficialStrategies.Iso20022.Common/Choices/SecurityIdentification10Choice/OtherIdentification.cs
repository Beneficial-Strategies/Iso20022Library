// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.SecurityIdentification10Choice
{
    /// <summary>
    /// Proprietary identification of a security assigned by an institution or organisation.
    /// </summary>
    [IsoId("_RiPM0dp-Ed-ak6NoX_4Aeg_1344791266")]
    [DisplayName("Other Identification")]
    public partial record OtherIdentification : SecurityIdentification10Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Unique and unambiguous identifier of a security.
        /// </summary>
        [IsoId("_SlI0RNp-Ed-ak6NoX_4Aeg_735401045")]
        [DisplayName("Identification")]
        [IsoXmlTag("Id")]
        [IsoSimpleType(IsoSimpleType.Max70Text)]
        [StringLength(maximumLength: 70 ,MinimumLength = 1)]
        public required IsoMax70Text Identification { get; init; } 
        
        /// <summary>
        /// Country of the proprietary identification scheme.
        /// </summary>
        [IsoId("_SlI0Rdp-Ed-ak6NoX_4Aeg_735400907")]
        [DisplayName("Domestic Identification Source")]
        [IsoXmlTag("DmstIdSrc")]
        public required CountryCode DomesticIdentificationSource { get; init; } 
        
        /// <summary>
        /// Entity that issues the proprietary identification.
        /// </summary>
        [IsoId("_SlI0Rtp-Ed-ak6NoX_4Aeg_735400960")]
        [DisplayName("Proprietary Identification Source")]
        [IsoXmlTag("PrtryIdSrc")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        public required IsoMax35Text ProprietaryIdentificationSource { get; init; } 
        
        
        #nullable disable
        
    }
}
