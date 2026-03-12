// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the pending reason.
    /// </summary>
    [KnownType(typeof(PendingReason1Choice.Code))]
    [KnownType(typeof(PendingReason1Choice.Proprietary))]
    [JsonDerivedType(typeof(PendingReason1Choice.Code),nameof(PendingReason1Choice.Code))]
    [JsonDerivedType(typeof(PendingReason1Choice.Proprietary),nameof(PendingReason1Choice.Proprietary))]
    [IsoId("_UZ0d8Np-Ed-ak6NoX_4Aeg_-272082906")]
    [DisplayName("Pending Reason 1 Choice")]
    public abstract partial record PendingReason1Choice_
    {
    }
}
