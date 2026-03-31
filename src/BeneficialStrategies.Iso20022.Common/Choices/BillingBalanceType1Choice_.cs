// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Defines the type of the billing balance.
    /// </summary>
    [KnownType(typeof(BillingBalanceType1Choice.Code))]
    [KnownType(typeof(BillingBalanceType1Choice.Proprietary))]
    [JsonDerivedType(
        typeof(BillingBalanceType1Choice.Code),
        nameof(BillingBalanceType1Choice.Code)
    )]
    [JsonDerivedType(
        typeof(BillingBalanceType1Choice.Proprietary),
        nameof(BillingBalanceType1Choice.Proprietary)
    )]
    [IsoId("_6Q_lhJqlEeGSON8vddiWzQ_-1443313206")]
    [DisplayName("Billing Balance Type 1 Choice")]
    public abstract record BillingBalanceType1Choice_ { }
}
