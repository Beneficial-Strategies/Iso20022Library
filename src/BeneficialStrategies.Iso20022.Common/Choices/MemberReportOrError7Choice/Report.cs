// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.MemberReportOrError7Choice
{
    /// <summary>
    /// Provides the details on the requested member.
    /// </summary>
    [IsoId("_fODoUdcZEeqRFcf2R4bPBw")]
    [DisplayName("Report")]
    [IsoXmlTag("Rpt")]
    public record Report : MemberReportOrError7Choice_
    {
        /// <summary>
        /// Unique and unambiguous identification of a member within a system, assigned using the member identification scheme of the system.
        /// </summary>
        [IsoId("_fQIE4dcZEeqRFcf2R4bPBw")]
        [DisplayName("Member Identification")]
        [IsoXmlTag("MmbId")]
        public required MemberIdentification3Choice_ MemberIdentification { get; init; }

        /// <summary>
        /// Reports either on a member or a business error.
        /// </summary>
        [IsoId("_fQIE49cZEeqRFcf2R4bPBw")]
        [DisplayName("Member Or Error")]
        [IsoXmlTag("MmbOrErr")]
        public required MemberReportOrError8Choice_ MemberOrError { get; init; }
    }
}
