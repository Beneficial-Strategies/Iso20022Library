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
    [KnownType(typeof(Quantity23Choice.OriginalAndCurrentFaceAmount))]
    [KnownType(typeof(Quantity23Choice.SignedQuantity))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(Quantity23Choice.OriginalAndCurrentFaceAmount),nameof(Quantity23Choice.OriginalAndCurrentFaceAmount))]
    [JsonDerivedType(typeof(Quantity23Choice.SignedQuantity),nameof(Quantity23Choice.SignedQuantity))]
    #endif
    [IsoId("_cfsEXZKQEeWHWpTQn1FFVg")]
    [DisplayName("Quantity 23 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record Quantity23Choice_
    #else
    public abstract partial class Quantity23Choice_
    #endif
    {
    }
}
