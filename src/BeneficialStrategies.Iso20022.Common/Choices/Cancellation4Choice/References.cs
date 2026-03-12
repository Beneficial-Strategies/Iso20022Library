// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.Cancellation4Choice
{
    /// <summary>
    /// Reference of the transfer to be cancelled.
    /// </summary>
    [IsoId("_ef320RXzEeOBE-jZfcm4KQ")]
    [DisplayName("References")]
    public partial record References : Cancellation4Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Unique and unambiguous identifier for a group of individual transfers as assigned by the instructing party. This identifier links the individual transfers together.
        /// </summary>
        [IsoId("_d9Ao0S72EeO59oUFO5eLvw")]
        [DisplayName("Master Reference")]
        [IsoXmlTag("MstrRef")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        public IsoMax35Text? MasterReference { get; init; } 
        
        /// <summary>
        /// Unique and unambiguous identifier for a transfer instruction, as assigned by the instructing party.
        /// </summary>
        [IsoId("_d9Ao0y72EeO59oUFO5eLvw")]
        [DisplayName("Transfer Reference")]
        [IsoXmlTag("TrfRef")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        public required IsoMax35Text TransferReference { get; init; } 
        
        /// <summary>
        /// Unique and unambiguous investor&apos;s identification of a transfer. This reference can typically be used in a hub scenario to give the reference of the transfer as assigned by the underlying client.
        /// </summary>
        [IsoId("_d9Ao1S72EeO59oUFO5eLvw")]
        [DisplayName("Client Reference")]
        [IsoXmlTag("ClntRef")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        public IsoMax35Text? ClientReference { get; init; } 
        
        /// <summary>
        /// Unambiguous identification of the transfer allocated by the counterparty.
        /// </summary>
        [IsoId("_WLNgcS72EeO59oUFO5eLvw")]
        [DisplayName("Counterparty Reference")]
        [IsoXmlTag("CtrPtyRef")]
        public AdditionalReference2? CounterpartyReference { get; init; } 
        
        /// <summary>
        /// Unique and unambiguous identifier for a transfer cancellation, as assigned by the instructing party.
        /// </summary>
        [IsoId("_d9Ao1y72EeO59oUFO5eLvw")]
        [DisplayName("Cancellation Reference")]
        [IsoXmlTag("CxlRef")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        public IsoMax35Text? CancellationReference { get; init; } 
        
        
        #nullable disable
        
    }
}
