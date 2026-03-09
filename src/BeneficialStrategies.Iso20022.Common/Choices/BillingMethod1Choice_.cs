// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between tax calculation methods A, B or D.
    /// </summary>
    [KnownType(typeof(BillingMethod1Choice.MethodA))]
    [KnownType(typeof(BillingMethod1Choice.MethodB))]
    [KnownType(typeof(BillingMethod1Choice.MethodD))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(BillingMethod1Choice.MethodA),nameof(BillingMethod1Choice.MethodA))]
    [JsonDerivedType(typeof(BillingMethod1Choice.MethodB),nameof(BillingMethod1Choice.MethodB))]
    [JsonDerivedType(typeof(BillingMethod1Choice.MethodD),nameof(BillingMethod1Choice.MethodD))]
    #endif
    [IsoId("_6P9DsZqlEeGSON8vddiWzQ_-904396180")]
    [DisplayName("Billing Method 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record BillingMethod1Choice_
    #else
    public abstract partial class BillingMethod1Choice_
    #endif
    {
    }
}
