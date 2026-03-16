// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TransferStatus1Choice
{
    /// <summary>
    /// Status of the transfer is reversed.
    /// </summary>
    [IsoId("_o1CqrxwkEeOIveEnnb_1-A")]
    [DisplayName("Reversed")]
    public record Reversed : TransferStatus1Choice_
    {
        /// <summary>
        /// Reason for the reversal status.
        /// </summary>
        [IsoId("_RQptltp-Ed-ak6NoX_4Aeg_-1949430313")]
        [DisplayName("Reason")]
        [IsoXmlTag("Rsn")]
        [IsoSimpleType(IsoSimpleType.Max350Text)]
        [StringLength(maximumLength: 350, MinimumLength = 1)]
        public required IsoMax350Text Reason { get; init; }

        /// <summary>
        /// Proprietary identification of the reason for the reversed status.
        /// </summary>
        [IsoId("_RQptl9p-Ed-ak6NoX_4Aeg_-1949430294")]
        [DisplayName("Data Source Scheme")]
        [IsoXmlTag("DataSrcSchme")]
        public required GenericIdentification1 DataSourceScheme { get; init; }

        /// <summary>
        /// Indicates that there is no reason available or to report.
        /// </summary>
        [IsoId("_RQptmNp-Ed-ak6NoX_4Aeg_1619833408")]
        [DisplayName("No Specified Reason")]
        [IsoXmlTag("NoSpcfdRsn")]
        public required NoReasonCode NoSpecifiedReason { get; init; }
    }
}
