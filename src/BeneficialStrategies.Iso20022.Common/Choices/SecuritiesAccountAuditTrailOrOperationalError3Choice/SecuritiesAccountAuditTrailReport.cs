// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.SecuritiesAccountAuditTrailOrOperationalError3Choice
{
    /// <summary>
    /// Report information about securities account reference data.
    /// </summary>
    [IsoId("_A6gAsTp0Eemk2e6qGBk8IQ")]
    [DisplayName("Securities Account Audit Trail Report")]
    public partial record SecuritiesAccountAuditTrailReport : SecuritiesAccountAuditTrailOrOperationalError3Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Provides the returned securities account reference data or error information.
        /// </summary>
        [IsoId("_BEo0ITp0Eemk2e6qGBk8IQ")]
        [DisplayName("Securities Account Audit Trail Or Error")]
        [IsoXmlTag("SctiesAcctAudtTrlOrErr")]
        public required AuditTrailOrBusinessError6Choice_ SecuritiesAccountAuditTrailOrError { get; init; } 
        
        /// <summary>
        /// Period in dates for which the audit trail is provided.
        /// </summary>
        [IsoId("_BEo0Izp0Eemk2e6qGBk8IQ")]
        [DisplayName("Date Period")]
        [IsoXmlTag("DtPrd")]
        public DatePeriodSearch1Choice_? DatePeriod { get; init; } 
        
        /// <summary>
        /// Identifies the securities account for which the audit trail is provided.
        /// </summary>
        [IsoId("_BEo0JTp0Eemk2e6qGBk8IQ")]
        [DisplayName("Securities Account Identification")]
        [IsoXmlTag("SctiesAcctId")]
        public required SecuritiesAccount19 SecuritiesAccountIdentification { get; init; } 
        
        
        #nullable disable
        
    }
}
