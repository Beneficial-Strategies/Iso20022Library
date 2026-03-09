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
    /// Choice of format for the repair reason.
    /// </summary>
    [KnownType(typeof(CorporateActionEventType73Choice.Code))]
    [KnownType(typeof(CorporateActionEventType73Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(CorporateActionEventType73Choice.Code),nameof(CorporateActionEventType73Choice.Code))]
    [JsonDerivedType(typeof(CorporateActionEventType73Choice.Proprietary),nameof(CorporateActionEventType73Choice.Proprietary))]
    #endif
    [IsoId("_w71kkaOAEeeDTpy0mhI4TQ")]
    [DisplayName("Corporate Action Event Type 73 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CorporateActionEventType73Choice_
    #else
    public abstract partial class CorporateActionEventType73Choice_
    #endif
    {
    }
}
