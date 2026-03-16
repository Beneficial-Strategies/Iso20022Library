// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Additional Business Process Format23Choice.
    /// </summary>
    [KnownType(typeof(AdditionalBusinessProcessFormat23Choice.Code))]
    [KnownType(typeof(AdditionalBusinessProcessFormat23Choice.Proprietary))]
    [JsonDerivedType(typeof(AdditionalBusinessProcessFormat23Choice.Code),nameof(AdditionalBusinessProcessFormat23Choice.Code))]
    [JsonDerivedType(typeof(AdditionalBusinessProcessFormat23Choice.Proprietary),nameof(AdditionalBusinessProcessFormat23Choice.Proprietary))]
    [IsoId("_H55U14YVEe-haozGYc1X7Q")]
    [DisplayName("Additional Business Process Format23Choice")]
    public abstract partial record AdditionalBusinessProcessFormat23Choice_
    {
    }
}
