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
    /// Choice between different formats of securities quantity.
    /// </summary>
    [KnownType(typeof(Quantity20Choice.Code))]
    [KnownType(typeof(Quantity20Choice.OriginalAndCurrentFaceAmount))]
    [KnownType(typeof(Quantity20Choice.Quantity))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(Quantity20Choice.Code),nameof(Quantity20Choice.Code))]
    [JsonDerivedType(typeof(Quantity20Choice.OriginalAndCurrentFaceAmount),nameof(Quantity20Choice.OriginalAndCurrentFaceAmount))]
    [JsonDerivedType(typeof(Quantity20Choice.Quantity),nameof(Quantity20Choice.Quantity))]
    #endif
    [IsoId("_BKblj0GUEeWqy4niLuXETA")]
    [DisplayName("Quantity 20 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record Quantity20Choice_
    #else
    public abstract partial class Quantity20Choice_
    #endif
    {
    }
}
