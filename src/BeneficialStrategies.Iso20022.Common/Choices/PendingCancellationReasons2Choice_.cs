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
    /// Choice of format for the pending cancellation reason.
    /// </summary>
    [KnownType(typeof(PendingCancellationReasons2Choice.Code))]
    [KnownType(typeof(PendingCancellationReasons2Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PendingCancellationReasons2Choice.Code),nameof(PendingCancellationReasons2Choice.Code))]
    [JsonDerivedType(typeof(PendingCancellationReasons2Choice.Proprietary),nameof(PendingCancellationReasons2Choice.Proprietary))]
    #endif
    [IsoId("_UYBuNtp-Ed-ak6NoX_4Aeg_-1094614549")]
    [DisplayName("Pending Cancellation Reasons 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PendingCancellationReasons2Choice_
    #else
    public abstract partial class PendingCancellationReasons2Choice_
    #endif
    {
    }
}
