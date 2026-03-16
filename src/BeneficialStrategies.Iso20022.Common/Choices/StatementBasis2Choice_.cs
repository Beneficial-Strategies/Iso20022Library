// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the statement basis.
    /// </summary>
    [KnownType(typeof(StatementBasis2Choice.Code))]
    [KnownType(typeof(StatementBasis2Choice.Proprietary))]
    [JsonDerivedType(typeof(StatementBasis2Choice.Code), nameof(StatementBasis2Choice.Code))]
    [JsonDerivedType(
        typeof(StatementBasis2Choice.Proprietary),
        nameof(StatementBasis2Choice.Proprietary)
    )]
    [IsoId("_Qri1Ydp-Ed-ak6NoX_4Aeg_-1453158571")]
    [DisplayName("Statement Basis 2 Choice")]
    public abstract record StatementBasis2Choice_ { }
}
