// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.References44Choice
{
    /// <summary>
    /// Reference to a transaction that cannot be identified using a standard reference element present in the message.
    /// </summary>
    [IsoId("_IIcaszqoEeWyoP0PbocV1Q")]
    [DisplayName("Other Transaction Identification")]
    public partial record OtherTransactionIdentification : References44Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Message type number/message identifier of the message referenced in the linkage sequence.
        /// </summary>
        [IsoId("_RbgBwztpEeWHYdqXF6YZmg")]
        [DisplayName("Message Number")]
        [IsoXmlTag("MsgNb")]
        public DocumentNumber5Choice_? MessageNumber { get; init; } 
        
        /// <summary>
        /// Identification of the document.
        /// </summary>
        [IsoId("_RbgByztpEeWHYdqXF6YZmg")]
        [DisplayName("Identification")]
        [IsoXmlTag("Id")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        public required IsoMax35Text Identification { get; init; } 
        
        
        #nullable disable
        
    }
}
