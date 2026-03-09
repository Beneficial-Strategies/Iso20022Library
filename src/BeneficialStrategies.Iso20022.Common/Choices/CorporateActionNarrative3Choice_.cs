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
    /// Choice between a standard code or a proprietary code to specify the narrative type of corporate action.
    /// </summary>
    [KnownType(typeof(CorporateActionNarrative3Choice.Code))]
    [KnownType(typeof(CorporateActionNarrative3Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(CorporateActionNarrative3Choice.Code),nameof(CorporateActionNarrative3Choice.Code))]
    [JsonDerivedType(typeof(CorporateActionNarrative3Choice.Proprietary),nameof(CorporateActionNarrative3Choice.Proprietary))]
    #endif
    [IsoId("_7s0bd0GVEeWqy4niLuXETA")]
    [DisplayName("Corporate Action Narrative 3 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CorporateActionNarrative3Choice_
    #else
    public abstract partial class CorporateActionNarrative3Choice_
    #endif
    {
    }
}
