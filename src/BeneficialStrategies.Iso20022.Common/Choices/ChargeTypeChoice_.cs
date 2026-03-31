// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Charge is expressed as a code or a bilaterally agreed code.
    /// </summary>
    [KnownType(typeof(ChargeTypeChoice.Code))]
    [KnownType(typeof(ChargeTypeChoice.ProprietaryCode))]
    [JsonDerivedType(typeof(ChargeTypeChoice.Code), nameof(ChargeTypeChoice.Code))]
    [JsonDerivedType(
        typeof(ChargeTypeChoice.ProprietaryCode),
        nameof(ChargeTypeChoice.ProprietaryCode)
    )]
    [IsoId("_RIcz1Np-Ed-ak6NoX_4Aeg_-1267403817")]
    [DisplayName("Charge Type Choice")]
    public abstract record ChargeTypeChoice_ { }
}
