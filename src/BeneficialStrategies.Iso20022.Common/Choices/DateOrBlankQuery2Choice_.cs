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
    /// Choice between a date period or blank elements.
    /// </summary>
    [KnownType(typeof(DateOrBlankQuery2Choice.Range))]
    [KnownType(typeof(DateOrBlankQuery2Choice.NotReported))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(DateOrBlankQuery2Choice.Range),nameof(DateOrBlankQuery2Choice.Range))]
    [JsonDerivedType(typeof(DateOrBlankQuery2Choice.NotReported),nameof(DateOrBlankQuery2Choice.NotReported))]
    #endif
    [IsoId("_cc1HsdGgEeaQk737TH1Fzw")]
    [DisplayName("Date Or Blank Query 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record DateOrBlankQuery2Choice_
    #else
    public abstract partial class DateOrBlankQuery2Choice_
    #endif
    {
    }
}
