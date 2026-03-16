// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats to express the renounceable status.
    /// </summary>
    [KnownType(typeof(RenounceableStatus1FormatChoice.Code))]
    [KnownType(typeof(RenounceableStatus1FormatChoice.Proprietary))]
    [JsonDerivedType(
        typeof(RenounceableStatus1FormatChoice.Code),
        nameof(RenounceableStatus1FormatChoice.Code)
    )]
    [JsonDerivedType(
        typeof(RenounceableStatus1FormatChoice.Proprietary),
        nameof(RenounceableStatus1FormatChoice.Proprietary)
    )]
    [IsoId("_RoygwNp-Ed-ak6NoX_4Aeg_-1304409096")]
    [DisplayName("Renounceable Status 1 Format Choice")]
    public abstract record RenounceableStatus1FormatChoice_ { }
}
