// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Cancellation2Choice
{
    /// <summary>
    /// Reference of the transfer to be cancelled.
    /// </summary>
    [IsoId("_OFsU1Rg2EeK-_89we2b-bA")]
    [DisplayName("Reference")]
    [IsoXmlTag("Ref")]
    public record Reference : Cancellation2Choice_
    {
        /// <summary>
        /// Unique and unambiguous identifier for a group of individual transfers as assigned by the instructing party. This identifier links the individual transfers together.
        /// </summary>
        [IsoId("_SwUJgNp-Ed-ak6NoX_4Aeg_-1571572721")]
        [DisplayName("Master Reference")]
        [IsoXmlTag("MstrRef")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public IsoMax35Text? MasterReference { get; init; }

        /// <summary>
        /// Unique and unambiguous identifier for a transfer instruction, as assigned by the instructing party.
        /// </summary>
        [IsoId("_SwUJgdp-Ed-ak6NoX_4Aeg_-838136033")]
        [DisplayName("Transfer Reference")]
        [IsoXmlTag("TrfRef")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public required IsoMax35Text TransferReference { get; init; }

        /// <summary>
        /// Unique and unambiguous investor&apos;s identification of a transfer. This reference can typically be used in a hub scenario to give the reference of the transfer as assigned by the underlying client.
        /// </summary>
        [IsoId("_SwUJgtp-Ed-ak6NoX_4Aeg_-838136016")]
        [DisplayName("Client Reference")]
        [IsoXmlTag("ClntRef")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public IsoMax35Text? ClientReference { get; init; }

        /// <summary>
        /// Unique and unambiguous identifier for a transfer cancellation, as assigned by the instructing party.
        /// </summary>
        [IsoId("_SwUJg9p-Ed-ak6NoX_4Aeg_-838135973")]
        [DisplayName("Cancellation Reference")]
        [IsoXmlTag("CxlRef")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public IsoMax35Text? CancellationReference { get; init; }
    }
}
