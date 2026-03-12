// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.References2Choice
{
    /// <summary>
    /// Reference to a transaction that cannot be identified using a standard reference element present in the message.
    /// </summary>
    [IsoId("_US9oDdp-Ed-ak6NoX_4Aeg_1139340685")]
    [DisplayName("Other Transaction Identification")]
    public partial record OtherTransactionIdentification : References2Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Message type number/message identifier of the message referenced in the linkage sequence.
        /// </summary>
        [IsoId("_QtVlJdp-Ed-ak6NoX_4Aeg_-2104392897")]
        [DisplayName("Message Number")]
        [IsoXmlTag("MsgNb")]
        public DocumentNumber1Choice_? MessageNumber { get; init; } 
        
        /// <summary>
        /// Identification of the document.
        /// </summary>
        [IsoId("_QtVlJtp-Ed-ak6NoX_4Aeg_981420472")]
        [DisplayName("Identification")]
        [IsoXmlTag("Id")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        public required IsoMax35Text Identification { get; init; } 
        
        
        #nullable disable
        
    }
}
