// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Cleared16Choice
{
    /// <summary>
    /// Indicates that the contract has been cleared.
    /// </summary>
    [IsoId("_gKmIUcg4Eeu4ecZgAYuz5w")]
    [DisplayName("Cleared")]
    [IsoXmlTag("Clrd")]
    public record Cleared : Cleared16Choice_
    {
        /// <summary>
        /// In the case of a contract that has been cleared, the unique code for the clearing counterparty that has cleared the contract.
        /// </summary>
        [IsoId("_gMBrs8g4Eeu4ecZgAYuz5w")]
        [DisplayName("CCP")]
        [IsoXmlTag("CCP")]
        public OrganisationIdentification15Choice_? CCP { get; init; }

        /// <summary>
        /// Time and date when clearing took place.
        /// </summary>
        [IsoId("_gMBrtcg4Eeu4ecZgAYuz5w")]
        [DisplayName("Clearing Date Time")]
        [IsoXmlTag("ClrDtTm")]
        [IsoSimpleType(IsoSimpleType.ISODateTime)]
        public IsoISODateTime? ClearingDateTime { get; init; }

        /// <summary>
        /// Unique number to indicate a group of reports which relate to the same execution.
        /// </summary>
        [IsoId("_gMBrt8g4Eeu4ecZgAYuz5w")]
        [DisplayName("Report Tracking Number")]
        [IsoXmlTag("RptTrckgNb")]
        [IsoSimpleType(IsoSimpleType.Max52Text)]
        [StringLength(maximumLength: 52, MinimumLength = 1)]
        public IsoMax52Text? ReportTrackingNumber { get; init; }

        /// <summary>
        /// Unique code determined by the reporting counterparty identifying the portfolio.
        /// </summary>
        [IsoId("_gMBrucg4Eeu4ecZgAYuz5w")]
        [DisplayName("Portfolio Code")]
        [IsoXmlTag("PrtflCd")]
        [IsoSimpleType(IsoSimpleType.Max52Text)]
        [StringLength(maximumLength: 52, MinimumLength = 1)]
        public IsoMax52Text? PortfolioCode { get; init; }
    }
}
