// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the allegment reason.
    /// </summary>
    [KnownType(typeof(AllegmentReason1Choice.Code))]
    [KnownType(typeof(AllegmentReason1Choice.Proprietary))]
    [JsonDerivedType(typeof(AllegmentReason1Choice.Code),nameof(AllegmentReason1Choice.Code))]
    [JsonDerivedType(typeof(AllegmentReason1Choice.Proprietary),nameof(AllegmentReason1Choice.Proprietary))]
    [IsoId("_A4j1INokEeC60axPepSq7g_-73094806")]
    [DisplayName("Allegment Reason 1 Choice")]
    public abstract partial record AllegmentReason1Choice_
    {
    }
}
