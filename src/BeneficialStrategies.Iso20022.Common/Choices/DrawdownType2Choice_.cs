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
    /// Choice of formats for a type of drawdown.
    /// </summary>
    [KnownType(typeof(DrawdownType2Choice.Code))]
    [KnownType(typeof(DrawdownType2Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(DrawdownType2Choice.Code),nameof(DrawdownType2Choice.Code))]
    [JsonDerivedType(typeof(DrawdownType2Choice.Proprietary),nameof(DrawdownType2Choice.Proprietary))]
    #endif
    [IsoId("_mnrMcZNwEembCsVG-3f_AA")]
    [DisplayName("Drawdown Type 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record DrawdownType2Choice_
    #else
    public abstract partial class DrawdownType2Choice_
    #endif
    {
    }
}
