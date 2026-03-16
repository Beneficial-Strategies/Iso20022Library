// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the statement basis.
    /// </summary>
    [KnownType(typeof(StatementBasis14Choice.Code))]
    [KnownType(typeof(StatementBasis14Choice.Proprietary))]
    [JsonDerivedType(typeof(StatementBasis14Choice.Code), nameof(StatementBasis14Choice.Code))]
    [JsonDerivedType(
        typeof(StatementBasis14Choice.Proprietary),
        nameof(StatementBasis14Choice.Proprietary)
    )]
    [IsoId("_KhZx8MRyEeij-rSPpvD-Tw")]
    [DisplayName("Statement Basis 14 Choice")]
    public abstract record StatementBasis14Choice_ { }
}
