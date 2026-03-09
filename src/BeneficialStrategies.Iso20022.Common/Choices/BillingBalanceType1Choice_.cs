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
    /// Defines the type of the billing balance.
    /// </summary>
    [KnownType(typeof(BillingBalanceType1Choice.Code))]
    [KnownType(typeof(BillingBalanceType1Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(BillingBalanceType1Choice.Code),nameof(BillingBalanceType1Choice.Code))]
    [JsonDerivedType(typeof(BillingBalanceType1Choice.Proprietary),nameof(BillingBalanceType1Choice.Proprietary))]
    #endif
    [IsoId("_6Q_lhJqlEeGSON8vddiWzQ_-1443313206")]
    [DisplayName("Billing Balance Type 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record BillingBalanceType1Choice_
    #else
    public abstract partial class BillingBalanceType1Choice_
    #endif
    {
    }
}
