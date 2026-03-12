// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies whether the status is provided with a reason or not.
    /// </summary>
    [KnownType(typeof(UnmatchedStatus1Choice.NoSpecifiedReason))]
    [KnownType(typeof(UnmatchedStatus1Choice.Reason))]
    [JsonDerivedType(typeof(UnmatchedStatus1Choice.NoSpecifiedReason),nameof(UnmatchedStatus1Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(UnmatchedStatus1Choice.Reason),nameof(UnmatchedStatus1Choice.Reason))]
    [IsoId("_UaHY5dp-Ed-ak6NoX_4Aeg_-513133551")]
    [DisplayName("Unmatched Status 1 Choice")]
    public abstract partial record UnmatchedStatus1Choice_
    {
    }
}
