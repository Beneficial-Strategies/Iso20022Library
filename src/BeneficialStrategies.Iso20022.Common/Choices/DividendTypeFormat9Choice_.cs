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
    /// Choice between a standard code or proprietary code to specify the type of dividend.
    /// </summary>
    [KnownType(typeof(DividendTypeFormat9Choice.Code))]
    [KnownType(typeof(DividendTypeFormat9Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(DividendTypeFormat9Choice.Code),nameof(DividendTypeFormat9Choice.Code))]
    [JsonDerivedType(typeof(DividendTypeFormat9Choice.Proprietary),nameof(DividendTypeFormat9Choice.Proprietary))]
    #endif
    [IsoId("_x36OMUEFEeWVgfuHGaKtRQ")]
    [DisplayName("Dividend Type Format 9 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record DividendTypeFormat9Choice_
    #else
    public abstract partial class DividendTypeFormat9Choice_
    #endif
    {
    }
}
