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
    /// Rejected status reason.
    /// </summary>
    [KnownType(typeof(RejectedStatusReason1Choice.Reason))]
    [KnownType(typeof(RejectedStatusReason1Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(RejectedStatusReason1Choice.Reason),nameof(RejectedStatusReason1Choice.Reason))]
    [JsonDerivedType(typeof(RejectedStatusReason1Choice.Proprietary),nameof(RejectedStatusReason1Choice.Proprietary))]
    #endif
    [IsoId("_Rhov5tp-Ed-ak6NoX_4Aeg_-75492796")]
    [DisplayName("Rejected Status Reason 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record RejectedStatusReason1Choice_
    #else
    public abstract partial class RejectedStatusReason1Choice_
    #endif
    {
    }
}
