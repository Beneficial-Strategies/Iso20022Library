// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of either the last payment date or the number of payments to make.
    /// </summary>
    [KnownType(typeof(EndPoint1Choice.NumberOfPayments))]
    [KnownType(typeof(EndPoint1Choice.LastPaymentDate))]
    [JsonDerivedType(
        typeof(EndPoint1Choice.NumberOfPayments),
        nameof(EndPoint1Choice.NumberOfPayments)
    )]
    [JsonDerivedType(
        typeof(EndPoint1Choice.LastPaymentDate),
        nameof(EndPoint1Choice.LastPaymentDate)
    )]
    [IsoId("__b7DoQ2lEeSNWNtJlXOAhg")]
    [DisplayName("End Point 1 Choice")]
    public abstract record EndPoint1Choice_ { }
}
