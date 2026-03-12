// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the Modification reason.
    /// </summary>
    [KnownType(typeof(ModificationReason5Choice.Code))]
    [KnownType(typeof(ModificationReason5Choice.Proprietary))]
    [JsonDerivedType(typeof(ModificationReason5Choice.Code),nameof(ModificationReason5Choice.Code))]
    [JsonDerivedType(typeof(ModificationReason5Choice.Proprietary),nameof(ModificationReason5Choice.Proprietary))]
    [IsoId("_6QDrcZNLEeWGlc8L7oPDIg")]
    [DisplayName("Modification Reason 5 Choice")]
    public abstract partial record ModificationReason5Choice_
    {
    }
}
