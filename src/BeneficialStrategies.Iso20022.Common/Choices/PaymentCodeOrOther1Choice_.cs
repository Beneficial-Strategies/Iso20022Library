// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a payment term in a coded or free format.
    /// </summary>
    [KnownType(typeof(PaymentCodeOrOther1Choice.PaymentCode))]
    [KnownType(typeof(PaymentCodeOrOther1Choice.PaymentDueDate))]
    [KnownType(typeof(PaymentCodeOrOther1Choice.OtherPaymentTerms))]
    [JsonDerivedType(
        typeof(PaymentCodeOrOther1Choice.PaymentCode),
        nameof(PaymentCodeOrOther1Choice.PaymentCode)
    )]
    [JsonDerivedType(
        typeof(PaymentCodeOrOther1Choice.PaymentDueDate),
        nameof(PaymentCodeOrOther1Choice.PaymentDueDate)
    )]
    [JsonDerivedType(
        typeof(PaymentCodeOrOther1Choice.OtherPaymentTerms),
        nameof(PaymentCodeOrOther1Choice.OtherPaymentTerms)
    )]
    [IsoId("_ogNJwNP8EeK0PPbKncCqzA")]
    [DisplayName("Payment Code Or Other 1 Choice")]
    public abstract record PaymentCodeOrOther1Choice_ { }
}
