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
    /// Provides the status of thesecurities movement.
    /// </summary>
    [KnownType(typeof(SecuritiesMovementStatus1Choice.Amount))]
    [KnownType(typeof(SecuritiesMovementStatus1Choice.Cash))]
    [KnownType(typeof(SecuritiesMovementStatus1Choice.Currency))]
    [KnownType(typeof(SecuritiesMovementStatus1Choice.Excluded))]
    [KnownType(typeof(SecuritiesMovementStatus1Choice.Future))]
    [KnownType(typeof(SecuritiesMovementStatus1Choice.Pending))]
    [KnownType(typeof(SecuritiesMovementStatus1Choice.ManuallyAccepted))]
    [KnownType(typeof(SecuritiesMovementStatus1Choice.Eligibility))]
    [KnownType(typeof(SecuritiesMovementStatus1Choice.Tax))]
    [KnownType(typeof(SecuritiesMovementStatus1Choice.Wait))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(SecuritiesMovementStatus1Choice.Amount),nameof(SecuritiesMovementStatus1Choice.Amount))]
    [JsonDerivedType(typeof(SecuritiesMovementStatus1Choice.Cash),nameof(SecuritiesMovementStatus1Choice.Cash))]
    [JsonDerivedType(typeof(SecuritiesMovementStatus1Choice.Currency),nameof(SecuritiesMovementStatus1Choice.Currency))]
    [JsonDerivedType(typeof(SecuritiesMovementStatus1Choice.Excluded),nameof(SecuritiesMovementStatus1Choice.Excluded))]
    [JsonDerivedType(typeof(SecuritiesMovementStatus1Choice.Future),nameof(SecuritiesMovementStatus1Choice.Future))]
    [JsonDerivedType(typeof(SecuritiesMovementStatus1Choice.Pending),nameof(SecuritiesMovementStatus1Choice.Pending))]
    [JsonDerivedType(typeof(SecuritiesMovementStatus1Choice.ManuallyAccepted),nameof(SecuritiesMovementStatus1Choice.ManuallyAccepted))]
    [JsonDerivedType(typeof(SecuritiesMovementStatus1Choice.Eligibility),nameof(SecuritiesMovementStatus1Choice.Eligibility))]
    [JsonDerivedType(typeof(SecuritiesMovementStatus1Choice.Tax),nameof(SecuritiesMovementStatus1Choice.Tax))]
    [JsonDerivedType(typeof(SecuritiesMovementStatus1Choice.Wait),nameof(SecuritiesMovementStatus1Choice.Wait))]
    #endif
    [IsoId("_IeQt0OCzEei2UYJ62ws-Fw")]
    [DisplayName("Securities Movement Status 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SecuritiesMovementStatus1Choice_
    #else
    public abstract partial class SecuritiesMovementStatus1Choice_
    #endif
    {
    }
}
