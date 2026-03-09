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
    [KnownType(typeof(CorporateActionOption5Choice.Code))]
    [KnownType(typeof(CorporateActionOption5Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(CorporateActionOption5Choice.Code),nameof(CorporateActionOption5Choice.Code))]
    [JsonDerivedType(typeof(CorporateActionOption5Choice.Proprietary),nameof(CorporateActionOption5Choice.Proprietary))]
    #endif
    [IsoId("_Q0CqEtp-Ed-ak6NoX_4Aeg_-289326808")]
    [DisplayName("Corporate Action Option 5 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CorporateActionOption5Choice_
    #else
    public abstract partial class CorporateActionOption5Choice_
    #endif
    {
    }
}
