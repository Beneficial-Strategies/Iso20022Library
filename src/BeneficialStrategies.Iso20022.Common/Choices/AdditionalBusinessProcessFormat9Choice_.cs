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
    /// Choice between a standard code or proprietary code to specify the type of the additional business process.
    /// </summary>
    [KnownType(typeof(AdditionalBusinessProcessFormat9Choice.Code))]
    [KnownType(typeof(AdditionalBusinessProcessFormat9Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(AdditionalBusinessProcessFormat9Choice.Code),nameof(AdditionalBusinessProcessFormat9Choice.Code))]
    [JsonDerivedType(typeof(AdditionalBusinessProcessFormat9Choice.Proprietary),nameof(AdditionalBusinessProcessFormat9Choice.Proprietary))]
    #endif
    [IsoId("_EXH7gUEGEeWVgfuHGaKtRQ")]
    [DisplayName("Additional Business Process Format 9 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record AdditionalBusinessProcessFormat9Choice_
    #else
    public abstract partial class AdditionalBusinessProcessFormat9Choice_
    #endif
    {
    }
}
