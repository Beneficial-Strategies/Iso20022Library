// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the settlement date code.
    /// </summary>
    [KnownType(typeof(SettlementDateCode2Choice.Code))]
    [KnownType(typeof(SettlementDateCode2Choice.Proprietary))]
    [JsonDerivedType(
        typeof(SettlementDateCode2Choice.Code),
        nameof(SettlementDateCode2Choice.Code)
    )]
    [JsonDerivedType(
        typeof(SettlementDateCode2Choice.Proprietary),
        nameof(SettlementDateCode2Choice.Proprietary)
    )]
    [IsoId("_QurB5Np-Ed-ak6NoX_4Aeg_-1955127258")]
    [DisplayName("Settlement Date Code 2 Choice")]
    public abstract record SettlementDateCode2Choice_ { }
}
