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
    [KnownType(typeof(Quantity19Choice.Quantity))]
    [KnownType(typeof(Quantity19Choice.ProprietaryQuantity))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(Quantity19Choice.Quantity),nameof(Quantity19Choice.Quantity))]
    [JsonDerivedType(typeof(Quantity19Choice.ProprietaryQuantity),nameof(Quantity19Choice.ProprietaryQuantity))]
    #endif
    [IsoId("_XFWZsTq6EeWQ1Y7f8kds2A")]
    [DisplayName("Quantity 19 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record Quantity19Choice_
    #else
    public abstract partial class Quantity19Choice_
    #endif
    {
    }
}
