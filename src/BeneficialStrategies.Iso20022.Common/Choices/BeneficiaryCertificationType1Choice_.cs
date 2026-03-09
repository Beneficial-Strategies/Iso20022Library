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
    [KnownType(typeof(BeneficiaryCertificationType1Choice.Code))]
    [KnownType(typeof(BeneficiaryCertificationType1Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(BeneficiaryCertificationType1Choice.Code),nameof(BeneficiaryCertificationType1Choice.Code))]
    [JsonDerivedType(typeof(BeneficiaryCertificationType1Choice.Proprietary),nameof(BeneficiaryCertificationType1Choice.Proprietary))]
    #endif
    [IsoId("_Q0CqFdp-Ed-ak6NoX_4Aeg_-101661289")]
    [DisplayName("Beneficiary Certification Type 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record BeneficiaryCertificationType1Choice_
    #else
    public abstract partial class BeneficiaryCertificationType1Choice_
    #endif
    {
    }
}
