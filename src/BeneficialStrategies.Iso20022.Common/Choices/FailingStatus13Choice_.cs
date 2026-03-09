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
    /// Choice of failing status.
    /// </summary>
    [KnownType(typeof(FailingStatus13Choice.NoSpecifiedReason))]
    [KnownType(typeof(FailingStatus13Choice.Reason))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(FailingStatus13Choice.NoSpecifiedReason),nameof(FailingStatus13Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(FailingStatus13Choice.Reason),nameof(FailingStatus13Choice.Reason))]
    #endif
    [IsoId("_9wP7USW-EeygjNFjAlVoPA")]
    [DisplayName("Failing Status 13 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record FailingStatus13Choice_
    #else
    public abstract partial class FailingStatus13Choice_
    #endif
    {
    }
}
