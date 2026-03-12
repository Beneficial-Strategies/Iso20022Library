// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a code or a data source scheme to determine the booking unit.
    /// </summary>
    [KnownType(typeof(BookingUnit1Choice.Code))]
    [KnownType(typeof(BookingUnit1Choice.Proprietary))]
    [JsonDerivedType(typeof(BookingUnit1Choice.Code),nameof(BookingUnit1Choice.Code))]
    [JsonDerivedType(typeof(BookingUnit1Choice.Proprietary),nameof(BookingUnit1Choice.Proprietary))]
    [IsoId("_Q-6dVtp-Ed-ak6NoX_4Aeg_1716011738")]
    [DisplayName("Booking Unit 1 Choice")]
    public abstract partial record BookingUnit1Choice_
    {
    }
}
