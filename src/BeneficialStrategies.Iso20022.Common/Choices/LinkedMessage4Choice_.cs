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
    [KnownType(typeof(LinkedMessage4Choice.PreviousReference))]
    [KnownType(typeof(LinkedMessage4Choice.OtherReference))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(LinkedMessage4Choice.PreviousReference),nameof(LinkedMessage4Choice.PreviousReference))]
    [JsonDerivedType(typeof(LinkedMessage4Choice.OtherReference),nameof(LinkedMessage4Choice.OtherReference))]
    #endif
    [IsoId("_4qagUaDjEeahP9OZs6K4wg")]
    [DisplayName("Linked Message 4 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record LinkedMessage4Choice_
    #else
    public abstract partial class LinkedMessage4Choice_
    #endif
    {
    }
}
