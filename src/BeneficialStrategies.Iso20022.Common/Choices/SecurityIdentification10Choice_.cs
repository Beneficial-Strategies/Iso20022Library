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
    /// ISIN and an alternative format for the identification of a security. ISIN is the preferred format.
    /// </summary>
    [KnownType(typeof(SecurityIdentification10Choice.ISIN))]
    [KnownType(typeof(SecurityIdentification10Choice.OtherIdentification))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(SecurityIdentification10Choice.ISIN),nameof(SecurityIdentification10Choice.ISIN))]
    [JsonDerivedType(typeof(SecurityIdentification10Choice.OtherIdentification),nameof(SecurityIdentification10Choice.OtherIdentification))]
    #endif
    [IsoId("_RiFb19p-Ed-ak6NoX_4Aeg_2117119129")]
    [DisplayName("Security Identification 10 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SecurityIdentification10Choice_
    #else
    public abstract partial class SecurityIdentification10Choice_
    #endif
    {
    }
}
