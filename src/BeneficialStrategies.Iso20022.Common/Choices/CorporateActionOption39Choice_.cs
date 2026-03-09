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
    [KnownType(typeof(CorporateActionOption39Choice.Code))]
    [KnownType(typeof(CorporateActionOption39Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(CorporateActionOption39Choice.Code),nameof(CorporateActionOption39Choice.Code))]
    [JsonDerivedType(typeof(CorporateActionOption39Choice.Proprietary),nameof(CorporateActionOption39Choice.Proprietary))]
    #endif
    [IsoId("_-lke5gVSEeqjd8n6wD9JVw")]
    [DisplayName("Corporate Action Option 39 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CorporateActionOption39Choice_
    #else
    public abstract partial class CorporateActionOption39Choice_
    #endif
    {
    }
}
