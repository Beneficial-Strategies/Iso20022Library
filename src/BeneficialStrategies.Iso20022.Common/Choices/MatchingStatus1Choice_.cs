// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the matching status.
    /// </summary>
    [KnownType(typeof(MatchingStatus1Choice.Code))]
    [KnownType(typeof(MatchingStatus1Choice.Proprietary))]
    [JsonDerivedType(typeof(MatchingStatus1Choice.Code),nameof(MatchingStatus1Choice.Code))]
    [JsonDerivedType(typeof(MatchingStatus1Choice.Proprietary),nameof(MatchingStatus1Choice.Proprietary))]
    [IsoId("_UaaT29p-Ed-ak6NoX_4Aeg_-1299791390")]
    [DisplayName("Matching Status 1 Choice")]
    public abstract partial record MatchingStatus1Choice_
    {
    }
}
