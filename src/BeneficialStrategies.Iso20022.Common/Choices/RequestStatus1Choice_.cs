// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Request Status1Choice.
    /// </summary>
    [KnownType(typeof(RequestStatus1Choice.Code))]
    [KnownType(typeof(RequestStatus1Choice.Proprietary))]
    [JsonDerivedType(typeof(RequestStatus1Choice.Code),nameof(RequestStatus1Choice.Code))]
    [JsonDerivedType(typeof(RequestStatus1Choice.Proprietary),nameof(RequestStatus1Choice.Proprietary))]
    [IsoId("_0Kkf8LqsEe68nbz8Nl_hLQ")]
    [DisplayName("Request Status1Choice")]
    public abstract partial record RequestStatus1Choice_
    {
    }
}
