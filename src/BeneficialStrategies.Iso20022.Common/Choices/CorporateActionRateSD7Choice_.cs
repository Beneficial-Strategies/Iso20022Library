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
    /// Specifies security rate details.
    /// </summary>
    [KnownType(typeof(CorporateActionRateSD7Choice.AdditionalQuantityForExistingSecurities))]
    [KnownType(typeof(CorporateActionRateSD7Choice.NewToOld))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(CorporateActionRateSD7Choice.AdditionalQuantityForExistingSecurities),nameof(CorporateActionRateSD7Choice.AdditionalQuantityForExistingSecurities))]
    [JsonDerivedType(typeof(CorporateActionRateSD7Choice.NewToOld),nameof(CorporateActionRateSD7Choice.NewToOld))]
    #endif
    [IsoId("__Aet4cOTEeeAG4VQMmSqTA")]
    [DisplayName("Corporate Action Rate SD 7 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CorporateActionRateSD7Choice_
    #else
    public abstract partial class CorporateActionRateSD7Choice_
    #endif
    {
    }
}
