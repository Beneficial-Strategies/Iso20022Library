// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.BusinessDayReportOrError8Choice
{
    /// <summary>
    /// Requested system details for a specific business day.
    /// </summary>
    [IsoId("_w64j4ZlcEeeE1Ya-LgRsuQ")]
    [DisplayName("Business Day Information")]
    [IsoXmlTag("BizDayInf")]
    public record BusinessDayInformation : BusinessDayReportOrError8Choice_
    {
        /// <summary>
        /// Date for which the availability information is provided.
        /// </summary>
        [IsoId("_xCzJwZlcEeeE1Ya-LgRsuQ")]
        [DisplayName("System Date")]
        [IsoXmlTag("SysDt")]
        [IsoSimpleType(IsoSimpleType.ISODate)]
        public IsoISODate? SystemDate { get; init; }

        /// <summary>
        /// Status of a system and the period of time during which the status is valid.
        /// </summary>
        [IsoId("_xCzJw5lcEeeE1Ya-LgRsuQ")]
        [DisplayName("System Status")]
        [IsoXmlTag("SysSts")]
        public SystemStatus3? SystemStatus { get; init; }

        /// <summary>
        /// Information relating to system operations and foreseen events relating to the operation of the system.
        /// </summary>
        [IsoId("_xCzJxZlcEeeE1Ya-LgRsuQ")]
        [DisplayName("System Information Per Currency")]
        [IsoXmlTag("SysInfPerCcy")]
        public SystemAvailabilityAndEvents2? SystemInformationPerCurrency { get; init; }
    }
}
