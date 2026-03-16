// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the balance type.
    /// </summary>
    [KnownType(typeof(SecuritiesBalanceType11Choice.Code))]
    [KnownType(typeof(SecuritiesBalanceType11Choice.Proprietary))]
    [JsonDerivedType(
        typeof(SecuritiesBalanceType11Choice.Code),
        nameof(SecuritiesBalanceType11Choice.Code)
    )]
    [JsonDerivedType(
        typeof(SecuritiesBalanceType11Choice.Proprietary),
        nameof(SecuritiesBalanceType11Choice.Proprietary)
    )]
    [IsoId("_5SHcZ5NLEeWGlc8L7oPDIg")]
    [DisplayName("Securities Balance Type 11 Choice")]
    public abstract record SecuritiesBalanceType11Choice_ { }
}
