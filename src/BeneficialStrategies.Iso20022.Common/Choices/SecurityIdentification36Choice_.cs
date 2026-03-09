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
    [KnownType(typeof(SecurityIdentification36Choice.ISIN))]
    [KnownType(typeof(SecurityIdentification36Choice.AlternativeInstrumentIdentification))]
    [KnownType(typeof(SecurityIdentification36Choice.UniqueProductIdentifier))]
    [KnownType(typeof(SecurityIdentification36Choice.Basket))]
    [KnownType(typeof(SecurityIdentification36Choice.Index))]
    [KnownType(typeof(SecurityIdentification36Choice.IdentificationNotAvailable))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(SecurityIdentification36Choice.ISIN),nameof(SecurityIdentification36Choice.ISIN))]
    [JsonDerivedType(typeof(SecurityIdentification36Choice.AlternativeInstrumentIdentification),nameof(SecurityIdentification36Choice.AlternativeInstrumentIdentification))]
    [JsonDerivedType(typeof(SecurityIdentification36Choice.UniqueProductIdentifier),nameof(SecurityIdentification36Choice.UniqueProductIdentifier))]
    [JsonDerivedType(typeof(SecurityIdentification36Choice.Basket),nameof(SecurityIdentification36Choice.Basket))]
    [JsonDerivedType(typeof(SecurityIdentification36Choice.Index),nameof(SecurityIdentification36Choice.Index))]
    [JsonDerivedType(typeof(SecurityIdentification36Choice.IdentificationNotAvailable),nameof(SecurityIdentification36Choice.IdentificationNotAvailable))]
    #endif
    [IsoId("_PNQi0YrpEeq91phomTRDDA")]
    [DisplayName("Security Identification 36 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SecurityIdentification36Choice_
    #else
    public abstract partial class SecurityIdentification36Choice_
    #endif
    {
    }
}
