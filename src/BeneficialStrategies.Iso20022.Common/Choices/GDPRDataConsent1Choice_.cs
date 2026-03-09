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
    /// Choice of formats for the type of consent.
    /// </summary>
    [KnownType(typeof(GDPRDataConsent1Choice.Code))]
    [KnownType(typeof(GDPRDataConsent1Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(GDPRDataConsent1Choice.Code),nameof(GDPRDataConsent1Choice.Code))]
    [JsonDerivedType(typeof(GDPRDataConsent1Choice.Proprietary),nameof(GDPRDataConsent1Choice.Proprietary))]
    #endif
    [IsoId("_His4MJTTEemC09f0MxYkRg")]
    [DisplayName("GDPR Data Consent 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record GDPRDataConsent1Choice_
    #else
    public abstract partial class GDPRDataConsent1Choice_
    #endif
    {
    }
}
