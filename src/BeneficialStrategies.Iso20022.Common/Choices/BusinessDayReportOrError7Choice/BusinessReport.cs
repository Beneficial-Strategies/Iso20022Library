// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.BusinessDayReportOrError7Choice
{
    /// <summary>
    /// Reports either business day information or a business error.
    /// </summary>
    [IsoId("_wq9RgZlcEeeE1Ya-LgRsuQ")]
    [DisplayName("Business Report")]
    public record BusinessReport : BusinessDayReportOrError7Choice_
    {
        /// <summary>
        /// Identification of a particular market infrastructure.
        /// </summary>
        [IsoId("_wy9-A5lcEeeE1Ya-LgRsuQ")]
        [DisplayName("System Identification")]
        [IsoXmlTag("SysId")]
        public ValueList<SystemIdentification2Choice_> SystemIdentification { get; init; } = [];

        // ID for the above is _wy9-A5lcEeeE1Ya-LgRsuQ

        /// <summary>
        /// Requested information on the system availability for a specific business day or business error when information has not been found.
        /// </summary>
        [IsoId("_wy9-BZlcEeeE1Ya-LgRsuQ")]
        [DisplayName("Business Day Or Error")]
        [IsoXmlTag("BizDayOrErr")]
        public required BusinessDayReportOrError8Choice_ BusinessDayOrError { get; init; }
    }
}
