// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between expected/due interest payment date and a interest payment schedule per amount and due date.
    /// </summary>
    [KnownType(typeof(InterestPaymentSchedule1Choice.DateRange))]
    [KnownType(typeof(InterestPaymentSchedule1Choice.SubSchedule))]
    [JsonDerivedType(typeof(InterestPaymentSchedule1Choice.DateRange),nameof(InterestPaymentSchedule1Choice.DateRange))]
    [JsonDerivedType(typeof(InterestPaymentSchedule1Choice.SubSchedule),nameof(InterestPaymentSchedule1Choice.SubSchedule))]
    [IsoId("_u7i5Q-FWEeSvv6t4Ka7B7A")]
    [DisplayName("Interest Payment Schedule 1 Choice")]
    public abstract partial record InterestPaymentSchedule1Choice_
    {
    }
}
