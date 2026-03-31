// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AutoExtend1Choice
{
    /// <summary>
    /// Number of days.
    /// </summary>
    [IsoId("_95fqcHltEeG7BsjMvd1mEw_1889905144")]
    [DisplayName("Days")]
    public record Days : AutoExtend1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Number of objects represented as an integer.
        /// </summary>
        [IsoXmlTag("Days")]
        [IsoSimpleType(IsoSimpleType.Number)]
        public required IsoNumber Value { get; init; }
    }
}
