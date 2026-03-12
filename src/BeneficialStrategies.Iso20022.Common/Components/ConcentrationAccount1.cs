// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Bank account used by a central counterparty to concentrate cash funds before or after investment.
/// </summary>
[IsoId("_tnsvELIhEeaYqc4G3TTwhA")]
[DisplayName("Concentration Account")]
public partial record ConcentrationAccount1
{
    #nullable enable
    
    /// <summary>
    /// Indicates inflows into the account.
    /// </summary>
    [IsoId("_zPbzoLIhEeaYqc4G3TTwhA")]
    [DisplayName("In Flow")]
    [IsoXmlTag("InFlow")]
    public required Flows1 InFlow { get; init; } 
    
    /// <summary>
    /// Indicates outflows out of the account.
    /// </summary>
    [IsoId("_0TkxMLIhEeaYqc4G3TTwhA")]
    [DisplayName("Out Flow")]
    [IsoXmlTag("OutFlow")]
    public required Flows1 OutFlow { get; init; } 
    
    /// <summary>
    /// Indicates end of day cash balance on the account.
    /// </summary>
    [IsoId("_1ym0QBXoEeejf-cbr8l5qw")]
    [DisplayName("End Of Day")]
    [IsoXmlTag("EndOfDay")]
    public required AmountAndDirection102 EndOfDay { get; init; } 
    
    /// <summary>
    /// Indicates peak credit balance on the account.
    /// </summary>
    [IsoId("_53fmABXoEeejf-cbr8l5qw")]
    [DisplayName("Peak Credit")]
    [IsoXmlTag("PeakCdt")]
    public required ActiveCurrencyAndAmount PeakCredit { get; init; } 
    
    /// <summary>
    /// Indicates peak debit balance on the account.
    /// </summary>
    [IsoId("_-YlLkBXoEeejf-cbr8l5qw")]
    [DisplayName("Peak Debit")]
    [IsoXmlTag("PeakDbt")]
    public required ActiveCurrencyAndAmount PeakDebit { get; init; } 
    
    /// <summary>
    /// Number of concentration account pay‐ins breaching the allowed time between instruction and confirmation. Usage: nil returns to be included for late payment confirmations in all cleared currencies.
    /// </summary>
    [IsoId("_Frc8QBXpEeejf-cbr8l5qw")]
    [DisplayName("Late Payment Confirmation")]
    [IsoXmlTag("LatePmtConf")]
    [IsoSimpleType(IsoSimpleType.Max10NumericText)]
    public required IsoMax10NumericText LatePaymentConfirmation { get; init; } 
    
    
    #nullable disable
    
}
