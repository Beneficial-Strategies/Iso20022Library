// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Cancellation12Choice
{
    /// <summary>
    /// Reference of the transfer to be cancelled.
    /// </summary>
    [IsoId("_Aa4f4SPwEeWQjryFgN2ITg")]
    [DisplayName("References")]
    [IsoXmlTag("Refs")]
    public record References : Cancellation12Choice_
    {
        /// <summary>
        /// Unique and unambiguous identifier for a group of individual transfers as assigned by the instructing party. This identifier links the individual transfers together.
        /// </summary>
        [IsoId("_iIKPUSVPEeWI0orciOKunQ")]
        [DisplayName("Master Reference")]
        [IsoXmlTag("MstrRef")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public IsoMax35Text? MasterReference { get; init; }

        /// <summary>
        /// Unique and unambiguous identifier for a transfer instruction, as assigned by the instructing party.
        /// </summary>
        [IsoId("_iIKPUyVPEeWI0orciOKunQ")]
        [DisplayName("Transfer Reference")]
        [IsoXmlTag("TrfRef")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public required IsoMax35Text TransferReference { get; init; }

        /// <summary>
        /// Unique and unambiguous investor&apos;s identification of a transfer. This reference can typically be used in a hub scenario to give the reference of the transfer as assigned by the underlying client.
        /// </summary>
        [IsoId("_iIKPVSVPEeWI0orciOKunQ")]
        [DisplayName("Client Reference")]
        [IsoXmlTag("ClntRef")]
        public AdditionalReference7? ClientReference { get; init; }

        /// <summary>
        /// Unambiguous identification of the transfer allocated by the counterparty.
        /// </summary>
        [IsoId("_iIKPVyVPEeWI0orciOKunQ")]
        [DisplayName("Counterparty Reference")]
        [IsoXmlTag("CtrPtyRef")]
        public AdditionalReference7? CounterpartyReference { get; init; }

        /// <summary>
        /// Unique and unambiguous identifier for a transfer cancellation, as assigned by the instructing party.
        /// </summary>
        [IsoId("_iIKPWSVPEeWI0orciOKunQ")]
        [DisplayName("Cancellation Reference")]
        [IsoXmlTag("CxlRef")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public IsoMax35Text? CancellationReference { get; init; }
    }
}
