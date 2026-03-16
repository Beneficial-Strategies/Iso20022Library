// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the Pending Processing status.
    /// </summary>
    [KnownType(typeof(PendingProcessing1Choice.NoSpecifiedReason))]
    [KnownType(typeof(PendingProcessing1Choice.Reason))]
    [JsonDerivedType(
        typeof(PendingProcessing1Choice.NoSpecifiedReason),
        nameof(PendingProcessing1Choice.NoSpecifiedReason)
    )]
    [JsonDerivedType(
        typeof(PendingProcessing1Choice.Reason),
        nameof(PendingProcessing1Choice.Reason)
    )]
    [IsoId("_Azyp4NokEeC60axPepSq7g_-1440750655")]
    [DisplayName("Pending Processing 1 Choice")]
    public abstract record PendingProcessing1Choice_ { }
}
