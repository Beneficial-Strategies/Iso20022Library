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
    /// Choice between a corporate action identification or a corporate action official identification.
    /// </summary>
    [KnownType(typeof(CorporateActionEventReference4Choice.LinkedOfficialCorporateActionEventIdentification))]
    [KnownType(typeof(CorporateActionEventReference4Choice.LinkedCorporateActionIdentification))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(CorporateActionEventReference4Choice.LinkedOfficialCorporateActionEventIdentification),nameof(CorporateActionEventReference4Choice.LinkedOfficialCorporateActionEventIdentification))]
    [JsonDerivedType(typeof(CorporateActionEventReference4Choice.LinkedCorporateActionIdentification),nameof(CorporateActionEventReference4Choice.LinkedCorporateActionIdentification))]
    #endif
    [IsoId("_chUcWZKQEeWHWpTQn1FFVg")]
    [DisplayName("Corporate Action Event Reference 4 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CorporateActionEventReference4Choice_
    #else
    public abstract partial class CorporateActionEventReference4Choice_
    #endif
    {
    }
}
