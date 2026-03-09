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
    /// Choice between a standard code or a proprietary code.
    /// </summary>
    [KnownType(typeof(CorporateActionOption11Choice.Code))]
    [KnownType(typeof(CorporateActionOption11Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(CorporateActionOption11Choice.Code),nameof(CorporateActionOption11Choice.Code))]
    [JsonDerivedType(typeof(CorporateActionOption11Choice.Proprietary),nameof(CorporateActionOption11Choice.Proprietary))]
    #endif
    [IsoId("_onpwcQq_EeGFLZ_5tFfOnw")]
    [DisplayName("Corporate Action Option 11 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CorporateActionOption11Choice_
    #else
    public abstract partial class CorporateActionOption11Choice_
    #endif
    {
    }
}
