// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Frequency36Choice
{
    /// <inheritdoc cref="IPointInTime"/>
    [IsoId("_6IxUQWk2Eeanu6HLe77Rkg")]
    [DisplayName("Point In Time")]
    [IsoXmlTag("PtInTm")]
    public partial record PointInTime : Frequency36Choice_
    {
        /// <inheritdoc cref="IPointInTime.Type"/>
        [IsoId("_CWY19Wk3Eeanu6HLe77Rkg")]
        [DisplayName("Type")]
        [IsoXmlTag("Tp")]
        public required Frequency6Code Type { get; init; }

        /// <inheritdoc cref="IPointInTime.Value"/>
        [IsoXmlTag("PtInTm")]
        [IsoSimpleType(IsoSimpleType.Exact2NumericText)]
        public required IsoExact2NumericText Value { get; init; }
    }
}
