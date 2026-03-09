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
    /// Choice of formats for a reporting type.
    /// </summary>
    [KnownType(typeof(Reporting11Choice.Code))]
    [KnownType(typeof(Reporting11Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(Reporting11Choice.Code),nameof(Reporting11Choice.Code))]
    [JsonDerivedType(typeof(Reporting11Choice.Proprietary),nameof(Reporting11Choice.Proprietary))]
    #endif
    [IsoId("_6sleB_fVEeiNZp_PtLohLw")]
    [DisplayName("Reporting 11 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record Reporting11Choice_
    #else
    public abstract partial class Reporting11Choice_
    #endif
    {
    }
}
