// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the submission channel.
    /// </summary>
    [KnownType(typeof(Channel1Choice.Code))]
    [KnownType(typeof(Channel1Choice.Proprietary))]
    [JsonDerivedType(typeof(Channel1Choice.Code),nameof(Channel1Choice.Code))]
    [JsonDerivedType(typeof(Channel1Choice.Proprietary),nameof(Channel1Choice.Proprietary))]
    [IsoId("_93Z_wHltEeG7BsjMvd1mEw_-1487139441")]
    [DisplayName("Channel 1 Choice")]
    public abstract partial record Channel1Choice_
    {
    }
}
