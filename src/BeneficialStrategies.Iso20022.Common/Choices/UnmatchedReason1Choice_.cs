// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the settlement transaction unmatched reason.
    /// </summary>
    [KnownType(typeof(UnmatchedReason1Choice.Code))]
    [KnownType(typeof(UnmatchedReason1Choice.Proprietary))]
    [JsonDerivedType(typeof(UnmatchedReason1Choice.Code),nameof(UnmatchedReason1Choice.Code))]
    [JsonDerivedType(typeof(UnmatchedReason1Choice.Proprietary),nameof(UnmatchedReason1Choice.Proprietary))]
    [IsoId("_UZ9n6Np-Ed-ak6NoX_4Aeg_-758917820")]
    [DisplayName("Unmatched Reason 1 Choice")]
    public abstract partial record UnmatchedReason1Choice_
    {
    }
}
