// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PriorityNumeric1Choice
{
    /// <summary>
    /// Specifies the execution priority of the instruction with a number between 0001 and 9999.
    /// </summary>
    [IsoId("_QuYG8dp-Ed-ak6NoX_4Aeg_971634575")]
    [DisplayName("Numeric")]
    public record Numeric : PriorityNumeric1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies a numeric string with an exact length of 4 digits.
        /// </summary>
        [IsoXmlTag("Nmrc")]
        [IsoSimpleType(IsoSimpleType.Exact4NumericText)]
        public required IsoExact4NumericText Value { get; init; }
    }
}
