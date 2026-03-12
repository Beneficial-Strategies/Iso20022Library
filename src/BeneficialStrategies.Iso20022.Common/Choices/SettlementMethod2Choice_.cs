// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Settlement details to determine whether payment is a credit or debit.
    /// </summary>
    [KnownType(typeof(SettlementMethod2Choice.Credit))]
    [KnownType(typeof(SettlementMethod2Choice.Debit))]
    [JsonDerivedType(typeof(SettlementMethod2Choice.Credit),nameof(SettlementMethod2Choice.Credit))]
    [JsonDerivedType(typeof(SettlementMethod2Choice.Debit),nameof(SettlementMethod2Choice.Debit))]
    [IsoId("_68jSJ248EeiU9cctagi5ow")]
    [DisplayName("Settlement Method 2 Choice")]
    public abstract partial record SettlementMethod2Choice_
    {
    }
}
