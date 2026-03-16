// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Returned Reason2Choice.
    /// </summary>
    [KnownType(typeof(ReturnedReason2Choice.Code))]
    [KnownType(typeof(ReturnedReason2Choice.Proprietary))]
    [JsonDerivedType(typeof(ReturnedReason2Choice.Code), nameof(ReturnedReason2Choice.Code))]
    [JsonDerivedType(
        typeof(ReturnedReason2Choice.Proprietary),
        nameof(ReturnedReason2Choice.Proprietary)
    )]
    [IsoId("_ohK2UIS_Ee-1WeOqsw_6eA")]
    [DisplayName("Returned Reason2Choice")]
    public abstract record ReturnedReason2Choice_ { }
}
