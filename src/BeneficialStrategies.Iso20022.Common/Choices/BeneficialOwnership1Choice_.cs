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
    /// Choice of format for the beneficial ownership.
    /// </summary>
    [KnownType(typeof(BeneficialOwnership1Choice.Indicator))]
    [KnownType(typeof(BeneficialOwnership1Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(BeneficialOwnership1Choice.Indicator),nameof(BeneficialOwnership1Choice.Indicator))]
    [JsonDerivedType(typeof(BeneficialOwnership1Choice.Proprietary),nameof(BeneficialOwnership1Choice.Proprietary))]
    #endif
    [IsoId("_QwBFsdp-Ed-ak6NoX_4Aeg_92509892")]
    [DisplayName("Beneficial Ownership 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record BeneficialOwnership1Choice_
    #else
    public abstract partial class BeneficialOwnership1Choice_
    #endif
    {
    }
}
