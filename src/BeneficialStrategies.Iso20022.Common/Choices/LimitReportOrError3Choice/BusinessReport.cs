// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.LimitReportOrError3Choice
{
    /// <summary>
    /// Reports on limits.
    /// </summary>
    [IsoId("_Q1IWIZlhEeeE1Ya-LgRsuQ")]
    [DisplayName("Business Report")]
    [IsoXmlTag("BizRpt")]
    public record BusinessReport : LimitReportOrError3Choice_
    {
        /// <summary>
        /// Report is given for a current risk management type limit.
        /// </summary>
        [IsoId("_RDVxQ5lhEeeE1Ya-LgRsuQ")]
        [DisplayName("Current Limit")]
        [IsoXmlTag("CurLmt")]
        public LimitReport6? CurrentLimit { get; init; }

        /// <summary>
        /// Report is given for a default risk management type limit.
        /// </summary>
        [IsoId("_RDVxRZlhEeeE1Ya-LgRsuQ")]
        [DisplayName("Default Limit")]
        [IsoXmlTag("DfltLmt")]
        public LimitReport6? DefaultLimit { get; init; }
    }
}
