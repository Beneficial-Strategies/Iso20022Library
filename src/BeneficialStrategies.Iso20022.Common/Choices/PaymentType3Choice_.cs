// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a payment type from a predefined list and a proprietary payment type.
    /// </summary>
    [KnownType(typeof(PaymentType3Choice.Code))]
    [KnownType(typeof(PaymentType3Choice.Proprietary))]
    [JsonDerivedType(typeof(PaymentType3Choice.Code),nameof(PaymentType3Choice.Code))]
    [JsonDerivedType(typeof(PaymentType3Choice.Proprietary),nameof(PaymentType3Choice.Proprietary))]
    [IsoId("_72PJGKMgEeCJ6YNENx4h-w_1987696295")]
    [DisplayName("Payment Type 3 Choice")]
    public abstract partial record PaymentType3Choice_
    {
    }
}
