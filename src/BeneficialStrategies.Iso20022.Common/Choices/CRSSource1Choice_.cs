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
    /// Choice of formats for the source of the Common Reporting Standard (CRS).
    /// </summary>
    [KnownType(typeof(CRSSource1Choice.Code))]
    [KnownType(typeof(CRSSource1Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(CRSSource1Choice.Code),nameof(CRSSource1Choice.Code))]
    [JsonDerivedType(typeof(CRSSource1Choice.Proprietary),nameof(CRSSource1Choice.Proprietary))]
    #endif
    [IsoId("_JdcmcUNfEeamLdeYEZm56w")]
    [DisplayName("CRS Source 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CRSSource1Choice_
    #else
    public abstract partial class CRSSource1Choice_
    #endif
    {
    }
}
