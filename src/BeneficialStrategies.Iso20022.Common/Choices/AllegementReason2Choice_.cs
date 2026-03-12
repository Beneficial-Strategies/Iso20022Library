// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the allegment reason.
    /// </summary>
    [KnownType(typeof(AllegementReason2Choice.Code))]
    [KnownType(typeof(AllegementReason2Choice.Proprietary))]
    [JsonDerivedType(typeof(AllegementReason2Choice.Code),nameof(AllegementReason2Choice.Code))]
    [JsonDerivedType(typeof(AllegementReason2Choice.Proprietary),nameof(AllegementReason2Choice.Proprietary))]
    [IsoId("_3TyQtQd3Ee2fOITqoTnSLQ")]
    [DisplayName("Allegement Reason 2 Choice")]
    public abstract partial record AllegementReason2Choice_
    {
    }
}
