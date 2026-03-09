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
    /// Specifies the financial instrument purchased by a central counterparty using clearing member assets.
    /// </summary>
    [KnownType(typeof(Investment1Choice.UnsecuredCashDeposit))]
    [KnownType(typeof(Investment1Choice.CentralBankDeposit))]
    [KnownType(typeof(Investment1Choice.RepurchaseAgreement))]
    [KnownType(typeof(Investment1Choice.OtherInvestments))]
    [KnownType(typeof(Investment1Choice.OutrightInvestment))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(Investment1Choice.UnsecuredCashDeposit),nameof(Investment1Choice.UnsecuredCashDeposit))]
    [JsonDerivedType(typeof(Investment1Choice.CentralBankDeposit),nameof(Investment1Choice.CentralBankDeposit))]
    [JsonDerivedType(typeof(Investment1Choice.RepurchaseAgreement),nameof(Investment1Choice.RepurchaseAgreement))]
    [JsonDerivedType(typeof(Investment1Choice.OtherInvestments),nameof(Investment1Choice.OtherInvestments))]
    [JsonDerivedType(typeof(Investment1Choice.OutrightInvestment),nameof(Investment1Choice.OutrightInvestment))]
    #endif
    [IsoId("_nrsigLJUEeaYqc4G3TTwhA")]
    [DisplayName("Investment 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record Investment1Choice_
    #else
    public abstract partial class Investment1Choice_
    #endif
    {
    }
}
