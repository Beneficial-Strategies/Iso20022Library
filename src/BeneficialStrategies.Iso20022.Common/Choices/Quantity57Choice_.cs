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
    [KnownType(typeof(Quantity57Choice.OriginalAndCurrentFaceAmount))]
    [KnownType(typeof(Quantity57Choice.SignedQuantity))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(Quantity57Choice.OriginalAndCurrentFaceAmount),nameof(Quantity57Choice.OriginalAndCurrentFaceAmount))]
    [JsonDerivedType(typeof(Quantity57Choice.SignedQuantity),nameof(Quantity57Choice.SignedQuantity))]
    #endif
    [IsoId("_pf0YwTi7Eeydid5dcNPKvg")]
    [DisplayName("Quantity 57 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record Quantity57Choice_
    #else
    public abstract partial class Quantity57Choice_
    #endif
    {
    }
}
