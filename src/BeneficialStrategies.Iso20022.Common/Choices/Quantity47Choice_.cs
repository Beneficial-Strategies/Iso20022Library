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
    [KnownType(typeof(Quantity47Choice.Quantity))]
    [KnownType(typeof(Quantity47Choice.Description))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(Quantity47Choice.Quantity),nameof(Quantity47Choice.Quantity))]
    [JsonDerivedType(typeof(Quantity47Choice.Description),nameof(Quantity47Choice.Description))]
    #endif
    [IsoId("_b_ddkZjgEeqkLZLH6DK3UQ")]
    [DisplayName("Quantity 47 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record Quantity47Choice_
    #else
    public abstract partial class Quantity47Choice_
    #endif
    {
    }
}
