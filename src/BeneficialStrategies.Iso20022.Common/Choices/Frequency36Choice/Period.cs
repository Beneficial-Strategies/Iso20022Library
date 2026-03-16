// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Frequency36Choice
{
    /// <summary>
    /// Specifies a frequency in terms of a count per period within a specified period type.
    /// </summary>
    [IsoId("_seR6M2k2Eeanu6HLe77Rkg")]
    [DisplayName("Period")]
    public record Period : Frequency36Choice_
    {
        /// <summary>
        /// Period for which the number of instructions are to be created and processed.
        /// </summary>
        [IsoId("_1bz5sB71EeSxevWRRWxNAg")]
        [DisplayName("Type")]
        [IsoXmlTag("Tp")]
        public required Frequency6Code Type { get; init; }

        /// <summary>
        /// Number of instructions to be created and processed during the specified period.
        /// </summary>
        [IsoId("_OPlVUB72EeSxevWRRWxNAg")]
        [DisplayName("Count Per Period")]
        [IsoXmlTag("CntPerPrd")]
        [IsoSimpleType(IsoSimpleType.DecimalNumber)]
        public required IsoDecimalNumber CountPerPeriod { get; init; }
    }
}
