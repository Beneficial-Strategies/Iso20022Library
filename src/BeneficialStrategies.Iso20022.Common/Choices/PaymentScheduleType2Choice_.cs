// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice for payment schedule type.
    /// </summary>
    [KnownType(typeof(PaymentScheduleType2Choice.Code))]
    [KnownType(typeof(PaymentScheduleType2Choice.Proprietary))]
    [JsonDerivedType(
        typeof(PaymentScheduleType2Choice.Code),
        nameof(PaymentScheduleType2Choice.Code)
    )]
    [JsonDerivedType(
        typeof(PaymentScheduleType2Choice.Proprietary),
        nameof(PaymentScheduleType2Choice.Proprietary)
    )]
    [IsoId("_TXFdkbb1Eeu9Cp6InX88Vw")]
    [DisplayName("Payment Schedule Type 2 Choice")]
    public abstract record PaymentScheduleType2Choice_ { }
}
