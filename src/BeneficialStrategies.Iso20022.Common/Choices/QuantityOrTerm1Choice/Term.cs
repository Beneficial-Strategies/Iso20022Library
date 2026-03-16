// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.QuantityOrTerm1Choice
{
    /// <summary>
    /// Frequency expressed in tenor notation.
    /// </summary>
    [IsoId("_glq30SJDEe2zWP9pqvmqdw")]
    [DisplayName("Term")]
    public record Term : QuantityOrTerm1Choice_
    {
        /// <summary>
        /// Number of units of the financial instrument, that is, the nominal value.
        /// </summary>
        [IsoId("_n1kXkSJEEe2zWP9pqvmqdw")]
        [DisplayName("Quantity")]
        [IsoXmlTag("Qty")]
        [IsoSimpleType(IsoSimpleType.LongFraction19DecimalNumber)]
        public IsoLongFraction19DecimalNumber? Quantity { get; init; }

        /// <summary>
        /// Indicates the unit of measure in which the total notional quantity and notional quantity schedules are expressed.
        /// </summary>
        [IsoId("_6LpXASJEEe2zWP9pqvmqdw")]
        [DisplayName("Unit Of Measure")]
        [IsoXmlTag("UnitOfMeasr")]
        public UnitOfMeasure8Choice_? UnitOfMeasure { get; init; }

        /// <summary>
        /// Specifies the number of time units (as expressed by the frequency period) that determines the frequency at which periodic dates occur.
        /// </summary>
        [IsoId("_X_OJ8SJEEe2zWP9pqvmqdw")]
        [DisplayName("Value")]
        [IsoXmlTag("Val")]
        [IsoSimpleType(IsoSimpleType.Max3Number)]
        public IsoMax3Number? Value { get; init; }

        /// <summary>
        /// Unit for the frequency period.
        /// </summary>
        [IsoId("_X_EY8yJEEe2zWP9pqvmqdw")]
        [DisplayName("Time Unit")]
        [IsoXmlTag("TmUnit")]
        public Frequency19Code? TimeUnit { get; init; }
    }
}
