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
    /// Reason for the cancellation request of the transaction.
    /// </summary>
    [KnownType(typeof(CancellationReason1Choice.Code))]
    [KnownType(typeof(CancellationReason1Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(CancellationReason1Choice.Code),nameof(CancellationReason1Choice.Code))]
    [JsonDerivedType(typeof(CancellationReason1Choice.Proprietary),nameof(CancellationReason1Choice.Proprietary))]
    #endif
    [IsoId("_TO3Gs9p-Ed-ak6NoX_4Aeg_-748049495")]
    [DisplayName("Cancellation Reason 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CancellationReason1Choice_
    #else
    public abstract partial class CancellationReason1Choice_
    #endif
    {
    }
}
