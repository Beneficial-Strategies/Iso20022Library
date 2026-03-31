// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice for payment schedule type.
    /// </summary>
    [KnownType(typeof(PaymentScheduleType1Choice.Code))]
    [KnownType(typeof(PaymentScheduleType1Choice.Proprietary))]
    [JsonDerivedType(
        typeof(PaymentScheduleType1Choice.Code),
        nameof(PaymentScheduleType1Choice.Code)
    )]
    [JsonDerivedType(
        typeof(PaymentScheduleType1Choice.Proprietary),
        nameof(PaymentScheduleType1Choice.Proprietary)
    )]
    [IsoId("_1ggIwAqPEeWqX7rjSIiMuQ")]
    [DisplayName("Payment Schedule Type 1 Choice")]
    public abstract record PaymentScheduleType1Choice_ { }
}
