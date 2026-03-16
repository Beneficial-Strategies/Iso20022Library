// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Reversal3Choice
{
    /// <summary>
    /// Details of the transfer out confirmation to be reversed.
    /// </summary>
    [IsoId("_QcQDsxX2EeOBE-jZfcm4KQ")]
    [DisplayName("Transfer Out Confirmation Details")]
    public record TransferOutConfirmationDetails : Reversal3Choice_
    {
        /// <summary>
        /// Unique and unambiguous identifier for a group of individual transfers as assigned by the instructing party. This identifier links the individual transfers together.
        /// </summary>
        [IsoId("_o4UboC79EeO59oUFO5eLvw")]
        [DisplayName("Master Reference")]
        [IsoXmlTag("MstrRef")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public IsoMax35Text? MasterReference { get; init; }

        /// <summary>
        /// General information related to the transfer of a financial instrument.
        /// </summary>
        [IsoId("_GRF3RxX2EeOBE-jZfcm4KQ")]
        [DisplayName("Transfer Details")]
        [IsoXmlTag("TrfDtls")]
        public ValueList<Transfer28> TransferDetails { get; init; } = [];

        // ID for the above is _GRF3RxX2EeOBE-jZfcm4KQ

        /// <summary>
        /// Information related to the account from which the financial instrument was withdrawn.
        /// </summary>
        [IsoId("_GRF3SRX2EeOBE-jZfcm4KQ")]
        [DisplayName("Account Details")]
        [IsoXmlTag("AcctDtls")]
        public required InvestmentAccount40 AccountDetails { get; init; }

        /// <summary>
        /// Information related to the receiving side of the transfer.
        /// </summary>
        [IsoId("_GRF3SxX2EeOBE-jZfcm4KQ")]
        [DisplayName("Settlement Details")]
        [IsoXmlTag("SttlmDtls")]
        public ReceiveInformation12? SettlementDetails { get; init; }

        /// <summary>
        /// Additional information that can not be captured in the structured fields and/or any other specific block.
        /// </summary>
        [IsoId("_GRF3TRX2EeOBE-jZfcm4KQ")]
        [DisplayName("Extension")]
        [IsoXmlTag("Xtnsn")]
        public Extension1? Extension { get; init; }
    }
}
