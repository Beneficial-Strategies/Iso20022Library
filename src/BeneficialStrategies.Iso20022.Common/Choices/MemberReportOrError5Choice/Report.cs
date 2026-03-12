// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.MemberReportOrError5Choice
{
    /// <summary>
    /// Provides the details on the requested member.
    /// </summary>
    [IsoId("_jmCfkXSbEeiH1ZOt2UD8vQ")]
    [DisplayName("Report")]
    public partial record Report : MemberReportOrError5Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Unique and unambiguous identification of a member within a system, assigned using the member identification scheme of the system.
        /// </summary>
        [IsoId("_j3hRIXSbEeiH1ZOt2UD8vQ")]
        [DisplayName("Member Identification")]
        [IsoXmlTag("MmbId")]
        public required MemberIdentification3Choice_ MemberIdentification { get; init; } 
        
        /// <summary>
        /// Reports either on a member or a business error.
        /// </summary>
        [IsoId("_j3hRI3SbEeiH1ZOt2UD8vQ")]
        [DisplayName("Member Or Error")]
        [IsoXmlTag("MmbOrErr")]
        public required MemberReportOrError6Choice_ MemberOrError { get; init; } 
        
        
        #nullable disable
        
    }
}
