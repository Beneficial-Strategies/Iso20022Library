// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.References69Choice
{
    /// <summary>
    /// Unambiguous identification of the triparty collateral and exposure report to be cancelled.
    /// </summary>
    [IsoId("_OXngkAzYEeuUZuaHWzkTew")]
    [DisplayName("Triparty Collateral And Exposure Report Identification")]
    public record TripartyCollateralAndExposureReportIdentification : References69Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies a character string with a maximum length of 35 characters.
        /// </summary>
        [IsoXmlTag("TrptyCollAndXpsrRptId")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public required IsoMax35Text Value { get; init; }
    }
}
