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
    [KnownType(typeof(Quantity5Choice.Code))]
    [KnownType(typeof(Quantity5Choice.OriginalAndCurrentFaceAmount))]
    [KnownType(typeof(Quantity5Choice.Quantity))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(Quantity5Choice.Code),nameof(Quantity5Choice.Code))]
    [JsonDerivedType(typeof(Quantity5Choice.OriginalAndCurrentFaceAmount),nameof(Quantity5Choice.OriginalAndCurrentFaceAmount))]
    [JsonDerivedType(typeof(Quantity5Choice.Quantity),nameof(Quantity5Choice.Quantity))]
    #endif
    [IsoId("_Sn0U1dp-Ed-ak6NoX_4Aeg_89127208")]
    [DisplayName("Quantity 5 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record Quantity5Choice_
    #else
    public abstract partial class Quantity5Choice_
    #endif
    {
    }
}
