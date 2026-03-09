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
    /// Choice of format for the quantity.
    /// </summary>
    [KnownType(typeof(Quantity54Choice.Quantity))]
    [KnownType(typeof(Quantity54Choice.OriginalAndCurrentFace))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(Quantity54Choice.Quantity),nameof(Quantity54Choice.Quantity))]
    [JsonDerivedType(typeof(Quantity54Choice.OriginalAndCurrentFace),nameof(Quantity54Choice.OriginalAndCurrentFace))]
    #endif
    [IsoId("_peZb9zi7Eeydid5dcNPKvg")]
    [DisplayName("Quantity 54 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record Quantity54Choice_
    #else
    public abstract partial class Quantity54Choice_
    #endif
    {
    }
}
