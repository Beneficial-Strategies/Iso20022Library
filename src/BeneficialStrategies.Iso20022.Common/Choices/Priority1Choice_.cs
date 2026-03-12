// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Priority is expressed as a code or a text.
    /// </summary>
    [KnownType(typeof(Priority1Choice.Code))]
    [KnownType(typeof(Priority1Choice.Proprietary))]
    [JsonDerivedType(typeof(Priority1Choice.Code),nameof(Priority1Choice.Code))]
    [JsonDerivedType(typeof(Priority1Choice.Proprietary),nameof(Priority1Choice.Proprietary))]
    [IsoId("_SEJYAX_REeiik6YN_dzlEA")]
    [DisplayName("Priority 1 Choice")]
    public abstract partial record Priority1Choice_
    {
    }
}
