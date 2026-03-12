// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of generated status.
    /// </summary>
    [KnownType(typeof(GeneratedStatus1Choice.NoSpecifiedReason))]
    [KnownType(typeof(GeneratedStatus1Choice.Reason))]
    [JsonDerivedType(typeof(GeneratedStatus1Choice.NoSpecifiedReason),nameof(GeneratedStatus1Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(GeneratedStatus1Choice.Reason),nameof(GeneratedStatus1Choice.Reason))]
    [IsoId("_UY7GE9p-Ed-ak6NoX_4Aeg_107186789")]
    [DisplayName("Generated Status 1 Choice")]
    public abstract partial record GeneratedStatus1Choice_
    {
    }
}
