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
    /// Choice of formats for the specification of the reason.
    /// </summary>
    [KnownType(typeof(BlockedReason2Choice.Code))]
    [KnownType(typeof(BlockedReason2Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(BlockedReason2Choice.Code),nameof(BlockedReason2Choice.Code))]
    [JsonDerivedType(typeof(BlockedReason2Choice.Proprietary),nameof(BlockedReason2Choice.Proprietary))]
    #endif
    [IsoId("_Pc7lEVr3Eea4y99eritluQ")]
    [DisplayName("Blocked Reason 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record BlockedReason2Choice_
    #else
    public abstract partial class BlockedReason2Choice_
    #endif
    {
    }
}
