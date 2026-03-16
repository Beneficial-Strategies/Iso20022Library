// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Cancellation12Choice
{
    /// <summary>
    /// Details of the transfer out request to cancel.
    /// </summary>
    [IsoId("_Aa4f4yPwEeWQjryFgN2ITg")]
    [DisplayName("Transfer Out Details")]
    [IsoXmlTag("TrfOutDtls")]
    public record TransferOutDetails : Cancellation12Choice_
    {
        /// <summary>
        /// Requested date at which the instructing party places the transfer instruction.
        /// </summary>
        [IsoId("_A3mRFSPwEeWQjryFgN2ITg")]
        [DisplayName("Requested Transfer Date")]
        [IsoXmlTag("ReqdTrfDt")]
        public DateFormat1Choice_? RequestedTransferDate { get; init; }

        /// <summary>
        /// Unique and unambiguous identifier for a group of individual transfers as assigned by the instructing party. This identifier links the individual transfers together.
        /// </summary>
        [IsoId("_A3mRFyPwEeWQjryFgN2ITg")]
        [DisplayName("Master Reference")]
        [IsoXmlTag("MstrRef")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public IsoMax35Text? MasterReference { get; init; }

        /// <summary>
        /// Details of the transfer and cancellation.
        /// </summary>
        [IsoId("_A3mRGSPwEeWQjryFgN2ITg")]
        [DisplayName("Transfer And References")]
        [IsoXmlTag("TrfAndRefs")]
        public ValueList<TransferOut18> TransferAndReferences { get; init; } = [];

        // ID for the above is _A3mRGSPwEeWQjryFgN2ITg

        /// <summary>
        /// Information related to the account from which the financial instrument is to be withdrawn.
        /// </summary>
        [IsoId("_A3mRGyPwEeWQjryFgN2ITg")]
        [DisplayName("Account Details")]
        [IsoXmlTag("AcctDtls")]
        public required InvestmentAccount54 AccountDetails { get; init; }

        /// <summary>
        /// Information related to the receiving side of the transfer.
        /// </summary>
        [IsoId("_A3mRHSPwEeWQjryFgN2ITg")]
        [DisplayName("Settlement Details")]
        [IsoXmlTag("SttlmDtls")]
        public ReceiveInformation16? SettlementDetails { get; init; }

        /// <summary>
        /// Additional information that cannot be captured in the structured elements and/or any other specific block.
        /// </summary>
        [IsoId("_A3mRHyPwEeWQjryFgN2ITg")]
        [DisplayName("Extension")]
        [IsoXmlTag("Xtnsn")]
        public Extension1? Extension { get; init; }
    }
}
