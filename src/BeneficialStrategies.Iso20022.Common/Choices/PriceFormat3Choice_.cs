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
    /// Choice of formats to express a price.
    /// </summary>
    [KnownType(typeof(PriceFormat3Choice.Amount))]
    [KnownType(typeof(PriceFormat3Choice.Rate))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PriceFormat3Choice.Amount),nameof(PriceFormat3Choice.Amount))]
    [JsonDerivedType(typeof(PriceFormat3Choice.Rate),nameof(PriceFormat3Choice.Rate))]
    #endif
    [IsoId("_Qa2uAtp-Ed-ak6NoX_4Aeg_-1480216475")]
    [DisplayName("Price Format 3 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PriceFormat3Choice_
    #else
    public abstract partial class PriceFormat3Choice_
    #endif
    {
    }
}
