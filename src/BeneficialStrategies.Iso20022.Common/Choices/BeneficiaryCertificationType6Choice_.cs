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
    /// Choice between a standard code or proprietary code to specify the type of beneficiary certification required.
    /// </summary>
    [KnownType(typeof(BeneficiaryCertificationType6Choice.Code))]
    [KnownType(typeof(BeneficiaryCertificationType6Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(BeneficiaryCertificationType6Choice.Code),nameof(BeneficiaryCertificationType6Choice.Code))]
    [JsonDerivedType(typeof(BeneficiaryCertificationType6Choice.Proprietary),nameof(BeneficiaryCertificationType6Choice.Proprietary))]
    #endif
    [IsoId("_UozIoQE4EeG0G9kfgQ0HLA")]
    [DisplayName("Beneficiary Certification Type 6 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record BeneficiaryCertificationType6Choice_
    #else
    public abstract partial class BeneficiaryCertificationType6Choice_
    #endif
    {
    }
}
