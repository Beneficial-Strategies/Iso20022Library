// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Defines the type of billing compensation.
    /// </summary>
    [KnownType(typeof(BillingCompensationType1Choice.Code))]
    [KnownType(typeof(BillingCompensationType1Choice.Proprietary))]
    [JsonDerivedType(
        typeof(BillingCompensationType1Choice.Code),
        nameof(BillingCompensationType1Choice.Code)
    )]
    [JsonDerivedType(
        typeof(BillingCompensationType1Choice.Proprietary),
        nameof(BillingCompensationType1Choice.Proprietary)
    )]
    [IsoId("_6Q_lgZqlEeGSON8vddiWzQ_2012916180")]
    [DisplayName("Billing Compensation Type 1 Choice")]
    public abstract record BillingCompensationType1Choice_ { }
}
