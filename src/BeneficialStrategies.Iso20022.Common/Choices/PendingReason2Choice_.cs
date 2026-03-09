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
    /// Choice of format for the pending reason.
    /// </summary>
    [KnownType(typeof(PendingReason2Choice.Code))]
    [KnownType(typeof(PendingReason2Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PendingReason2Choice.Code),nameof(PendingReason2Choice.Code))]
    [JsonDerivedType(typeof(PendingReason2Choice.Proprietary),nameof(PendingReason2Choice.Proprietary))]
    #endif
    [IsoId("_UYeaJdp-Ed-ak6NoX_4Aeg_-2106070769")]
    [DisplayName("Pending Reason 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PendingReason2Choice_
    #else
    public abstract partial class PendingReason2Choice_
    #endif
    {
    }
}
