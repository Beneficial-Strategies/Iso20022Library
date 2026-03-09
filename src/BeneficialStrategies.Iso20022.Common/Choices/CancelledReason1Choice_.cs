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
    /// Choice between a standard code or proprietary code to specify the reason why the instruction or cancellation request is cancelled.
    /// </summary>
    [KnownType(typeof(CancelledReason1Choice.Code))]
    [KnownType(typeof(CancelledReason1Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(CancelledReason1Choice.Code),nameof(CancelledReason1Choice.Code))]
    [JsonDerivedType(typeof(CancelledReason1Choice.Proprietary),nameof(CancelledReason1Choice.Proprietary))]
    #endif
    [IsoId("_QysmSNp-Ed-ak6NoX_4Aeg_503789636")]
    [DisplayName("Cancelled Reason 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CancelledReason1Choice_
    #else
    public abstract partial class CancelledReason1Choice_
    #endif
    {
    }
}
