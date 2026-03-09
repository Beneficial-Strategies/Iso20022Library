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
    [KnownType(typeof(BeneficialOwnership5Choice.Indicator))]
    [KnownType(typeof(BeneficialOwnership5Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(BeneficialOwnership5Choice.Indicator),nameof(BeneficialOwnership5Choice.Indicator))]
    [JsonDerivedType(typeof(BeneficialOwnership5Choice.Proprietary),nameof(BeneficialOwnership5Choice.Proprietary))]
    #endif
    [IsoId("_5m6A45NLEeWGlc8L7oPDIg")]
    [DisplayName("Beneficial Ownership 5 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record BeneficialOwnership5Choice_
    #else
    public abstract partial class BeneficialOwnership5Choice_
    #endif
    {
    }
}
