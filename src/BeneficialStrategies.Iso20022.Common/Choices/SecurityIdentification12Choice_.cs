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
    /// Choice between ISIN and an alternative format for the identification of a security. ISIN is the preferred format.
    /// </summary>
    [KnownType(typeof(SecurityIdentification12Choice.ISIN))]
    [KnownType(typeof(SecurityIdentification12Choice.OtherIdentification))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(SecurityIdentification12Choice.ISIN),nameof(SecurityIdentification12Choice.ISIN))]
    [JsonDerivedType(typeof(SecurityIdentification12Choice.OtherIdentification),nameof(SecurityIdentification12Choice.OtherIdentification))]
    #endif
    [IsoId("_XMCG4tp-Ed-ak6NoX_4Aeg_1099227898")]
    [DisplayName("Security Identification 12 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SecurityIdentification12Choice_
    #else
    public abstract partial class SecurityIdentification12Choice_
    #endif
    {
    }
}
