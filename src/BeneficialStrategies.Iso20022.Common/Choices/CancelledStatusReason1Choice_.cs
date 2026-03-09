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
    /// Cancelled status reason.
    /// </summary>
    [KnownType(typeof(CancelledStatusReason1Choice.Reason))]
    [KnownType(typeof(CancelledStatusReason1Choice.Proprietary))]
    [KnownType(typeof(CancelledStatusReason1Choice.NoSpecifiedReason))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(CancelledStatusReason1Choice.Reason),nameof(CancelledStatusReason1Choice.Reason))]
    [JsonDerivedType(typeof(CancelledStatusReason1Choice.Proprietary),nameof(CancelledStatusReason1Choice.Proprietary))]
    [JsonDerivedType(typeof(CancelledStatusReason1Choice.NoSpecifiedReason),nameof(CancelledStatusReason1Choice.NoSpecifiedReason))]
    #endif
    [IsoId("_RiFb09p-Ed-ak6NoX_4Aeg_-275254352")]
    [DisplayName("Cancelled Status Reason 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CancelledStatusReason1Choice_
    #else
    public abstract partial class CancelledStatusReason1Choice_
    #endif
    {
    }
}
