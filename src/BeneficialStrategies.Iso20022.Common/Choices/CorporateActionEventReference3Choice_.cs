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
    [KnownType(typeof(CorporateActionEventReference3Choice.LinkedOfficialCorporateActionEventIdentification))]
    [KnownType(typeof(CorporateActionEventReference3Choice.LinkedCorporateActionIdentification))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(CorporateActionEventReference3Choice.LinkedOfficialCorporateActionEventIdentification),nameof(CorporateActionEventReference3Choice.LinkedOfficialCorporateActionEventIdentification))]
    [JsonDerivedType(typeof(CorporateActionEventReference3Choice.LinkedCorporateActionIdentification),nameof(CorporateActionEventReference3Choice.LinkedCorporateActionIdentification))]
    #endif
    [IsoId("_4VgxsTncEeWLJsP1cO-amg")]
    [DisplayName("Corporate Action Event Reference 3 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CorporateActionEventReference3Choice_
    #else
    public abstract partial class CorporateActionEventReference3Choice_
    #endif
    {
    }
}
