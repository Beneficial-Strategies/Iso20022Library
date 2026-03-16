// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Reversal8Choice
{
    /// <summary>
    /// Reference of the transfer confirmation to be reversed.
    /// </summary>
    [IsoId("_-GjFwSPvEeWQjryFgN2ITg")]
    [DisplayName("References")]
    public record References : Reversal8Choice_
    {
        /// <summary>
        /// Unique and unambiguous identifier for a group of individual transfers as assigned by the instructing party. This identifier links the individual transfers together.
        /// </summary>
        [IsoId("_tM0MkyVwEeWES5MJF-y6YA")]
        [DisplayName("Master Reference")]
        [IsoXmlTag("MstrRef")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public IsoMax35Text? MasterReference { get; init; }

        /// <summary>
        /// Unique and unambiguous identifier for a transfer instruction, as assigned by the instructing party.
        /// </summary>
        [IsoId("_tM0MlSVwEeWES5MJF-y6YA")]
        [DisplayName("Transfer Reference")]
        [IsoXmlTag("TrfRef")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public IsoMax35Text? TransferReference { get; init; }

        /// <summary>
        /// Unique and unambiguous investor&apos;s identification of a transfer. This reference can typically be used in a hub scenario to give the reference of the transfer as assigned by the underlying client.
        /// </summary>
        [IsoId("_tM0MlyVwEeWES5MJF-y6YA")]
        [DisplayName("Client Reference")]
        [IsoXmlTag("ClntRef")]
        public AdditionalReference7? ClientReference { get; init; }

        /// <summary>
        /// Unique and unambiguous identifier for a transfer execution, as assigned by a confirming party.
        /// </summary>
        [IsoId("_tM0MmSVwEeWES5MJF-y6YA")]
        [DisplayName("Transfer Confirmation Reference")]
        [IsoXmlTag("TrfConfRef")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public IsoMax35Text? TransferConfirmationReference { get; init; }

        /// <summary>
        /// Unambiguous identification of the transfer allocated by the counterparty.
        /// </summary>
        [IsoId("_tM0MmyVwEeWES5MJF-y6YA")]
        [DisplayName("Counterparty Reference")]
        [IsoXmlTag("CtrPtyRef")]
        public AdditionalReference7? CounterpartyReference { get; init; }
    }
}
