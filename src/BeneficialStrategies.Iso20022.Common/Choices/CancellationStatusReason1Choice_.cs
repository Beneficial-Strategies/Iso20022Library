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
    /// Speficies the reason for the transaction cancellation status.
    /// </summary>
    [KnownType(typeof(CancellationStatusReason1Choice.Code))]
    [KnownType(typeof(CancellationStatusReason1Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(CancellationStatusReason1Choice.Code),nameof(CancellationStatusReason1Choice.Code))]
    [JsonDerivedType(typeof(CancellationStatusReason1Choice.Proprietary),nameof(CancellationStatusReason1Choice.Proprietary))]
    #endif
    [IsoId("_TPwel9p-Ed-ak6NoX_4Aeg_1784056923")]
    [DisplayName("Cancellation Status Reason 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CancellationStatusReason1Choice_
    #else
    public abstract partial class CancellationStatusReason1Choice_
    #endif
    {
    }
}
