// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.LimitReportOrError4Choice
{
    /// <summary>
    /// Reports on limits.
    /// </summary>
    [IsoId("_C3LJ4W4-EeiU9cctagi5ow")]
    [DisplayName("Business Report")]
    public record BusinessReport : LimitReportOrError4Choice_
    {
        /// <summary>
        /// Report is given for a current risk management type limit.
        /// </summary>
        [IsoId("_DAtgY24-EeiU9cctagi5ow")]
        [DisplayName("Current Limit")]
        [IsoXmlTag("CurLmt")]
        public LimitReport7? CurrentLimit { get; init; }

        /// <summary>
        /// Report is given for a default risk management type limit.
        /// </summary>
        [IsoId("_DAtgZW4-EeiU9cctagi5ow")]
        [DisplayName("Default Limit")]
        [IsoXmlTag("DfltLmt")]
        public LimitReport7? DefaultLimit { get; init; }
    }
}
