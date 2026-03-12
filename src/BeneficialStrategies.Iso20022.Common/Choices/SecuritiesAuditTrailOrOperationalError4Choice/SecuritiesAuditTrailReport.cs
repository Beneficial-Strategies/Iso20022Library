// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.SecuritiesAuditTrailOrOperationalError4Choice
{
    /// <summary>
    /// Report information about securities reference data.
    /// </summary>
    [IsoId("_Ptf-MZJKEeuAlLVx8pyt3w")]
    [DisplayName("Securities Audit Trail Report")]
    public partial record SecuritiesAuditTrailReport : SecuritiesAuditTrailOrOperationalError4Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Identifies the returned securities reference data or error information.
        /// </summary>
        [IsoId("_PvjzsZJKEeuAlLVx8pyt3w")]
        [DisplayName("Securities Audit Trail Or Error")]
        [IsoXmlTag("SctiesAudtTrlOrErr")]
        public required AuditTrailOrBusinessError6Choice_ SecuritiesAuditTrailOrError { get; init; } 
        
        /// <summary>
        /// Period in dates for which the audit trail is provided.
        /// </summary>
        [IsoId("_Pvjzs5JKEeuAlLVx8pyt3w")]
        [DisplayName("Date Period")]
        [IsoXmlTag("DtPrd")]
        public DatePeriodSearch1Choice_? DatePeriod { get; init; } 
        
        /// <summary>
        /// Identifies the securities for which the audit trail is provided.
        /// </summary>
        [IsoId("_PvjztZJKEeuAlLVx8pyt3w")]
        [DisplayName("Financial Instrument Identification")]
        [IsoXmlTag("FinInstrmId")]
        public required SecurityIdentification39 FinancialInstrumentIdentification { get; init; } 
        
        
        #nullable disable
        
    }
}
