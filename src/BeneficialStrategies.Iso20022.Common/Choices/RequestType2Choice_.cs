// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Defines the type of action to be performed in the request.
    /// </summary>
    [KnownType(typeof(RequestType2Choice.PaymentControl))]
    [KnownType(typeof(RequestType2Choice.Enquiry))]
    [KnownType(typeof(RequestType2Choice.Proprietary))]
    [JsonDerivedType(
        typeof(RequestType2Choice.PaymentControl),
        nameof(RequestType2Choice.PaymentControl)
    )]
    [JsonDerivedType(typeof(RequestType2Choice.Enquiry), nameof(RequestType2Choice.Enquiry))]
    [JsonDerivedType(
        typeof(RequestType2Choice.Proprietary),
        nameof(RequestType2Choice.Proprietary)
    )]
    [IsoId("_76G8cqMgEeCJ6YNENx4h-w_-156360077")]
    [DisplayName("Request Type 2 Choice")]
    public abstract record RequestType2Choice_ { }
}
