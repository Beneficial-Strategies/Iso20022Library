// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the balance details.
    /// </summary>
    [KnownType(typeof(ContractBalanceType1Choice.Code))]
    [KnownType(typeof(ContractBalanceType1Choice.Proprietary))]
    [JsonDerivedType(
        typeof(ContractBalanceType1Choice.Code),
        nameof(ContractBalanceType1Choice.Code)
    )]
    [JsonDerivedType(
        typeof(ContractBalanceType1Choice.Proprietary),
        nameof(ContractBalanceType1Choice.Proprietary)
    )]
    [IsoId("_ntL44QtKEeWkxvNyFrBT8Q")]
    [DisplayName("Contract Balance Type 1 Choice")]
    public abstract record ContractBalanceType1Choice_ { }
}
