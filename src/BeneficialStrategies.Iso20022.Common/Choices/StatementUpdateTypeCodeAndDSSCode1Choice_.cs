// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between formats for the update type.
    /// </summary>
    [KnownType(typeof(StatementUpdateTypeCodeAndDSSCode1Choice.StatementUpdateTypeAsCode))]
    [KnownType(typeof(StatementUpdateTypeCodeAndDSSCode1Choice.StatementUpdateTypeAsDSS))]
    [JsonDerivedType(
        typeof(StatementUpdateTypeCodeAndDSSCode1Choice.StatementUpdateTypeAsCode),
        nameof(StatementUpdateTypeCodeAndDSSCode1Choice.StatementUpdateTypeAsCode)
    )]
    [JsonDerivedType(
        typeof(StatementUpdateTypeCodeAndDSSCode1Choice.StatementUpdateTypeAsDSS),
        nameof(StatementUpdateTypeCodeAndDSSCode1Choice.StatementUpdateTypeAsDSS)
    )]
    [IsoId("_sFNQkQaUEe2-DuDrUXkg2w")]
    [DisplayName("Statement Update Type Code And DSS Code 1 Choice")]
    public abstract record StatementUpdateTypeCodeAndDSSCode1Choice_ { }
}
