// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the Awaiting Affirmation reason.
    /// </summary>
    [KnownType(typeof(AwaitingAffirmationReason1Choice.Code))]
    [KnownType(typeof(AwaitingAffirmationReason1Choice.Proprietary))]
    [JsonDerivedType(typeof(AwaitingAffirmationReason1Choice.Code),nameof(AwaitingAffirmationReason1Choice.Code))]
    [JsonDerivedType(typeof(AwaitingAffirmationReason1Choice.Proprietary),nameof(AwaitingAffirmationReason1Choice.Proprietary))]
    [IsoId("_A6MM0NokEeC60axPepSq7g_-1469713993")]
    [DisplayName("Awaiting Affirmation Reason 1 Choice")]
    public abstract partial record AwaitingAffirmationReason1Choice_
    {
    }
}
