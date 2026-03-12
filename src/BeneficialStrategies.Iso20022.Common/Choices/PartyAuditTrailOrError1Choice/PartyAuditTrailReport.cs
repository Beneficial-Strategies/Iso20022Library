// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.PartyAuditTrailOrError1Choice
{
    /// <summary>
    /// Report information about party reference data.
    /// </summary>
    [IsoId("_QqH6IZ9uEee7Qpz45yWJJw")]
    [DisplayName("Party Audit Trail Report")]
    public partial record PartyAuditTrailReport : PartyAuditTrailOrError1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Identifies the returned party reference data or error information.
        /// </summary>
        [IsoId("_Qy5boZ9uEee7Qpz45yWJJw")]
        [DisplayName("Party Audit Trail Or Error")]
        [IsoXmlTag("PtyAudtTrlOrErr")]
        public required PartyAuditTrailOrError2Choice_ PartyAuditTrailOrError { get; init; } 
        
        /// <summary>
        /// Period in dates for which the audit trail is provided.
        /// </summary>
        [IsoId("_Qy5bo59uEee7Qpz45yWJJw")]
        [DisplayName("Date Period")]
        [IsoXmlTag("DtPrd")]
        public DatePeriod3Choice_? DatePeriod { get; init; } 
        
        /// <summary>
        /// Identifies the party for which the audit trail is provided.
        /// </summary>
        [IsoId("_Qy5bpZ9uEee7Qpz45yWJJw")]
        [DisplayName("Party Identification")]
        [IsoXmlTag("PtyId")]
        public required SystemPartyIdentification8 PartyIdentification { get; init; } 
        
        
        #nullable disable
        
    }
}
