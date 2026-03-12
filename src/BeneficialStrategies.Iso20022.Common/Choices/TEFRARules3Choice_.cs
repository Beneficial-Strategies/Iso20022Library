// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for TEFRA rules.
    /// </summary>
    [KnownType(typeof(TEFRARules3Choice.Code))]
    [KnownType(typeof(TEFRARules3Choice.Proprietary))]
    [JsonDerivedType(typeof(TEFRARules3Choice.Code),nameof(TEFRARules3Choice.Code))]
    [JsonDerivedType(typeof(TEFRARules3Choice.Proprietary),nameof(TEFRARules3Choice.Proprietary))]
    [IsoId("_ighyQeLcEeWFtOV72FbX9w")]
    [DisplayName("TEFRA Rules 3 Choice")]
    public abstract partial record TEFRARules3Choice_
    {
    }
}
