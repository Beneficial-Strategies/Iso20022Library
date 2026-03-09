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
    /// Choice of formats for an accepted status reason code.
    /// </summary>
    [KnownType(typeof(AcceptedStatusReason1Choice.Code))]
    [KnownType(typeof(AcceptedStatusReason1Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(AcceptedStatusReason1Choice.Code),nameof(AcceptedStatusReason1Choice.Code))]
    [JsonDerivedType(typeof(AcceptedStatusReason1Choice.Proprietary),nameof(AcceptedStatusReason1Choice.Proprietary))]
    #endif
    [IsoId("_wEWdkWBlEeaR1OOiVxm3Gg")]
    [DisplayName("Accepted Status Reason 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record AcceptedStatusReason1Choice_
    #else
    public abstract partial class AcceptedStatusReason1Choice_
    #endif
    {
    }
}
