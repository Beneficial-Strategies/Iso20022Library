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
    /// Specifies a channel type.
    /// </summary>
    [KnownType(typeof(Channel2Choice.Code))]
    [KnownType(typeof(Channel2Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(Channel2Choice.Code),nameof(Channel2Choice.Code))]
    [JsonDerivedType(typeof(Channel2Choice.Proprietary),nameof(Channel2Choice.Proprietary))]
    #endif
    [IsoId("_1zp30Bg2EeKnW4lR85q-0A")]
    [DisplayName("Channel 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record Channel2Choice_
    #else
    public abstract partial class Channel2Choice_
    #endif
    {
    }
}
