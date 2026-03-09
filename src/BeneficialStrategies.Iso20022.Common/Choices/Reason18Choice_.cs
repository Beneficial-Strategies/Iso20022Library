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
    /// Specifies whether the status is provided with a reason or not.
    /// </summary>
    [KnownType(typeof(Reason18Choice.Reason))]
    [KnownType(typeof(Reason18Choice.NoSpecifiedReason))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(Reason18Choice.Reason),nameof(Reason18Choice.Reason))]
    [JsonDerivedType(typeof(Reason18Choice.NoSpecifiedReason),nameof(Reason18Choice.NoSpecifiedReason))]
    #endif
    [IsoId("_zII1AeLtEeWOD7aAy2fAcA")]
    [DisplayName("Reason 18 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record Reason18Choice_
    #else
    public abstract partial class Reason18Choice_
    #endif
    {
    }
}
