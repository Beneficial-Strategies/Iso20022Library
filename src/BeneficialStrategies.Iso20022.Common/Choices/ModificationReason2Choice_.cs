// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the Modification reason.
    /// </summary>
    [KnownType(typeof(ModificationReason2Choice.Code))]
    [KnownType(typeof(ModificationReason2Choice.Proprietary))]
    [JsonDerivedType(
        typeof(ModificationReason2Choice.Code),
        nameof(ModificationReason2Choice.Code)
    )]
    [JsonDerivedType(
        typeof(ModificationReason2Choice.Proprietary),
        nameof(ModificationReason2Choice.Proprietary)
    )]
    [IsoId("_0jrN8glIEeGATtfOBToyew_727548806")]
    [DisplayName("Modification Reason 2 Choice")]
    public abstract record ModificationReason2Choice_ { }
}
