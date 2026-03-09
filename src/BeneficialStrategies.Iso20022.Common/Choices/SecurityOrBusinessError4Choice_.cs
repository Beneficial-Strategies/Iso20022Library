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
    /// Provides the financial instruments details or the business error.
    /// </summary>
    [KnownType(typeof(SecurityOrBusinessError4Choice.SecurityReport))]
    [KnownType(typeof(SecurityOrBusinessError4Choice.BusinessError))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(SecurityOrBusinessError4Choice.SecurityReport),nameof(SecurityOrBusinessError4Choice.SecurityReport))]
    [JsonDerivedType(typeof(SecurityOrBusinessError4Choice.BusinessError),nameof(SecurityOrBusinessError4Choice.BusinessError))]
    #endif
    [IsoId("_P5yGtZJKEeuAlLVx8pyt3w")]
    [DisplayName("Security Or Business Error 4 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SecurityOrBusinessError4Choice_
    #else
    public abstract partial class SecurityOrBusinessError4Choice_
    #endif
    {
    }
}
