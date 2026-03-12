// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.SecurityIdentification4Choice
{
    /// <summary>
    /// Proprietary identification of an underlying financial instrument.
    /// </summary>
    [IsoId("_Qd1wmNp-Ed-ak6NoX_4Aeg_1865671289")]
    [DisplayName("Proprietary")]
    public partial record Proprietary : SecurityIdentification4Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Identifies the type of financial instrument identifier type.
        /// </summary>
        [IsoId("_SlSlRtp-Ed-ak6NoX_4Aeg_-1695096203")]
        [DisplayName("Type")]
        [IsoXmlTag("Tp")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        public required IsoMax35Text Type { get; init; } 
        
        /// <summary>
        /// Unique and unambiguous identifier of a security.
        /// </summary>
        [IsoId("_SlSlR9p-Ed-ak6NoX_4Aeg_-1695095831")]
        [DisplayName("Identification")]
        [IsoXmlTag("Id")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        public required IsoMax35Text Identification { get; init; } 
        
        
        #nullable disable
        
    }
}
