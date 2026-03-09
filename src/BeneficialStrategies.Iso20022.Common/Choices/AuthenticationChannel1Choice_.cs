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
    /// Choice of format for an authentication channel.
    /// </summary>
    [KnownType(typeof(AuthenticationChannel1Choice.Code))]
    [KnownType(typeof(AuthenticationChannel1Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(AuthenticationChannel1Choice.Code),nameof(AuthenticationChannel1Choice.Code))]
    [JsonDerivedType(typeof(AuthenticationChannel1Choice.Proprietary),nameof(AuthenticationChannel1Choice.Proprietary))]
    #endif
    [IsoId("_U4Y945dgEea1K6JAcAwoVg")]
    [DisplayName("Authentication Channel 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record AuthenticationChannel1Choice_
    #else
    public abstract partial class AuthenticationChannel1Choice_
    #endif
    {
    }
}
