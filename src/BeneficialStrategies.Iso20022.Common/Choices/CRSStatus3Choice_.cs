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
    /// Choice of formats for the Common Reporting Standard (CRS) status.
    /// </summary>
    [KnownType(typeof(CRSStatus3Choice.Code))]
    [KnownType(typeof(CRSStatus3Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(CRSStatus3Choice.Code),nameof(CRSStatus3Choice.Code))]
    [JsonDerivedType(typeof(CRSStatus3Choice.Proprietary),nameof(CRSStatus3Choice.Proprietary))]
    #endif
    [IsoId("_--TuEUNeEeamLdeYEZm56w")]
    [DisplayName("CRS Status 3 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CRSStatus3Choice_
    #else
    public abstract partial class CRSStatus3Choice_
    #endif
    {
    }
}
