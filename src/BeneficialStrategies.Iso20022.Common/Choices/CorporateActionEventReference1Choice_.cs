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
    [KnownType(typeof(CorporateActionEventReference1Choice.LinkedOfficialCorporateActionEventIdentification))]
    [KnownType(typeof(CorporateActionEventReference1Choice.LinkedCorporateActionIdentification))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(CorporateActionEventReference1Choice.LinkedOfficialCorporateActionEventIdentification),nameof(CorporateActionEventReference1Choice.LinkedOfficialCorporateActionEventIdentification))]
    [JsonDerivedType(typeof(CorporateActionEventReference1Choice.LinkedCorporateActionIdentification),nameof(CorporateActionEventReference1Choice.LinkedCorporateActionIdentification))]
    #endif
    [IsoId("_QxNYidp-Ed-ak6NoX_4Aeg_-50751727")]
    [DisplayName("Corporate Action Event Reference 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CorporateActionEventReference1Choice_
    #else
    public abstract partial class CorporateActionEventReference1Choice_
    #endif
    {
    }
}
