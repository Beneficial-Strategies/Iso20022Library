// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies whether the status is provided with a reason or not.
    /// </summary>
    [KnownType(typeof(DeniedStatus2Choice.NoSpecifiedReason))]
    [KnownType(typeof(DeniedStatus2Choice.Reason))]
    [JsonDerivedType(
        typeof(DeniedStatus2Choice.NoSpecifiedReason),
        nameof(DeniedStatus2Choice.NoSpecifiedReason)
    )]
    [JsonDerivedType(typeof(DeniedStatus2Choice.Reason), nameof(DeniedStatus2Choice.Reason))]
    [IsoId("_UUc1xNp-Ed-ak6NoX_4Aeg_1894682971")]
    [DisplayName("Denied Status 2 Choice")]
    public abstract record DeniedStatus2Choice_ { }
}
