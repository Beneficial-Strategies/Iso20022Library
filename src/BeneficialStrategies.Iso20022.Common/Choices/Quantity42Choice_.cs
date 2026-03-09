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
    /// Total quantity of securities to be transferred, expressed in a number of units or a percentage rate.
    /// </summary>
    [KnownType(typeof(Quantity42Choice.TotalUnitsNumber))]
    [KnownType(typeof(Quantity42Choice.TransferRate))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(Quantity42Choice.TotalUnitsNumber),nameof(Quantity42Choice.TotalUnitsNumber))]
    [JsonDerivedType(typeof(Quantity42Choice.TransferRate),nameof(Quantity42Choice.TransferRate))]
    #endif
    [IsoId("_SOqu0IfwEeevKP8c-ilVhA")]
    [DisplayName("Quantity 42 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record Quantity42Choice_
    #else
    public abstract partial class Quantity42Choice_
    #endif
    {
    }
}
