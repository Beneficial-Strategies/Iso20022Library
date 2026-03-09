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
    [KnownType(typeof(RequestType4Choice.PaymentControl))]
    [KnownType(typeof(RequestType4Choice.Enquiry))]
    [KnownType(typeof(RequestType4Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(RequestType4Choice.PaymentControl),nameof(RequestType4Choice.PaymentControl))]
    [JsonDerivedType(typeof(RequestType4Choice.Enquiry),nameof(RequestType4Choice.Enquiry))]
    [JsonDerivedType(typeof(RequestType4Choice.Proprietary),nameof(RequestType4Choice.Proprietary))]
    #endif
    [IsoId("_ivV-XZIhEeect698_YsnIA")]
    [DisplayName("Request Type 4 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record RequestType4Choice_
    #else
    public abstract partial class RequestType4Choice_
    #endif
    {
    }
}
