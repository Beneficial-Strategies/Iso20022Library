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
    /// Choice between a standard code or proprietary code to specify the reason why the instruction or cancellation request has a rejected status.
    /// </summary>
    [KnownType(typeof(RejectedReason1Choice.Code))]
    [KnownType(typeof(RejectedReason1Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(RejectedReason1Choice.Code),nameof(RejectedReason1Choice.Code))]
    [JsonDerivedType(typeof(RejectedReason1Choice.Proprietary),nameof(RejectedReason1Choice.Proprietary))]
    #endif
    [IsoId("_QyZrVtp-Ed-ak6NoX_4Aeg_31870116")]
    [DisplayName("Rejected Reason 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record RejectedReason1Choice_
    #else
    public abstract partial class RejectedReason1Choice_
    #endif
    {
    }
}
