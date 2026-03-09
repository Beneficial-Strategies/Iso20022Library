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
    /// Specifies the format of the quantity of delivery.
    /// </summary>
    [KnownType(typeof(Quantity46Choice.Quantity))]
    [KnownType(typeof(Quantity46Choice.Description))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(Quantity46Choice.Quantity),nameof(Quantity46Choice.Quantity))]
    [JsonDerivedType(typeof(Quantity46Choice.Description),nameof(Quantity46Choice.Description))]
    #endif
    [IsoId("_2vwJoZCuEeic-NeLxeO3hQ")]
    [DisplayName("Quantity 46 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record Quantity46Choice_
    #else
    public abstract partial class Quantity46Choice_
    #endif
    {
    }
}
