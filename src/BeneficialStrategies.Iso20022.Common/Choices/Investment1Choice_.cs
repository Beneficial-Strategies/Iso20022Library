// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

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
    [JsonDerivedType(typeof(Investment1Choice.UnsecuredCashDeposit),nameof(Investment1Choice.UnsecuredCashDeposit))]
    [JsonDerivedType(typeof(Investment1Choice.CentralBankDeposit),nameof(Investment1Choice.CentralBankDeposit))]
    [JsonDerivedType(typeof(Investment1Choice.RepurchaseAgreement),nameof(Investment1Choice.RepurchaseAgreement))]
    [JsonDerivedType(typeof(Investment1Choice.OtherInvestments),nameof(Investment1Choice.OtherInvestments))]
    [JsonDerivedType(typeof(Investment1Choice.OutrightInvestment),nameof(Investment1Choice.OutrightInvestment))]
    [IsoId("_nrsigLJUEeaYqc4G3TTwhA")]
    [DisplayName("Investment 1 Choice")]
    public abstract partial record Investment1Choice_
    {
    }
}
