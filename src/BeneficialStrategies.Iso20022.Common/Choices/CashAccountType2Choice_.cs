// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Nature or use of the account.
    /// </summary>
    [KnownType(typeof(CashAccountType2Choice.Code))]
    [KnownType(typeof(CashAccountType2Choice.Proprietary))]
    [JsonDerivedType(typeof(CashAccountType2Choice.Code), nameof(CashAccountType2Choice.Code))]
    [JsonDerivedType(
        typeof(CashAccountType2Choice.Proprietary),
        nameof(CashAccountType2Choice.Proprietary)
    )]
    [IsoId("_sb6WgFkyEeGeoaLUQk__nA_1768299331")]
    [DisplayName("Cash Account Type 2 Choice")]
    public abstract record CashAccountType2Choice_ { }
}
