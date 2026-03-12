// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.MemberReportOrError3Choice
{
    /// <summary>
    /// Provides the details on the requested member.
    /// </summary>
    [IsoId("_i0a-UZlCEee-Zps0fZQaFQ")]
    [DisplayName("Report")]
    public partial record Report : MemberReportOrError3Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Unique and unambiguous identification of a member within a system, assigned using the member identification scheme of the system.
        /// </summary>
        [IsoId("_i8mp8ZlCEee-Zps0fZQaFQ")]
        [DisplayName("Member Identification")]
        [IsoXmlTag("MmbId")]
        public required MemberIdentification2Choice_ MemberIdentification { get; init; } 
        
        /// <summary>
        /// Reports either on a member or a business error.
        /// </summary>
        [IsoId("_i8mp85lCEee-Zps0fZQaFQ")]
        [DisplayName("Member Or Error")]
        [IsoXmlTag("MmbOrErr")]
        public required MemberReportOrError4Choice_ MemberOrError { get; init; } 
        
        
        #nullable disable
        
    }
}
