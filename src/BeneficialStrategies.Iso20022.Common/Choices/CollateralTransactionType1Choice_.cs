// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the type of collateral instruction.
    /// </summary>
    [KnownType(typeof(CollateralTransactionType1Choice.Code))]
    [KnownType(typeof(CollateralTransactionType1Choice.Proprietary))]
    [JsonDerivedType(
        typeof(CollateralTransactionType1Choice.Code),
        nameof(CollateralTransactionType1Choice.Code)
    )]
    [JsonDerivedType(
        typeof(CollateralTransactionType1Choice.Proprietary),
        nameof(CollateralTransactionType1Choice.Proprietary)
    )]
    [IsoId("_NmCJ0LwdEeivTd4NUfCi2g")]
    [DisplayName("Collateral Transaction Type 1 Choice")]
    public abstract record CollateralTransactionType1Choice_ { }
}
