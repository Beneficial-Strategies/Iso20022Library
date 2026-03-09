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
    /// Specifies the type of margin, for example, initial margin, variation margin, initial deposit or coupon margin.
    /// </summary>
    [KnownType(typeof(MarginType2Choice.Code))]
    [KnownType(typeof(MarginType2Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(MarginType2Choice.Code),nameof(MarginType2Choice.Code))]
    [JsonDerivedType(typeof(MarginType2Choice.Proprietary),nameof(MarginType2Choice.Proprietary))]
    #endif
    [IsoId("_JT728I1rEeet3cKIYK84nw")]
    [DisplayName("Margin Type 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record MarginType2Choice_
    #else
    public abstract partial class MarginType2Choice_
    #endif
    {
    }
}
