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
    [KnownType(typeof(CorporateActionRateSD6Choice.AdditionalQuantityForExistingSecurities))]
    [KnownType(typeof(CorporateActionRateSD6Choice.NewToOld))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(CorporateActionRateSD6Choice.AdditionalQuantityForExistingSecurities),nameof(CorporateActionRateSD6Choice.AdditionalQuantityForExistingSecurities))]
    [JsonDerivedType(typeof(CorporateActionRateSD6Choice.NewToOld),nameof(CorporateActionRateSD6Choice.NewToOld))]
    #endif
    [IsoId("_1kNFZjL3EeKU9IrkkToqcw_1911646277")]
    [DisplayName("Corporate Action Rate SD 6 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CorporateActionRateSD6Choice_
    #else
    public abstract partial class CorporateActionRateSD6Choice_
    #endif
    {
    }
}
