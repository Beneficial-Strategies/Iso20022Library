// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between ways of identifying a payment instruction by its references and business identification.
    /// </summary>
    [KnownType(typeof(PaymentIdentification3Choice.PaymentInstructionReference))]
    [KnownType(typeof(PaymentIdentification3Choice.QueueIdentification))]
    [KnownType(typeof(PaymentIdentification3Choice.LongBusinessIdentification))]
    [KnownType(typeof(PaymentIdentification3Choice.ShortBusinessIdentification))]
    [KnownType(typeof(PaymentIdentification3Choice.ProprietaryReference))]
    [JsonDerivedType(typeof(PaymentIdentification3Choice.PaymentInstructionReference),nameof(PaymentIdentification3Choice.PaymentInstructionReference))]
    [JsonDerivedType(typeof(PaymentIdentification3Choice.QueueIdentification),nameof(PaymentIdentification3Choice.QueueIdentification))]
    [JsonDerivedType(typeof(PaymentIdentification3Choice.LongBusinessIdentification),nameof(PaymentIdentification3Choice.LongBusinessIdentification))]
    [JsonDerivedType(typeof(PaymentIdentification3Choice.ShortBusinessIdentification),nameof(PaymentIdentification3Choice.ShortBusinessIdentification))]
    [JsonDerivedType(typeof(PaymentIdentification3Choice.ProprietaryReference),nameof(PaymentIdentification3Choice.ProprietaryReference))]
    [IsoId("_RbYW59p-Ed-ak6NoX_4Aeg_-1132471784")]
    [DisplayName("Payment Identification 3 Choice")]
    public abstract partial record PaymentIdentification3Choice_
    {
    }
}
