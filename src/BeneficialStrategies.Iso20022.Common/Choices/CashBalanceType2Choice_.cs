// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the balance type.
    /// </summary>
    [KnownType(typeof(CashBalanceType2Choice.Code))]
    [KnownType(typeof(CashBalanceType2Choice.Proprietary))]
    [JsonDerivedType(typeof(CashBalanceType2Choice.Code),nameof(CashBalanceType2Choice.Code))]
    [JsonDerivedType(typeof(CashBalanceType2Choice.Proprietary),nameof(CashBalanceType2Choice.Proprietary))]
    [IsoId("_lGGbleFWEeWIA4E9cYSxxQ")]
    [DisplayName("Cash Balance Type 2 Choice")]
    public abstract partial record CashBalanceType2Choice_
    {
    }
}
