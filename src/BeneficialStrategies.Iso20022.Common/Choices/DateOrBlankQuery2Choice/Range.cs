// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.DateOrBlankQuery2Choice
{
    /// <summary>
    /// Indicates the date range.
    /// </summary>
    [IsoId("_cmD8MdGgEeaQk737TH1Fzw")]
    [DisplayName("Range")]
    [IsoXmlTag("Rg")]
    public record Range : DateOrBlankQuery2Choice_
    {
        /// <summary>
        /// Start date of the range.
        /// </summary>
        [IsoId("_6T03G5qlEeGSON8vddiWzQ_2053251952")]
        [DisplayName("From Date")]
        [IsoXmlTag("FrDt")]
        [IsoSimpleType(IsoSimpleType.ISODate)]
        public IsoISODate? FromDate { get; init; }

        /// <summary>
        /// End date of the range.
        /// </summary>
        [IsoId("_6T03HJqlEeGSON8vddiWzQ_-1787628075")]
        [DisplayName("To Date")]
        [IsoXmlTag("ToDt")]
        [IsoSimpleType(IsoSimpleType.ISODate)]
        public required IsoISODate ToDate { get; init; }
    }
}
