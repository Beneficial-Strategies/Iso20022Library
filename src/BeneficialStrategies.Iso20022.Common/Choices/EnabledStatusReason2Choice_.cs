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
    /// Choice of formats for an enabled reason code.
    /// </summary>
    [KnownType(typeof(EnabledStatusReason2Choice.Code))]
    [KnownType(typeof(EnabledStatusReason2Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(EnabledStatusReason2Choice.Code),nameof(EnabledStatusReason2Choice.Code))]
    [JsonDerivedType(typeof(EnabledStatusReason2Choice.Proprietary),nameof(EnabledStatusReason2Choice.Proprietary))]
    #endif
    [IsoId("_PtrCQEy-EeafiMTDrtSnyw")]
    [DisplayName("Enabled Status Reason 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record EnabledStatusReason2Choice_
    #else
    public abstract partial class EnabledStatusReason2Choice_
    #endif
    {
    }
}
