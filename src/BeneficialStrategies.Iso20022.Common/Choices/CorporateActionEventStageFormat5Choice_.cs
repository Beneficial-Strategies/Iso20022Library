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
    /// Choice between a standard code or proprietary code to specify the event stage type.
    /// </summary>
    [KnownType(typeof(CorporateActionEventStageFormat5Choice.Code))]
    [KnownType(typeof(CorporateActionEventStageFormat5Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(CorporateActionEventStageFormat5Choice.Code),nameof(CorporateActionEventStageFormat5Choice.Code))]
    [JsonDerivedType(typeof(CorporateActionEventStageFormat5Choice.Proprietary),nameof(CorporateActionEventStageFormat5Choice.Proprietary))]
    #endif
    [IsoId("_oI9aESUfEeO8eOSw0QN9mA")]
    [DisplayName("Corporate Action Event Stage Format 5 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CorporateActionEventStageFormat5Choice_
    #else
    public abstract partial class CorporateActionEventStageFormat5Choice_
    #endif
    {
    }
}
