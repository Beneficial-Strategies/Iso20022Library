// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the Modification reason.
    /// </summary>
    [KnownType(typeof(ModificationReason4Choice.Code))]
    [KnownType(typeof(ModificationReason4Choice.Proprietary))]
    [JsonDerivedType(typeof(ModificationReason4Choice.Code),nameof(ModificationReason4Choice.Code))]
    [JsonDerivedType(typeof(ModificationReason4Choice.Proprietary),nameof(ModificationReason4Choice.Proprietary))]
    [IsoId("_DdDr2zq3EeWyoP0PbocV1Q")]
    [DisplayName("Modification Reason 4 Choice")]
    public abstract partial record ModificationReason4Choice_
    {
    }
}
