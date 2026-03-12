// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies whether the status is provided with a reason or not.
    /// </summary>
    [KnownType(typeof(UnmatchedStatus2Choice.NoSpecifiedReason))]
    [KnownType(typeof(UnmatchedStatus2Choice.Reason))]
    [JsonDerivedType(typeof(UnmatchedStatus2Choice.NoSpecifiedReason),nameof(UnmatchedStatus2Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(UnmatchedStatus2Choice.Reason),nameof(UnmatchedStatus2Choice.Reason))]
    [IsoId("_UWF0gdp-Ed-ak6NoX_4Aeg_-621975158")]
    [DisplayName("Unmatched Status 2 Choice")]
    public abstract partial record UnmatchedStatus2Choice_
    {
    }
}
