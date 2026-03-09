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
    /// Choice of formats for an enabled status reason.
    /// </summary>
    [KnownType(typeof(EnabledStatusReason1Choice.NoSpecifiedReason))]
    [KnownType(typeof(EnabledStatusReason1Choice.Reason))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(EnabledStatusReason1Choice.NoSpecifiedReason),nameof(EnabledStatusReason1Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(EnabledStatusReason1Choice.Reason),nameof(EnabledStatusReason1Choice.Reason))]
    #endif
    [IsoId("_z9anYEy9EeafiMTDrtSnyw")]
    [DisplayName("Enabled Status Reason 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record EnabledStatusReason1Choice_
    #else
    public abstract partial class EnabledStatusReason1Choice_
    #endif
    {
    }
}
