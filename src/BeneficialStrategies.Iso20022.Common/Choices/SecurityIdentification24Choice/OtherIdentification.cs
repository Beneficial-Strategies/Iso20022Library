// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.SecurityIdentification24Choice
{
    /// <summary>
    /// Proprietary identification of a security assigned by an institution or organisation.
    /// </summary>
    [IsoId("_jUg4o-GXEeWCAvUNsZ5u6g")]
    [DisplayName("Other Identification")]
    public partial record OtherIdentification : SecurityIdentification24Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Unique and unambiguous identifier of a security.
        /// </summary>
        [IsoId("_64vPkR5VEeWFEfGJQFSF5w")]
        [DisplayName("Identification")]
        [IsoXmlTag("Id")]
        [IsoSimpleType(IsoSimpleType.Max70Text)]
        [StringLength(maximumLength: 70 ,MinimumLength = 1)]
        public required IsoMax70Text Identification { get; init; } 
        
        /// <summary>
        /// Source of the security identification.
        /// </summary>
        [IsoId("_64vPkx5VEeWFEfGJQFSF5w")]
        [DisplayName("Identification Source")]
        [IsoXmlTag("IdSrc")]
        public required IdentificationSource1Choice_ IdentificationSource { get; init; } 
        
        
        #nullable disable
        
    }
}
