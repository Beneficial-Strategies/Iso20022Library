// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the role associated with a specific party in relation to a payment instruction.
    /// </summary>
    [KnownType(typeof(PaymentRole1Choice.Code))]
    [KnownType(typeof(PaymentRole1Choice.Proprietary))]
    [JsonDerivedType(typeof(PaymentRole1Choice.Code),nameof(PaymentRole1Choice.Code))]
    [JsonDerivedType(typeof(PaymentRole1Choice.Proprietary),nameof(PaymentRole1Choice.Proprietary))]
    [IsoId("_b_Ox03hiEeidzqjNEfehPg")]
    [DisplayName("Payment Role 1 Choice")]
    public abstract partial record PaymentRole1Choice_
    {
    }
}
