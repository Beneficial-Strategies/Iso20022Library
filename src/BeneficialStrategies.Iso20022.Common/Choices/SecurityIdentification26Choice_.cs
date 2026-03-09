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
    /// Specifies the identification of a financial instrument.
    /// </summary>
    [KnownType(typeof(SecurityIdentification26Choice.Identification))]
    [KnownType(typeof(SecurityIdentification26Choice.NotAvailable))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(SecurityIdentification26Choice.Identification),nameof(SecurityIdentification26Choice.Identification))]
    [JsonDerivedType(typeof(SecurityIdentification26Choice.NotAvailable),nameof(SecurityIdentification26Choice.NotAvailable))]
    #endif
    [IsoId("_OG6hAY7DEeaxxtxaoOwzAg")]
    [DisplayName("Security Identification 26 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SecurityIdentification26Choice_
    #else
    public abstract partial class SecurityIdentification26Choice_
    #endif
    {
    }
}
