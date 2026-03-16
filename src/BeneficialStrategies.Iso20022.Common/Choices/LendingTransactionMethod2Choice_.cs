// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format method applied to a lending transaction.
    /// </summary>
    [KnownType(typeof(LendingTransactionMethod2Choice.Code))]
    [KnownType(typeof(LendingTransactionMethod2Choice.Proprietary))]
    [JsonDerivedType(
        typeof(LendingTransactionMethod2Choice.Code),
        nameof(LendingTransactionMethod2Choice.Code)
    )]
    [JsonDerivedType(
        typeof(LendingTransactionMethod2Choice.Proprietary),
        nameof(LendingTransactionMethod2Choice.Proprietary)
    )]
    [IsoId("_2NBuAZEjEeakHoV5BVecAQ")]
    [DisplayName("Lending Transaction Method 2 Choice")]
    public abstract record LendingTransactionMethod2Choice_ { }
}
