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
    /// Choice of format for the registration processing status.
    /// </summary>
    [KnownType(typeof(RegistrationProcessingStatus4Choice.Code))]
    [KnownType(typeof(RegistrationProcessingStatus4Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(RegistrationProcessingStatus4Choice.Code),nameof(RegistrationProcessingStatus4Choice.Code))]
    [JsonDerivedType(typeof(RegistrationProcessingStatus4Choice.Proprietary),nameof(RegistrationProcessingStatus4Choice.Proprietary))]
    #endif
    [IsoId("_8QcPIZNLEeWGlc8L7oPDIg")]
    [DisplayName("Registration Processing Status 4 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record RegistrationProcessingStatus4Choice_
    #else
    public abstract partial class RegistrationProcessingStatus4Choice_
    #endif
    {
    }
}
