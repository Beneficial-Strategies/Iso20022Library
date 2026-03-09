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
    /// Choice between a standard code and a proprietary code to specify the reason why the instruction/event has a pending status.
    /// </summary>
    [KnownType(typeof(PendingReason6Choice.Code))]
    [KnownType(typeof(PendingReason6Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PendingReason6Choice.Code),nameof(PendingReason6Choice.Code))]
    [JsonDerivedType(typeof(PendingReason6Choice.Proprietary),nameof(PendingReason6Choice.Proprietary))]
    #endif
    [IsoId("_QyGwaNp-Ed-ak6NoX_4Aeg_1186273655")]
    [DisplayName("Pending Reason 6 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PendingReason6Choice_
    #else
    public abstract partial class PendingReason6Choice_
    #endif
    {
    }
}
