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
    /// Choice between a date or a code.
    /// </summary>
    [KnownType(typeof(ClosingDate4Choice.Date))]
    [KnownType(typeof(ClosingDate4Choice.Code))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(ClosingDate4Choice.Date),nameof(ClosingDate4Choice.Date))]
    [JsonDerivedType(typeof(ClosingDate4Choice.Code),nameof(ClosingDate4Choice.Code))]
    #endif
    [IsoId("_xCN8YcpdEemQ1o-hyeYV5w")]
    [DisplayName("Closing Date 4 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ClosingDate4Choice_
    #else
    public abstract partial class ClosingDate4Choice_
    #endif
    {
    }
}
