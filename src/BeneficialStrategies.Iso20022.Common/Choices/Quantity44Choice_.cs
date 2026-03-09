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
    /// Choice of quantity of assets.
    /// </summary>
    [KnownType(typeof(Quantity44Choice.Unit))]
    [KnownType(typeof(Quantity44Choice.PercentageRate))]
    [KnownType(typeof(Quantity44Choice.FaceAmount))]
    [KnownType(typeof(Quantity44Choice.AmortisedValue))]
    [KnownType(typeof(Quantity44Choice.CashAmount))]
    [KnownType(typeof(Quantity44Choice.OtherAsset))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(Quantity44Choice.Unit),nameof(Quantity44Choice.Unit))]
    [JsonDerivedType(typeof(Quantity44Choice.PercentageRate),nameof(Quantity44Choice.PercentageRate))]
    [JsonDerivedType(typeof(Quantity44Choice.FaceAmount),nameof(Quantity44Choice.FaceAmount))]
    [JsonDerivedType(typeof(Quantity44Choice.AmortisedValue),nameof(Quantity44Choice.AmortisedValue))]
    [JsonDerivedType(typeof(Quantity44Choice.CashAmount),nameof(Quantity44Choice.CashAmount))]
    [JsonDerivedType(typeof(Quantity44Choice.OtherAsset),nameof(Quantity44Choice.OtherAsset))]
    #endif
    [IsoId("_Qfjh0U3WEeidB49bWZiS0g")]
    [DisplayName("Quantity 44 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record Quantity44Choice_
    #else
    public abstract partial class Quantity44Choice_
    #endif
    {
    }
}
