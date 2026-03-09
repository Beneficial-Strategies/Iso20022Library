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
    [KnownType(typeof(Quantity6Choice.Quantity))]
    [KnownType(typeof(Quantity6Choice.OriginalAndCurrentFace))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(Quantity6Choice.Quantity),nameof(Quantity6Choice.Quantity))]
    [JsonDerivedType(typeof(Quantity6Choice.OriginalAndCurrentFace),nameof(Quantity6Choice.OriginalAndCurrentFace))]
    #endif
    [IsoId("_Sotss9p-Ed-ak6NoX_4Aeg_502290625")]
    [DisplayName("Quantity 6 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record Quantity6Choice_
    #else
    public abstract partial class Quantity6Choice_
    #endif
    {
    }
}
