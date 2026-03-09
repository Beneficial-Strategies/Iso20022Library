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
    /// Provides the financial instruments details or the operational error details.
    /// </summary>
    [KnownType(typeof(SecurityOrOperationalError4Choice.SecurityReportOrBusinessError))]
    [KnownType(typeof(SecurityOrOperationalError4Choice.OperationalError))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(SecurityOrOperationalError4Choice.SecurityReportOrBusinessError),nameof(SecurityOrOperationalError4Choice.SecurityReportOrBusinessError))]
    [JsonDerivedType(typeof(SecurityOrOperationalError4Choice.OperationalError),nameof(SecurityOrOperationalError4Choice.OperationalError))]
    #endif
    [IsoId("_P3wGYZJKEeuAlLVx8pyt3w")]
    [DisplayName("Security Or Operational Error 4 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SecurityOrOperationalError4Choice_
    #else
    public abstract partial class SecurityOrOperationalError4Choice_
    #endif
    {
    }
}
