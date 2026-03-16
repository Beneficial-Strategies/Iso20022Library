// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a payment term in a coded or free format.
    /// </summary>
    [KnownType(typeof(PaymentCodeOrOther2Choice.PaymentCode))]
    [KnownType(typeof(PaymentCodeOrOther2Choice.PaymentDueDate))]
    [KnownType(typeof(PaymentCodeOrOther2Choice.OtherPaymentTerms))]
    [JsonDerivedType(
        typeof(PaymentCodeOrOther2Choice.PaymentCode),
        nameof(PaymentCodeOrOther2Choice.PaymentCode)
    )]
    [JsonDerivedType(
        typeof(PaymentCodeOrOther2Choice.PaymentDueDate),
        nameof(PaymentCodeOrOther2Choice.PaymentDueDate)
    )]
    [JsonDerivedType(
        typeof(PaymentCodeOrOther2Choice.OtherPaymentTerms),
        nameof(PaymentCodeOrOther2Choice.OtherPaymentTerms)
    )]
    [IsoId("_RfD1sRVgEeOrY9qSHVspCA")]
    [DisplayName("Payment Code Or Other 2 Choice")]
    public abstract record PaymentCodeOrOther2Choice_ { }
}
