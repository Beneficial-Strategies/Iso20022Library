// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the statement type.
    /// </summary>
    [KnownType(typeof(StatementType2Choice.Code))]
    [KnownType(typeof(StatementType2Choice.Proprietary))]
    [JsonDerivedType(typeof(StatementType2Choice.Code), nameof(StatementType2Choice.Code))]
    [JsonDerivedType(
        typeof(StatementType2Choice.Proprietary),
        nameof(StatementType2Choice.Proprietary)
    )]
    [IsoId("_QrZre9p-Ed-ak6NoX_4Aeg_1714692678")]
    [DisplayName("Statement Type 2 Choice")]
    public abstract record StatementType2Choice_ { }
}
