// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a list of pending statuses, final statuses or all statuses.
    /// </summary>
    [KnownType(typeof(PaymentStatusCodeSearch2Choice.PendingStatus))]
    [KnownType(typeof(PaymentStatusCodeSearch2Choice.FinalStatus))]
    [KnownType(typeof(PaymentStatusCodeSearch2Choice.PendingAndFinalStatus))]
    [JsonDerivedType(
        typeof(PaymentStatusCodeSearch2Choice.PendingStatus),
        nameof(PaymentStatusCodeSearch2Choice.PendingStatus)
    )]
    [JsonDerivedType(
        typeof(PaymentStatusCodeSearch2Choice.FinalStatus),
        nameof(PaymentStatusCodeSearch2Choice.FinalStatus)
    )]
    [JsonDerivedType(
        typeof(PaymentStatusCodeSearch2Choice.PendingAndFinalStatus),
        nameof(PaymentStatusCodeSearch2Choice.PendingAndFinalStatus)
    )]
    [IsoId("_RGEOMNp-Ed-ak6NoX_4Aeg_396814061")]
    [DisplayName("Payment Status Code Search 2 Choice")]
    public abstract record PaymentStatusCodeSearch2Choice_ { }
}
