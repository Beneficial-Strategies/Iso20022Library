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
    /// Choice between ISIN and an alternative format for the identification of a financial instrument. ISIN is the preferred format.
    /// </summary>
    [KnownType(typeof(SecurityIdentification34Choice.ISIN))]
    [KnownType(typeof(SecurityIdentification34Choice.AlternativeInstrumentIdentification))]
    [KnownType(typeof(SecurityIdentification34Choice.UniqueProductIdentifier))]
    [KnownType(typeof(SecurityIdentification34Choice.BasketConstituents))]
    [KnownType(typeof(SecurityIdentification34Choice.Index))]
    [KnownType(typeof(SecurityIdentification34Choice.IdentificationNotAvailable))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(SecurityIdentification34Choice.ISIN),nameof(SecurityIdentification34Choice.ISIN))]
    [JsonDerivedType(typeof(SecurityIdentification34Choice.AlternativeInstrumentIdentification),nameof(SecurityIdentification34Choice.AlternativeInstrumentIdentification))]
    [JsonDerivedType(typeof(SecurityIdentification34Choice.UniqueProductIdentifier),nameof(SecurityIdentification34Choice.UniqueProductIdentifier))]
    [JsonDerivedType(typeof(SecurityIdentification34Choice.BasketConstituents),nameof(SecurityIdentification34Choice.BasketConstituents))]
    [JsonDerivedType(typeof(SecurityIdentification34Choice.Index),nameof(SecurityIdentification34Choice.Index))]
    [JsonDerivedType(typeof(SecurityIdentification34Choice.IdentificationNotAvailable),nameof(SecurityIdentification34Choice.IdentificationNotAvailable))]
    #endif
    [IsoId("_Zkpc3w1HEeqV4s5SpzR1dQ")]
    [DisplayName("Security Identification 34 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SecurityIdentification34Choice_
    #else
    public abstract partial class SecurityIdentification34Choice_
    #endif
    {
    }
}
