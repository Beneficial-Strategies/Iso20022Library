// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between tax calculation methods A, B or D.
    /// </summary>
    [KnownType(typeof(BillingMethod1Choice.MethodA))]
    [KnownType(typeof(BillingMethod1Choice.MethodB))]
    [KnownType(typeof(BillingMethod1Choice.MethodD))]
    [JsonDerivedType(typeof(BillingMethod1Choice.MethodA),nameof(BillingMethod1Choice.MethodA))]
    [JsonDerivedType(typeof(BillingMethod1Choice.MethodB),nameof(BillingMethod1Choice.MethodB))]
    [JsonDerivedType(typeof(BillingMethod1Choice.MethodD),nameof(BillingMethod1Choice.MethodD))]
    [IsoId("_6P9DsZqlEeGSON8vddiWzQ_-904396180")]
    [DisplayName("Billing Method 1 Choice")]
    public abstract partial record BillingMethod1Choice_
    {
    }
}
