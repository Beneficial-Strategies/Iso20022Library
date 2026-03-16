// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Cleared10Choice
{
    /// <summary>
    /// Indicates that the contract has been cleared.
    /// </summary>
    [IsoId("_HQfLobQ0EemI67HK7aviyg")]
    [DisplayName("Cleared")]
    [IsoXmlTag("Clrd")]
    public record Cleared : Cleared10Choice_
    {
        /// <summary>
        /// In the case of a contract that has been cleared, the unique code for the clearing counterparty that has cleared the contract.
        /// </summary>
        [IsoId("_HUgwAbQ0EemI67HK7aviyg")]
        [DisplayName("CCP")]
        [IsoXmlTag("CCP")]
        public OrganisationIdentification9Choice_? CCP { get; init; }

        /// <summary>
        /// Time and date when clearing took place.
        /// </summary>
        [IsoId("_HUgwA7Q0EemI67HK7aviyg")]
        [DisplayName("Clearing Date Time")]
        [IsoXmlTag("ClrDtTm")]
        [IsoSimpleType(IsoSimpleType.ISODateTime)]
        public IsoISODateTime? ClearingDateTime { get; init; }

        /// <summary>
        /// Unique number to indicate a group of reports which relate to the same execution.
        /// </summary>
        [IsoId("_HUgwBbQ0EemI67HK7aviyg")]
        [DisplayName("Report Tracking Number")]
        [IsoXmlTag("RptTrckgNb")]
        [IsoSimpleType(IsoSimpleType.Max52Text)]
        [StringLength(maximumLength: 52, MinimumLength = 1)]
        public IsoMax52Text? ReportTrackingNumber { get; init; }

        /// <summary>
        /// If the transaction is cleared and is included in a portfolio of transactions for which margins are exchanged, this portfolio should be identified by a unique code determined by the reporting counterparty.
        /// </summary>
        [IsoId("_HUgwB7Q0EemI67HK7aviyg")]
        [DisplayName("Portfolio Code")]
        [IsoXmlTag("PrtflCd")]
        [IsoSimpleType(IsoSimpleType.Max52Text)]
        [StringLength(maximumLength: 52, MinimumLength = 1)]
        public IsoMax52Text? PortfolioCode { get; init; }
    }
}
