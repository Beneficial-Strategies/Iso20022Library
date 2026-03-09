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
    /// Choice between a standard code or a proprietary code to specify the type of the corporate action option.
    /// </summary>
    [KnownType(typeof(CorporateActionOption20Choice.Code))]
    [KnownType(typeof(CorporateActionOption20Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(CorporateActionOption20Choice.Code),nameof(CorporateActionOption20Choice.Code))]
    [JsonDerivedType(typeof(CorporateActionOption20Choice.Proprietary),nameof(CorporateActionOption20Choice.Proprietary))]
    #endif
    [IsoId("_xbrNv0GTEeWqy4niLuXETA")]
    [DisplayName("Corporate Action Option 20 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CorporateActionOption20Choice_
    #else
    public abstract partial class CorporateActionOption20Choice_
    #endif
    {
    }
}
