// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between expected/due payment date and a payment schedule per amount and due date.
    /// </summary>
    [KnownType(typeof(PaymentSchedule1Choice.DateRange))]
    [KnownType(typeof(PaymentSchedule1Choice.SubSchedule))]
    [JsonDerivedType(typeof(PaymentSchedule1Choice.DateRange),nameof(PaymentSchedule1Choice.DateRange))]
    [JsonDerivedType(typeof(PaymentSchedule1Choice.SubSchedule),nameof(PaymentSchedule1Choice.SubSchedule))]
    [IsoId("_BVaygdOAEeSQ_-lmj1tzfw")]
    [DisplayName("Payment Schedule 1 Choice")]
    public abstract partial record PaymentSchedule1Choice_
    {
    }
}
