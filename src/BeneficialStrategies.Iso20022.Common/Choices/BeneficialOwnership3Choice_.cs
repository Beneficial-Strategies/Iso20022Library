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
    [KnownType(typeof(BeneficialOwnership3Choice.Indicator))]
    [KnownType(typeof(BeneficialOwnership3Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(BeneficialOwnership3Choice.Indicator),nameof(BeneficialOwnership3Choice.Indicator))]
    [JsonDerivedType(typeof(BeneficialOwnership3Choice.Proprietary),nameof(BeneficialOwnership3Choice.Proprietary))]
    #endif
    [IsoId("_AbDZwdokEeC60axPepSq7g_1929914426")]
    [DisplayName("Beneficial Ownership 3 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record BeneficialOwnership3Choice_
    #else
    public abstract partial class BeneficialOwnership3Choice_
    #endif
    {
    }
}
