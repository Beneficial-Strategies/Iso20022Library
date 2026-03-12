// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.TransactionIdentification1Choice
{
    /// <summary>
    /// Provides identification of the marfin reporting.
    /// </summary>
    [IsoId("_pq7S4K7LEemZxoEFHjN-AQ")]
    [DisplayName("Margin Reporting")]
    public partial record MarginReporting : TransactionIdentification1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Unique code identifying the reporting counterparty.
        /// </summary>
        [IsoId("_CsUTwa7MEemZxoEFHjN-AQ")]
        [DisplayName("Reporting Counterparty")]
        [IsoXmlTag("RptgCtrPty")]
        public required OrganisationIdentification9Choice_ ReportingCounterparty { get; init; } 
        
        /// <summary>
        /// Unique code identifying the entity with which the reporting counterparty concluded the transaction.
        /// </summary>
        [IsoId("_CsUTw67MEemZxoEFHjN-AQ")]
        [DisplayName("Other Counterparty")]
        [IsoXmlTag("OthrCtrPty")]
        public required OrganisationIdentification9Choice_ OtherCounterparty { get; init; } 
        
        /// <summary>
        /// Unique and unambiguous identification of the collateral portfolio.
        /// </summary>
        [IsoId("_URsPAa7MEemZxoEFHjN-AQ")]
        [DisplayName("Collateral Portfolio Identification")]
        [IsoXmlTag("CollPrtflId")]
        [IsoSimpleType(IsoSimpleType.Max52Text)]
        [StringLength(maximumLength: 52 ,MinimumLength = 1)]
        public required IsoMax52Text CollateralPortfolioIdentification { get; init; } 
        
        
        #nullable disable
        
    }
}
