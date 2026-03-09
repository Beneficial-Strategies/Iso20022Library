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
    /// Reference to a message.
    /// </summary>
    [KnownType(typeof(LinkedMessage3Choice.PreviousReference))]
    [KnownType(typeof(LinkedMessage3Choice.OtherReference))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(LinkedMessage3Choice.PreviousReference),nameof(LinkedMessage3Choice.PreviousReference))]
    [JsonDerivedType(typeof(LinkedMessage3Choice.OtherReference),nameof(LinkedMessage3Choice.OtherReference))]
    #endif
    [IsoId("_dqR1QCFeEeW9XJWqfgXIIA")]
    [DisplayName("Linked Message 3 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record LinkedMessage3Choice_
    #else
    public abstract partial class LinkedMessage3Choice_
    #endif
    {
    }
}
