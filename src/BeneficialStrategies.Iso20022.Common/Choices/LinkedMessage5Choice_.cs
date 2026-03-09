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
    [KnownType(typeof(LinkedMessage5Choice.PreviousReference))]
    [KnownType(typeof(LinkedMessage5Choice.OtherReference))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(LinkedMessage5Choice.PreviousReference),nameof(LinkedMessage5Choice.PreviousReference))]
    [JsonDerivedType(typeof(LinkedMessage5Choice.OtherReference),nameof(LinkedMessage5Choice.OtherReference))]
    #endif
    [IsoId("_rFVAAZTPEemqYPWMBuVawg")]
    [DisplayName("Linked Message 5 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record LinkedMessage5Choice_
    #else
    public abstract partial class LinkedMessage5Choice_
    #endif
    {
    }
}
