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
    [KnownType(typeof(SecurityIdentification3Choice.ISIN))]
    [KnownType(typeof(SecurityIdentification3Choice.SEDOL))]
    [KnownType(typeof(SecurityIdentification3Choice.CUSIP))]
    [KnownType(typeof(SecurityIdentification3Choice.RIC))]
    [KnownType(typeof(SecurityIdentification3Choice.TickerSymbol))]
    [KnownType(typeof(SecurityIdentification3Choice.Bloomberg))]
    [KnownType(typeof(SecurityIdentification3Choice.CTA))]
    [KnownType(typeof(SecurityIdentification3Choice.QUICK))]
    [KnownType(typeof(SecurityIdentification3Choice.Wertpapier))]
    [KnownType(typeof(SecurityIdentification3Choice.Dutch))]
    [KnownType(typeof(SecurityIdentification3Choice.Valoren))]
    [KnownType(typeof(SecurityIdentification3Choice.Sicovam))]
    [KnownType(typeof(SecurityIdentification3Choice.Belgian))]
    [KnownType(typeof(SecurityIdentification3Choice.Common))]
    [KnownType(typeof(SecurityIdentification3Choice.OtherProprietaryIdentification))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(SecurityIdentification3Choice.ISIN),nameof(SecurityIdentification3Choice.ISIN))]
    [JsonDerivedType(typeof(SecurityIdentification3Choice.SEDOL),nameof(SecurityIdentification3Choice.SEDOL))]
    [JsonDerivedType(typeof(SecurityIdentification3Choice.CUSIP),nameof(SecurityIdentification3Choice.CUSIP))]
    [JsonDerivedType(typeof(SecurityIdentification3Choice.RIC),nameof(SecurityIdentification3Choice.RIC))]
    [JsonDerivedType(typeof(SecurityIdentification3Choice.TickerSymbol),nameof(SecurityIdentification3Choice.TickerSymbol))]
    [JsonDerivedType(typeof(SecurityIdentification3Choice.Bloomberg),nameof(SecurityIdentification3Choice.Bloomberg))]
    [JsonDerivedType(typeof(SecurityIdentification3Choice.CTA),nameof(SecurityIdentification3Choice.CTA))]
    [JsonDerivedType(typeof(SecurityIdentification3Choice.QUICK),nameof(SecurityIdentification3Choice.QUICK))]
    [JsonDerivedType(typeof(SecurityIdentification3Choice.Wertpapier),nameof(SecurityIdentification3Choice.Wertpapier))]
    [JsonDerivedType(typeof(SecurityIdentification3Choice.Dutch),nameof(SecurityIdentification3Choice.Dutch))]
    [JsonDerivedType(typeof(SecurityIdentification3Choice.Valoren),nameof(SecurityIdentification3Choice.Valoren))]
    [JsonDerivedType(typeof(SecurityIdentification3Choice.Sicovam),nameof(SecurityIdentification3Choice.Sicovam))]
    [JsonDerivedType(typeof(SecurityIdentification3Choice.Belgian),nameof(SecurityIdentification3Choice.Belgian))]
    [JsonDerivedType(typeof(SecurityIdentification3Choice.Common),nameof(SecurityIdentification3Choice.Common))]
    [JsonDerivedType(typeof(SecurityIdentification3Choice.OtherProprietaryIdentification),nameof(SecurityIdentification3Choice.OtherProprietaryIdentification))]
    #endif
    [IsoId("_QdiOmtp-Ed-ak6NoX_4Aeg_1063479184")]
    [DisplayName("Security Identification 3 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SecurityIdentification3Choice_
    #else
    public abstract partial class SecurityIdentification3Choice_
    #endif
    {
    }
}
