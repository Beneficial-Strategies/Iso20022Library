// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of input source for the generation of the file.
    /// </summary>
    [KnownType(typeof(IsabelInputSource1Choice.Code))]
    [KnownType(typeof(IsabelInputSource1Choice.Proprietary))]
    [JsonDerivedType(typeof(IsabelInputSource1Choice.Code),nameof(IsabelInputSource1Choice.Code))]
    [JsonDerivedType(typeof(IsabelInputSource1Choice.Proprietary),nameof(IsabelInputSource1Choice.Proprietary))]
    [IsoId("_OGcMMMmMEeWAGphE2LvqeA")]
    [DisplayName("Isabel Input Source 1 Choice")]
    public abstract partial record IsabelInputSource1Choice_
    {
    }
}
