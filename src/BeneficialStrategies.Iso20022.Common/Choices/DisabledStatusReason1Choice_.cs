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
    /// Choice of formats for a disabled status reason.
    /// </summary>
    [KnownType(typeof(DisabledStatusReason1Choice.NoSpecifiedReason))]
    [KnownType(typeof(DisabledStatusReason1Choice.Reason))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(DisabledStatusReason1Choice.NoSpecifiedReason),nameof(DisabledStatusReason1Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(DisabledStatusReason1Choice.Reason),nameof(DisabledStatusReason1Choice.Reason))]
    #endif
    [IsoId("_RfDOYUzAEeafiMTDrtSnyw")]
    [DisplayName("Disabled Status Reason 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record DisabledStatusReason1Choice_
    #else
    public abstract partial class DisabledStatusReason1Choice_
    #endif
    {
    }
}
