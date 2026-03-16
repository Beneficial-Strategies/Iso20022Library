// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Reversal1Choice
{
    /// <summary>
    /// Details of the transfer out confirmation to be reversed.
    /// </summary>
    [IsoId("_-5EuwBg3EeK-_89we2b-bA")]
    [DisplayName("Transfer Out Confirmation Details")]
    public record TransferOutConfirmationDetails : Reversal1Choice_
    {
        /// <summary>
        /// General information related to the transfer of a financial instrument.
        /// </summary>
        [IsoId("_1cQJpRgkEeK-_89we2b-bA")]
        [DisplayName("Transfer Details")]
        [IsoXmlTag("TrfDtls")]
        public ValueList<Transfer24> TransferDetails { get; init; } = [];

        // ID for the above is _1cQJpRgkEeK-_89we2b-bA

        /// <summary>
        /// Information related to the account from which the financial instrument was withdrawn.
        /// </summary>
        [IsoId("_1cQJqRgkEeK-_89we2b-bA")]
        [DisplayName("Account Details")]
        [IsoXmlTag("AcctDtls")]
        public required InvestmentAccount22 AccountDetails { get; init; }

        /// <summary>
        /// Information related to the receiving side of the transfer.
        /// </summary>
        [IsoId("_1cQJrRgkEeK-_89we2b-bA")]
        [DisplayName("Settlement Details")]
        [IsoXmlTag("SttlmDtls")]
        public ReceiveInformation11? SettlementDetails { get; init; }

        /// <summary>
        /// Additional information that can not be captured in the structured fields and/or any other specific block.
        /// </summary>
        [IsoId("_1cQJsRgkEeK-_89we2b-bA")]
        [DisplayName("Extension")]
        [IsoXmlTag("Xtnsn")]
        public Extension1? Extension { get; init; }
    }
}
