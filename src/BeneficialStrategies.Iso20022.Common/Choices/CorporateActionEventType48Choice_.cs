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
    [KnownType(typeof(CorporateActionEventType48Choice.Code))]
    [KnownType(typeof(CorporateActionEventType48Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(CorporateActionEventType48Choice.Code),nameof(CorporateActionEventType48Choice.Code))]
    [JsonDerivedType(typeof(CorporateActionEventType48Choice.Proprietary),nameof(CorporateActionEventType48Choice.Proprietary))]
    #endif
    [IsoId("_8VKXpZNLEeWGlc8L7oPDIg")]
    [DisplayName("Corporate Action Event Type 48 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CorporateActionEventType48Choice_
    #else
    public abstract partial class CorporateActionEventType48Choice_
    #endif
    {
    }
}
