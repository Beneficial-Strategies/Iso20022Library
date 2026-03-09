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
    /// Choice of formats for the reason of a received status.
    /// </summary>
    [KnownType(typeof(ReceivedReason2Choice.Code))]
    [KnownType(typeof(ReceivedReason2Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(ReceivedReason2Choice.Code),nameof(ReceivedReason2Choice.Code))]
    [JsonDerivedType(typeof(ReceivedReason2Choice.Proprietary),nameof(ReceivedReason2Choice.Proprietary))]
    #endif
    [IsoId("_2y5Nxlj6EeOgwYxfAV02bg")]
    [DisplayName("Received Reason 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ReceivedReason2Choice_
    #else
    public abstract partial class ReceivedReason2Choice_
    #endif
    {
    }
}
