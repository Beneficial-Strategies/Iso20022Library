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
    /// Defines the type of action to be performed in the request.
    /// </summary>
    [KnownType(typeof(RequestType3Choice.Code))]
    [KnownType(typeof(RequestType3Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(RequestType3Choice.Code),nameof(RequestType3Choice.Code))]
    [JsonDerivedType(typeof(RequestType3Choice.Proprietary),nameof(RequestType3Choice.Proprietary))]
    #endif
    [IsoId("_72rN86MgEeCJ6YNENx4h-w_-777871353")]
    [DisplayName("Request Type 3 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record RequestType3Choice_
    #else
    public abstract partial class RequestType3Choice_
    #endif
    {
    }
}
