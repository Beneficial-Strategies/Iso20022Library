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
    [KnownType(typeof(CorporateActionOption22Choice.Code))]
    [KnownType(typeof(CorporateActionOption22Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(CorporateActionOption22Choice.Code),nameof(CorporateActionOption22Choice.Code))]
    [JsonDerivedType(typeof(CorporateActionOption22Choice.Proprietary),nameof(CorporateActionOption22Choice.Proprietary))]
    #endif
    [IsoId("_cfAHtZKQEeWHWpTQn1FFVg")]
    [DisplayName("Corporate Action Option 22 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CorporateActionOption22Choice_
    #else
    public abstract partial class CorporateActionOption22Choice_
    #endif
    {
    }
}
