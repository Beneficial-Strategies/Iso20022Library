// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TransactionIdentification1Choice
{
    /// <summary>
    /// Provides identification of the collateral reuse.
    /// </summary>
    [IsoId("_q0jNYK7LEemZxoEFHjN-AQ")]
    [DisplayName("Collateral Reuse")]
    [IsoXmlTag("CollReuse")]
    public record CollateralReuse : TransactionIdentification1Choice_
    {
        /// <summary>
        /// Unique code identifying the reporting counterparty.
        /// </summary>
        [IsoId("_mhuQ0a7MEemZxoEFHjN-AQ")]
        [DisplayName("Reporting Counterparty")]
        [IsoXmlTag("RptgCtrPty")]
        public required OrganisationIdentification9Choice_ ReportingCounterparty { get; init; }

        /// <summary>
        /// Unique code identifying the entity which submits the report. In the case where submission of the report has been delegated to a third party or to the other counterparty, a unique code identifying that entity.
        /// </summary>
        [IsoId("_wIaeQa7MEemZxoEFHjN-AQ")]
        [DisplayName("Report Submitting Entity")]
        [IsoXmlTag("RptSubmitgNtty")]
        public required OrganisationIdentification9Choice_ ReportSubmittingEntity { get; init; }
    }
}
