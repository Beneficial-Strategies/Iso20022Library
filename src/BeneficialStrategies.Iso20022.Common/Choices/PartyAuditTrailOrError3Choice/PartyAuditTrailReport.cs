// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.PartyAuditTrailOrError3Choice
{
    /// <summary>
    /// Party Audit Trail Report.
    /// </summary>
    [DisplayName("Party Audit Trail Report")]
    public partial record PartyAuditTrailReport : PartyAuditTrailOrError3Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("PtyAudtTrlRpt")]
        public required PartyAuditTrailReport4 Value { get; init; } 
        
        
        #nullable disable
        
    }
}
