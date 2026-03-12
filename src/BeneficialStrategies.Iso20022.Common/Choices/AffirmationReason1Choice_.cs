// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the affirmation status.
    /// </summary>
    [KnownType(typeof(AffirmationReason1Choice.Reason))]
    [KnownType(typeof(AffirmationReason1Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(AffirmationReason1Choice.Reason),nameof(AffirmationReason1Choice.Reason))]
    [JsonDerivedType(typeof(AffirmationReason1Choice.NoSpecifiedReason),nameof(AffirmationReason1Choice.NoSpecifiedReason))]
    [IsoId("_Azo44NokEeC60axPepSq7g_-579916981")]
    [DisplayName("Affirmation Reason 1 Choice")]
    public abstract partial record AffirmationReason1Choice_
    {
    }
}
