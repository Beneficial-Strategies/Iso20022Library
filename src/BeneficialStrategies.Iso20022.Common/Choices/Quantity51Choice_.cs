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
    [KnownType(typeof(Quantity51Choice.Quantity))]
    [KnownType(typeof(Quantity51Choice.OriginalAndCurrentFace))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(Quantity51Choice.Quantity),nameof(Quantity51Choice.Quantity))]
    [JsonDerivedType(typeof(Quantity51Choice.OriginalAndCurrentFace),nameof(Quantity51Choice.OriginalAndCurrentFace))]
    #endif
    [IsoId("_LU-10RuyEeyhRdHRjakS2w")]
    [DisplayName("Quantity 51 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record Quantity51Choice_
    #else
    public abstract partial class Quantity51Choice_
    #endif
    {
    }
}
