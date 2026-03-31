// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Classification of the type of security.
    /// </summary>
    [KnownType(typeof(SecuritiesLendingType3Choice.Code))]
    [KnownType(typeof(SecuritiesLendingType3Choice.Proprietary))]
    [JsonDerivedType(
        typeof(SecuritiesLendingType3Choice.Code),
        nameof(SecuritiesLendingType3Choice.Code)
    )]
    [JsonDerivedType(
        typeof(SecuritiesLendingType3Choice.Proprietary),
        nameof(SecuritiesLendingType3Choice.Proprietary)
    )]
    [IsoId("_9FMogMkbEeeiAIB1i4AlQw")]
    [DisplayName("Securities Lending Type 3 Choice")]
    public abstract record SecuritiesLendingType3Choice_ { }
}
