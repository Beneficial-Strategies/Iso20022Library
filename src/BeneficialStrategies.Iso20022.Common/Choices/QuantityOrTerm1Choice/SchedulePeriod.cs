// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.QuantityOrTerm1Choice
{
    /// <summary>
    /// Specifies the effective date and end date of the schedule for derivative transactions negotiated in non-monetary amounts with a notional quantity varying throughout the life of the transaction.
    /// </summary>
    [IsoId("_fbqi0SJDEe2zWP9pqvmqdw")]
    [DisplayName("Schedule Period")]
    [IsoXmlTag("SchdlPrd")]
    public record SchedulePeriod : QuantityOrTerm1Choice_
    {
        /// <summary>
        /// Number of units of the financial instrument, that is, the nominal value.
        /// </summary>
        [IsoId("_-ZlMgSJDEe2zWP9pqvmqdw")]
        [DisplayName("Quantity")]
        [IsoXmlTag("Qty")]
        [IsoSimpleType(IsoSimpleType.LongFraction19DecimalNumber)]
        public required IsoLongFraction19DecimalNumber Quantity { get; init; }

        /// <summary>
        /// Indicates the unit of measure in which the total notional quantity and notional quantity schedules are expressed.
        /// </summary>
        [IsoId("_Cw9ccSJEEe2zWP9pqvmqdw")]
        [DisplayName("Unit Of Measure")]
        [IsoXmlTag("UnitOfMeasr")]
        public UnitOfMeasure8Choice_? UnitOfMeasure { get; init; }

        /// <summary>
        /// Indicates the unadjusted date at which obligations under the  derivative transaction come into effect, as included in the confirmation.
        /// </summary>
        [IsoId("_2INzQSJDEe2zWP9pqvmqdw")]
        [DisplayName("Unadjusted Effective Date")]
        [IsoXmlTag("UadjstdFctvDt")]
        [IsoSimpleType(IsoSimpleType.ISODate)]
        public required IsoISODate UnadjustedEffectiveDate { get; init; }

        /// <summary>
        /// Indicates the end date agreed in the derivative transaction without adjustment.
        /// </summary>
        [IsoId("_2INzQyJDEe2zWP9pqvmqdw")]
        [DisplayName("Unadjusted End Date")]
        [IsoXmlTag("UadjstdEndDt")]
        [IsoSimpleType(IsoSimpleType.ISODate)]
        public IsoISODate? UnadjustedEndDate { get; init; }
    }
}
