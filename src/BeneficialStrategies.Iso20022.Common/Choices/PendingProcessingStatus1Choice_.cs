// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies whether the status is provided with a reason or not.
    /// </summary>
    [KnownType(typeof(PendingProcessingStatus1Choice.NoSpecifiedReason))]
    [KnownType(typeof(PendingProcessingStatus1Choice.Reason))]
    [JsonDerivedType(typeof(PendingProcessingStatus1Choice.NoSpecifiedReason),nameof(PendingProcessingStatus1Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(PendingProcessingStatus1Choice.Reason),nameof(PendingProcessingStatus1Choice.Reason))]
    [IsoId("_UZXyBdp-Ed-ak6NoX_4Aeg_779893225")]
    [DisplayName("Pending Processing Status 1 Choice")]
    public abstract partial record PendingProcessingStatus1Choice_
    {
    }
}
