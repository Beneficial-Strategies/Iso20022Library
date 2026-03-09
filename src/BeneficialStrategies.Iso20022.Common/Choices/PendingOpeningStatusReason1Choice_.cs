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
    /// Choice of formats for a pending account opening status reason.
    /// </summary>
    [KnownType(typeof(PendingOpeningStatusReason1Choice.NoSpecifiedReason))]
    [KnownType(typeof(PendingOpeningStatusReason1Choice.Reason))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PendingOpeningStatusReason1Choice.NoSpecifiedReason),nameof(PendingOpeningStatusReason1Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(PendingOpeningStatusReason1Choice.Reason),nameof(PendingOpeningStatusReason1Choice.Reason))]
    #endif
    [IsoId("_gh55AWCJEeabZtzjEVWYCQ")]
    [DisplayName("Pending Opening Status Reason 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PendingOpeningStatusReason1Choice_
    #else
    public abstract partial class PendingOpeningStatusReason1Choice_
    #endif
    {
    }
}
