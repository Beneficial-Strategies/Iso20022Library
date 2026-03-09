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
    [KnownType(typeof(CorporateActionEventStageFormat1Choice.Code))]
    [KnownType(typeof(CorporateActionEventStageFormat1Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(CorporateActionEventStageFormat1Choice.Code),nameof(CorporateActionEventStageFormat1Choice.Code))]
    [JsonDerivedType(typeof(CorporateActionEventStageFormat1Choice.Proprietary),nameof(CorporateActionEventStageFormat1Choice.Proprietary))]
    #endif
    [IsoId("_Q3dxg9p-Ed-ak6NoX_4Aeg_1469868550")]
    [DisplayName("Corporate Action Event Stage Format 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CorporateActionEventStageFormat1Choice_
    #else
    public abstract partial class CorporateActionEventStageFormat1Choice_
    #endif
    {
    }
}
