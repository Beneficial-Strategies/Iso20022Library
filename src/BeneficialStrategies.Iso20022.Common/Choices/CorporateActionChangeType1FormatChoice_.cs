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
    /// Choice of formats to express the type of changes.
    /// </summary>
    [KnownType(typeof(CorporateActionChangeType1FormatChoice.Code))]
    [KnownType(typeof(CorporateActionChangeType1FormatChoice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(CorporateActionChangeType1FormatChoice.Code),nameof(CorporateActionChangeType1FormatChoice.Code))]
    [JsonDerivedType(typeof(CorporateActionChangeType1FormatChoice.Proprietary),nameof(CorporateActionChangeType1FormatChoice.Proprietary))]
    #endif
    [IsoId("_Rl9PNtp-Ed-ak6NoX_4Aeg_-146388602")]
    [DisplayName("Corporate Action Change Type 1 Format Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CorporateActionChangeType1FormatChoice_
    #else
    public abstract partial class CorporateActionChangeType1FormatChoice_
    #endif
    {
    }
}
