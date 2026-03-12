// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the matching processing change requested expressed as code
    /// </summary>
    [KnownType(typeof(Removal1Choice.Code))]
    [KnownType(typeof(Removal1Choice.Proprietary))]
    [JsonDerivedType(typeof(Removal1Choice.Code),nameof(Removal1Choice.Code))]
    [JsonDerivedType(typeof(Removal1Choice.Proprietary),nameof(Removal1Choice.Proprietary))]
    [IsoId("_f6-tYPkREeicy5Zn42b9bg")]
    [DisplayName("Removal 1 Choice")]
    public abstract partial record Removal1Choice_
    {
    }
}
