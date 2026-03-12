// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a list of pending statuses or final statuses.
    /// </summary>
    [KnownType(typeof(PaymentStatusCode3Choice.PendingStatus))]
    [KnownType(typeof(PaymentStatusCode3Choice.FinalStatus))]
    [JsonDerivedType(typeof(PaymentStatusCode3Choice.PendingStatus),nameof(PaymentStatusCode3Choice.PendingStatus))]
    [JsonDerivedType(typeof(PaymentStatusCode3Choice.FinalStatus),nameof(PaymentStatusCode3Choice.FinalStatus))]
    [IsoId("_RF7ER9p-Ed-ak6NoX_4Aeg_2006585714")]
    [DisplayName("Payment Status Code 3 Choice")]
    public abstract partial record PaymentStatusCode3Choice_
    {
    }
}
