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
    /// Choice between formats for the identification of a financial instrument.
    /// </summary>
    [KnownType(typeof(SecurityIdentification4Choice.ISIN))]
    [KnownType(typeof(SecurityIdentification4Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(SecurityIdentification4Choice.ISIN),nameof(SecurityIdentification4Choice.ISIN))]
    [JsonDerivedType(typeof(SecurityIdentification4Choice.Proprietary),nameof(SecurityIdentification4Choice.Proprietary))]
    #endif
    [IsoId("_Qd1wltp-Ed-ak6NoX_4Aeg_1243215798")]
    [DisplayName("Security Identification 4 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SecurityIdentification4Choice_
    #else
    public abstract partial class SecurityIdentification4Choice_
    #endif
    {
    }
}
