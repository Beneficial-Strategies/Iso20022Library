// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.References49Choice
{
    /// <summary>
    /// Reference to a linked message that was previously received.
    /// </summary>
    [IsoId("_duUiYSYtEeW_ZNn8gbfY7Q")]
    [DisplayName("Related Reference")]
    public partial record RelatedReference : References49Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Message identification of a message. This reference was assigned by the party issuing the message.
        /// </summary>
        [IsoId("_JXg2MdedEeSA_uUacqhl1Q")]
        [DisplayName("Reference")]
        [IsoXmlTag("Ref")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        public required IsoMax35Text Reference { get; init; } 
        
        /// <summary>
        /// Issuer of the reference.
        /// </summary>
        [IsoId("_JXg2M9edEeSA_uUacqhl1Q")]
        [DisplayName("Reference Issuer")]
        [IsoXmlTag("RefIssr")]
        public PartyIdentification90Choice_? ReferenceIssuer { get; init; } 
        
        /// <summary>
        /// Name of the message.
        /// </summary>
        [IsoId("_JXg2NdedEeSA_uUacqhl1Q")]
        [DisplayName("Message Name")]
        [IsoXmlTag("MsgNm")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        public IsoMax35Text? MessageName { get; init; } 
        
        
        #nullable disable
        
    }
}
