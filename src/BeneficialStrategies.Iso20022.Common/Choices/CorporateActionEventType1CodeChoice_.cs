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
    /// Choice between formats for the type of corporate action event.
    /// </summary>
    [KnownType(typeof(CorporateActionEventType1CodeChoice.Structured))]
    [KnownType(typeof(CorporateActionEventType1CodeChoice.Unstructured))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(CorporateActionEventType1CodeChoice.Structured),nameof(CorporateActionEventType1CodeChoice.Structured))]
    [JsonDerivedType(typeof(CorporateActionEventType1CodeChoice.Unstructured),nameof(CorporateActionEventType1CodeChoice.Unstructured))]
    #endif
    [IsoId("_UyZ9GNp-Ed-ak6NoX_4Aeg_853392558")]
    [DisplayName("Corporate Action Event Type 1 Code Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CorporateActionEventType1CodeChoice_
    #else
    public abstract partial class CorporateActionEventType1CodeChoice_
    #endif
    {
    }
}
