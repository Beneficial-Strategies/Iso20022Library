// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or proprietary code to specify the type of the additional business process.
    /// </summary>
    [KnownType(typeof(AdditionalBusinessProcessFormat12Choice.Code))]
    [KnownType(typeof(AdditionalBusinessProcessFormat12Choice.Proprietary))]
    [JsonDerivedType(typeof(AdditionalBusinessProcessFormat12Choice.Code),nameof(AdditionalBusinessProcessFormat12Choice.Code))]
    [JsonDerivedType(typeof(AdditionalBusinessProcessFormat12Choice.Proprietary),nameof(AdditionalBusinessProcessFormat12Choice.Proprietary))]
    [IsoId("_c5V6R5KQEeWHWpTQn1FFVg")]
    [DisplayName("Additional Business Process Format 12 Choice")]
    public abstract partial record AdditionalBusinessProcessFormat12Choice_
    {
    }
}
