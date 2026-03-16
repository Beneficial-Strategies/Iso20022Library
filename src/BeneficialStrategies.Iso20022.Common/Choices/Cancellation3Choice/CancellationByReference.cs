// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Cancellation3Choice
{
    /// <summary>
    /// Reference of the transfer instruction to be cancelled.
    /// </summary>
    [IsoId("_MsHJkCcaEeK33eWt3gq4Fg")]
    [DisplayName("Cancellation By Reference")]
    [IsoXmlTag("CxlByRef")]
    public record CancellationByReference : Cancellation3Choice_
    {
        /// <summary>
        /// Unique and unambiguous identifier for a group of individual transfers as assigned by the instructing party. This identifier links the individual transfers together.
        /// </summary>
        [IsoId("_Sww1cNp-Ed-ak6NoX_4Aeg_716567294")]
        [DisplayName("Master Reference")]
        [IsoXmlTag("MstrRef")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public IsoMax35Text? MasterReference { get; init; }

        /// <summary>
        /// Transfer and cancellation reference.
        /// </summary>
        [IsoId("_Sww1cdp-Ed-ak6NoX_4Aeg_-1130016572")]
        [DisplayName("Transfer References")]
        [IsoXmlTag("TrfRefs")]
        public ValueList<TransferReference4> TransferReferences { get; init; } = [];
        // ID for the above is _Sww1cdp-Ed-ak6NoX_4Aeg_-1130016572
    }
}
