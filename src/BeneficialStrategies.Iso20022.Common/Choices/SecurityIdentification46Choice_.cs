// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices.SecurityIdentification46Choice;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>Choice of formats for the identification of a financial instrument.</summary>
    [IsoId("61206e78-87a2-4f61-ad40-8209d18ea4c2")]
    [DisplayName("Security Identification 46 Choice")]
    [KnownType(typeof(SecurityIdentification46Choice.ISIN))]
    [KnownType(typeof(SecurityIdentification46Choice.SEDOL))]
    [KnownType(typeof(SecurityIdentification46Choice.CUSIP))]
    [KnownType(typeof(SecurityIdentification46Choice.RIC))]
    [KnownType(typeof(SecurityIdentification46Choice.TickerSymbol))]
    [KnownType(typeof(SecurityIdentification46Choice.Bloomberg))]
    [KnownType(typeof(SecurityIdentification46Choice.CTA))]
    [KnownType(typeof(SecurityIdentification46Choice.QUICK))]
    [KnownType(typeof(SecurityIdentification46Choice.Wertpapier))]
    [KnownType(typeof(SecurityIdentification46Choice.Dutch))]
    [KnownType(typeof(SecurityIdentification46Choice.Valoren))]
    [KnownType(typeof(SecurityIdentification46Choice.Sicovam))]
    [KnownType(typeof(SecurityIdentification46Choice.Belgian))]
    [KnownType(typeof(SecurityIdentification46Choice.Common))]
    [KnownType(typeof(SecurityIdentification46Choice.DTI))]
    [KnownType(typeof(SecurityIdentification46Choice.OtherProprietaryIdentification))]
    [JsonDerivedType(typeof(SecurityIdentification46Choice.ISIN))]
    [JsonDerivedType(typeof(SecurityIdentification46Choice.SEDOL))]
    [JsonDerivedType(typeof(SecurityIdentification46Choice.CUSIP))]
    [JsonDerivedType(typeof(SecurityIdentification46Choice.RIC))]
    [JsonDerivedType(typeof(SecurityIdentification46Choice.TickerSymbol))]
    [JsonDerivedType(typeof(SecurityIdentification46Choice.Bloomberg))]
    [JsonDerivedType(typeof(SecurityIdentification46Choice.CTA))]
    [JsonDerivedType(typeof(SecurityIdentification46Choice.QUICK))]
    [JsonDerivedType(typeof(SecurityIdentification46Choice.Wertpapier))]
    [JsonDerivedType(typeof(SecurityIdentification46Choice.Dutch))]
    [JsonDerivedType(typeof(SecurityIdentification46Choice.Valoren))]
    [JsonDerivedType(typeof(SecurityIdentification46Choice.Sicovam))]
    [JsonDerivedType(typeof(SecurityIdentification46Choice.Belgian))]
    [JsonDerivedType(typeof(SecurityIdentification46Choice.Common))]
    [JsonDerivedType(typeof(SecurityIdentification46Choice.DTI))]
    [JsonDerivedType(typeof(SecurityIdentification46Choice.OtherProprietaryIdentification))]
    public abstract record SecurityIdentification46Choice_
    {
    }
}
