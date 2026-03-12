// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between formats for the update type.
    /// </summary>
    [KnownType(typeof(StatementUpdateTypeCodeAndDSSCodeChoice.StatementUpdateTypeAsCode))]
    [KnownType(typeof(StatementUpdateTypeCodeAndDSSCodeChoice.StatementUpdateTypeAsDSS))]
    [JsonDerivedType(typeof(StatementUpdateTypeCodeAndDSSCodeChoice.StatementUpdateTypeAsCode),nameof(StatementUpdateTypeCodeAndDSSCodeChoice.StatementUpdateTypeAsCode))]
    [JsonDerivedType(typeof(StatementUpdateTypeCodeAndDSSCodeChoice.StatementUpdateTypeAsDSS),nameof(StatementUpdateTypeCodeAndDSSCodeChoice.StatementUpdateTypeAsDSS))]
    [IsoId("_Q7Cp89p-Ed-ak6NoX_4Aeg_2025558930")]
    [DisplayName("Statement Update Type Code And DSS Code Choice")]
    public abstract partial record StatementUpdateTypeCodeAndDSSCodeChoice_
    {
    }
}
