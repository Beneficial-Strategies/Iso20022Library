// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Additional Business Process Format24Choice.
    /// </summary>
    [KnownType(typeof(AdditionalBusinessProcessFormat24Choice.Code))]
    [KnownType(typeof(AdditionalBusinessProcessFormat24Choice.Proprietary))]
    [JsonDerivedType(typeof(AdditionalBusinessProcessFormat24Choice.Code),nameof(AdditionalBusinessProcessFormat24Choice.Code))]
    [JsonDerivedType(typeof(AdditionalBusinessProcessFormat24Choice.Proprietary),nameof(AdditionalBusinessProcessFormat24Choice.Proprietary))]
    [IsoId("_kv5XmZt3Ee-wQIOX0djF2w")]
    [DisplayName("Additional Business Process Format24Choice")]
    public abstract partial record AdditionalBusinessProcessFormat24Choice_
    {
    }
}
