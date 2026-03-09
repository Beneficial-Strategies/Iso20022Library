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
    /// Choice between a standard code or proprietary code to specify the certification format required.
    /// </summary>
    [KnownType(typeof(CertificationTypeFormat3Choice.Code))]
    [KnownType(typeof(CertificationTypeFormat3Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(CertificationTypeFormat3Choice.Code),nameof(CertificationTypeFormat3Choice.Code))]
    [JsonDerivedType(typeof(CertificationTypeFormat3Choice.Proprietary),nameof(CertificationTypeFormat3Choice.Proprietary))]
    #endif
    [IsoId("_bZ7v0UEGEeWVgfuHGaKtRQ")]
    [DisplayName("Certification Type Format 3 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CertificationTypeFormat3Choice_
    #else
    public abstract partial class CertificationTypeFormat3Choice_
    #endif
    {
    }
}
