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
    /// Qualitative expression of a time frame.
    /// </summary>
    [KnownType(typeof(TimeFrame6Choice.Code))]
    [KnownType(typeof(TimeFrame6Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(TimeFrame6Choice.Code),nameof(TimeFrame6Choice.Code))]
    [JsonDerivedType(typeof(TimeFrame6Choice.Proprietary),nameof(TimeFrame6Choice.Proprietary))]
    #endif
    [IsoId("_yjGN0DcbEeidBoT_PugKiA")]
    [DisplayName("Time Frame 6 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record TimeFrame6Choice_
    #else
    public abstract partial class TimeFrame6Choice_
    #endif
    {
    }
}
