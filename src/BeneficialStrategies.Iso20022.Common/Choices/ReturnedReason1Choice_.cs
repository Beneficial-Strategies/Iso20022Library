// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Returned Reason1Choice.
    /// </summary>
    [KnownType(typeof(ReturnedReason1Choice.Code))]
    [KnownType(typeof(ReturnedReason1Choice.Proprietary))]
    [JsonDerivedType(typeof(ReturnedReason1Choice.Code),nameof(ReturnedReason1Choice.Code))]
    [JsonDerivedType(typeof(ReturnedReason1Choice.Proprietary),nameof(ReturnedReason1Choice.Proprietary))]
    [IsoId("_sEEo6aGpEe-4O7NbwmwJkQ")]
    [DisplayName("Returned Reason1Choice")]
    public abstract partial record ReturnedReason1Choice_
    {
    }
}
