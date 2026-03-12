// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between an accepted and a rejected status for the acceptance of a message.
    /// </summary>
    [KnownType(typeof(ResponseProcessingStatus1Choice.Accepted))]
    [KnownType(typeof(ResponseProcessingStatus1Choice.Rejected))]
    [JsonDerivedType(typeof(ResponseProcessingStatus1Choice.Accepted),nameof(ResponseProcessingStatus1Choice.Accepted))]
    [JsonDerivedType(typeof(ResponseProcessingStatus1Choice.Rejected),nameof(ResponseProcessingStatus1Choice.Rejected))]
    [IsoId("_f9a9gIeUEemJ1cSJJmVYRQ")]
    [DisplayName("Response Processing Status 1 Choice")]
    public abstract partial record ResponseProcessingStatus1Choice_
    {
    }
}
