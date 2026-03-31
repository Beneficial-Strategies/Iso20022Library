// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TransferStatus1Choice
{
    /// <summary>
    /// Status of the transfer is pending settlement.
    /// </summary>
    [IsoId("_o1CqqRwkEeOIveEnnb_1-A")]
    [DisplayName("Pending Settlement")]
    [IsoXmlTag("PdgSttlm")]
    public record PendingSettlement : TransferStatus1Choice_
    {
        /// <summary>
        /// Reason for the settlement pending status.
        /// </summary>
        [IsoId("_RRPjd9p-Ed-ak6NoX_4Aeg_1818056284")]
        [DisplayName("Reason")]
        [IsoXmlTag("Rsn")]
        public required PendingSettlementStatusReason2Code Reason { get; init; }

        /// <summary>
        /// Reason for the settlement pending status.
        /// </summary>
        [IsoId("_RRPjeNp-Ed-ak6NoX_4Aeg_1820827730")]
        [DisplayName("Extended Reason")]
        [IsoXmlTag("XtndedRsn")]
        [IsoSimpleType(IsoSimpleType.Extended350Code)]
        [StringLength(maximumLength: 350, MinimumLength = 1)]
        public required IsoExtended350Code ExtendedReason { get; init; }

        /// <summary>
        /// Proprietary identification of the reason for the pending settlement status.
        /// </summary>
        [IsoId("_RRPjedp-Ed-ak6NoX_4Aeg_-685618492")]
        [DisplayName("Data Source Scheme")]
        [IsoXmlTag("DataSrcSchme")]
        public required GenericIdentification1 DataSourceScheme { get; init; }

        /// <summary>
        /// Indicates that there is no reason available or to report.
        /// </summary>
        [IsoId("_RRPjetp-Ed-ak6NoX_4Aeg_-685618527")]
        [DisplayName("No Specified Reason")]
        [IsoXmlTag("NoSpcfdRsn")]
        public required NoReasonCode NoSpecifiedReason { get; init; }
    }
}
