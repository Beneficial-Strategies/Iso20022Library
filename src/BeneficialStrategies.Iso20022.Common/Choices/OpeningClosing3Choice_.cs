// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the opening closing information.
    /// </summary>
    [KnownType(typeof(OpeningClosing3Choice.Code))]
    [KnownType(typeof(OpeningClosing3Choice.Proprietary))]
    [JsonDerivedType(typeof(OpeningClosing3Choice.Code),nameof(OpeningClosing3Choice.Code))]
    [JsonDerivedType(typeof(OpeningClosing3Choice.Proprietary),nameof(OpeningClosing3Choice.Proprietary))]
    [IsoId("_gj_VkTtCEeWRTLSN0i0tng")]
    [DisplayName("Opening Closing 3 Choice")]
    public abstract partial record OpeningClosing3Choice_
    {
    }
}
