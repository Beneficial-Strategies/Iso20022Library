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
    /// Choice of format for the response status.
    /// </summary>
    [KnownType(typeof(ResponseStatus7Choice.Code))]
    [KnownType(typeof(ResponseStatus7Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(ResponseStatus7Choice.Code),nameof(ResponseStatus7Choice.Code))]
    [JsonDerivedType(typeof(ResponseStatus7Choice.Proprietary),nameof(ResponseStatus7Choice.Proprietary))]
    #endif
    [IsoId("_8QcPRZNLEeWGlc8L7oPDIg")]
    [DisplayName("Response Status 7 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ResponseStatus7Choice_
    #else
    public abstract partial class ResponseStatus7Choice_
    #endif
    {
    }
}
