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
    /// Choice between different quantity of security formats.
    /// </summary>
    [KnownType(typeof(Quantity40Choice.Code))]
    [KnownType(typeof(Quantity40Choice.OriginalAndCurrentFaceAmount))]
    [KnownType(typeof(Quantity40Choice.Quantity))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(Quantity40Choice.Code),nameof(Quantity40Choice.Code))]
    [JsonDerivedType(typeof(Quantity40Choice.OriginalAndCurrentFaceAmount),nameof(Quantity40Choice.OriginalAndCurrentFaceAmount))]
    [JsonDerivedType(typeof(Quantity40Choice.Quantity),nameof(Quantity40Choice.Quantity))]
    #endif
    [IsoId("_NwxZGJp3EeWLs7cvLxlyAg")]
    [DisplayName("Quantity 40 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record Quantity40Choice_
    #else
    public abstract partial class Quantity40Choice_
    #endif
    {
    }
}
