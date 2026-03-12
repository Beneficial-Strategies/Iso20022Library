// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a reason or no reason for the corporate action instruction processing pending status.
    /// </summary>
    [KnownType(typeof(PendingStatus1Choice.NoSpecifiedReason))]
    [KnownType(typeof(PendingStatus1Choice.Reason))]
    [JsonDerivedType(typeof(PendingStatus1Choice.NoSpecifiedReason),nameof(PendingStatus1Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(PendingStatus1Choice.Reason),nameof(PendingStatus1Choice.Reason))]
    [IsoId("_QyZrU9p-Ed-ak6NoX_4Aeg_-637156012")]
    [DisplayName("Pending Status 1 Choice")]
    public abstract partial record PendingStatus1Choice_
    {
    }
}
