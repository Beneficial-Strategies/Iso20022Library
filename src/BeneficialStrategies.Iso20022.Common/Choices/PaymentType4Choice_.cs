// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a payment type from a predefined list and a proprietary payment type.
    /// </summary>
    [KnownType(typeof(PaymentType4Choice.Code))]
    [KnownType(typeof(PaymentType4Choice.Proprietary))]
    [JsonDerivedType(typeof(PaymentType4Choice.Code),nameof(PaymentType4Choice.Code))]
    [JsonDerivedType(typeof(PaymentType4Choice.Proprietary),nameof(PaymentType4Choice.Proprietary))]
    [IsoId("_Kjf4MxbwEeOy-PlRuFSUzQ")]
    [DisplayName("Payment Type 4 Choice")]
    public abstract partial record PaymentType4Choice_
    {
    }
}
