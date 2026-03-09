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
    /// Specifies the status reason of the investigation request.
    /// </summary>
    [KnownType(typeof(InvestigationRequestStatusReason1Choice.Code))]
    [KnownType(typeof(InvestigationRequestStatusReason1Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(InvestigationRequestStatusReason1Choice.Code),nameof(InvestigationRequestStatusReason1Choice.Code))]
    [JsonDerivedType(typeof(InvestigationRequestStatusReason1Choice.Proprietary),nameof(InvestigationRequestStatusReason1Choice.Proprietary))]
    #endif
    [IsoId("_xMmO4XbnEe2GR4CRzIB77g")]
    [DisplayName("Investigation Request Status Reason 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record InvestigationRequestStatusReason1Choice_
    #else
    public abstract partial class InvestigationRequestStatusReason1Choice_
    #endif
    {
    }
}
