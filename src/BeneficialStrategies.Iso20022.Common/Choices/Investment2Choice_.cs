// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Investment2Choice.
    /// </summary>
    [KnownType(typeof(Investment2Choice.CentralBankDeposit))]
    [KnownType(typeof(Investment2Choice.OtherInvestments))]
    [KnownType(typeof(Investment2Choice.OutrightInvestment))]
    [KnownType(typeof(Investment2Choice.RepurchaseAgreement))]
    [KnownType(typeof(Investment2Choice.UnsecuredCashDeposit))]
    [JsonDerivedType(typeof(Investment2Choice.CentralBankDeposit),nameof(Investment2Choice.CentralBankDeposit))]
    [JsonDerivedType(typeof(Investment2Choice.OtherInvestments),nameof(Investment2Choice.OtherInvestments))]
    [JsonDerivedType(typeof(Investment2Choice.OutrightInvestment),nameof(Investment2Choice.OutrightInvestment))]
    [JsonDerivedType(typeof(Investment2Choice.RepurchaseAgreement),nameof(Investment2Choice.RepurchaseAgreement))]
    [JsonDerivedType(typeof(Investment2Choice.UnsecuredCashDeposit),nameof(Investment2Choice.UnsecuredCashDeposit))]
    [IsoId("_3K_Q0YrdEe-RMan1tLkKgA")]
    [DisplayName("Investment2Choice")]
    public abstract partial record Investment2Choice_
    {
    }
}
