// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between formats for the statement basis.
    /// </summary>
    [KnownType(typeof(StatementBasisCodeAndDSSCodeChoice.StatementBasisAsCode))]
    [KnownType(typeof(StatementBasisCodeAndDSSCodeChoice.StatementBasisAsDSS))]
    [JsonDerivedType(typeof(StatementBasisCodeAndDSSCodeChoice.StatementBasisAsCode),nameof(StatementBasisCodeAndDSSCodeChoice.StatementBasisAsCode))]
    [JsonDerivedType(typeof(StatementBasisCodeAndDSSCodeChoice.StatementBasisAsDSS),nameof(StatementBasisCodeAndDSSCodeChoice.StatementBasisAsDSS))]
    [IsoId("_Q7Cp8Np-Ed-ak6NoX_4Aeg_-1357896034")]
    [DisplayName("Statement Basis Code And DSS Code Choice")]
    public abstract partial record StatementBasisCodeAndDSSCodeChoice_
    {
    }
}
