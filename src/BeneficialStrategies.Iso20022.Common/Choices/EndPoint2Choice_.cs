// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of either the last payment date or the number of payments to make.
    /// </summary>
    [KnownType(typeof(EndPoint2Choice.NumberOfPayments))]
    [KnownType(typeof(EndPoint2Choice.LastPaymentDate))]
    [JsonDerivedType(typeof(EndPoint2Choice.NumberOfPayments), nameof(EndPoint2Choice.NumberOfPayments))]
    [JsonDerivedType(typeof(EndPoint2Choice.LastPaymentDate), nameof(EndPoint2Choice.LastPaymentDate))]
    [IsoId("_avgfkbvGEfCYYbmqNrQFSg")]
    [DisplayName("End Point 2 Choice")]
    public abstract record EndPoint2Choice_ { }
}
