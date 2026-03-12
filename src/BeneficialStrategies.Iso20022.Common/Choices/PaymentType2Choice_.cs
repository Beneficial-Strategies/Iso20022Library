// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice beween a payment type from a predefined list and a proprietary payment type.
    /// </summary>
    [KnownType(typeof(PaymentType2Choice.PaymentType))]
    [KnownType(typeof(PaymentType2Choice.ProprietaryPaymentType))]
    [JsonDerivedType(typeof(PaymentType2Choice.PaymentType),nameof(PaymentType2Choice.PaymentType))]
    [JsonDerivedType(typeof(PaymentType2Choice.ProprietaryPaymentType),nameof(PaymentType2Choice.ProprietaryPaymentType))]
    [IsoId("_RKPjk9p-Ed-ak6NoX_4Aeg_880263732")]
    [DisplayName("Payment Type 2 Choice")]
    public abstract partial record PaymentType2Choice_
    {
    }
}
