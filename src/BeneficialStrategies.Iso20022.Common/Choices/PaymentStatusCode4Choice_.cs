// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a list of pending statuses or final statuses.
    /// </summary>
    [KnownType(typeof(PaymentStatusCode4Choice.PendingStatus))]
    [KnownType(typeof(PaymentStatusCode4Choice.FinalStatus))]
    [KnownType(typeof(PaymentStatusCode4Choice.ProprietaryStatus))]
    [JsonDerivedType(typeof(PaymentStatusCode4Choice.PendingStatus),nameof(PaymentStatusCode4Choice.PendingStatus))]
    [JsonDerivedType(typeof(PaymentStatusCode4Choice.FinalStatus),nameof(PaymentStatusCode4Choice.FinalStatus))]
    [JsonDerivedType(typeof(PaymentStatusCode4Choice.ProprietaryStatus),nameof(PaymentStatusCode4Choice.ProprietaryStatus))]
    [IsoId("_RZcdOtp-Ed-ak6NoX_4Aeg_1463454824")]
    [DisplayName("Payment Status Code 4 Choice")]
    public abstract partial record PaymentStatusCode4Choice_
    {
    }
}
