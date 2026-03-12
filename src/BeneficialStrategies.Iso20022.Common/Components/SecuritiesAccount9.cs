// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information about the securities account.
/// </summary>
[IsoId("_QUwGAtp-Ed-ak6NoX_4Aeg_591777960")]
[DisplayName("Securities Account")]
public partial record SecuritiesAccount9
{
    #nullable enable
    
    /// <summary>
    /// Specifies whether the value is a debit or credit.
    /// </summary>
    [IsoId("_QUwGA9p-Ed-ak6NoX_4Aeg_-1405183503")]
    [DisplayName("Credit Debit Indicator")]
    [IsoXmlTag("CdtDbtInd")]
    public required CreditDebitCode CreditDebitIndicator { get; init; } 
    
    /// <summary>
    /// Identification of the party that owns the account.
    /// </summary>
    [IsoId("_QUwGBNp-Ed-ak6NoX_4Aeg_617635713")]
    [DisplayName("Account Owner Identification")]
    [IsoXmlTag("AcctOwnrId")]
    public PartyIdentification2Choice_? AccountOwnerIdentification { get; init; } 
    
    /// <summary>
    /// Idenfitication of the account.
    /// </summary>
    [IsoId("_QUwGBdp-Ed-ak6NoX_4Aeg_617635743")]
    [DisplayName("Account Identification")]
    [IsoXmlTag("AcctId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text AccountIdentification { get; init; } 
    
    /// <summary>
    /// Type of balance.
    /// </summary>
    [IsoId("_QUwGBtp-Ed-ak6NoX_4Aeg_617635744")]
    [DisplayName("Balance Type")]
    [IsoXmlTag("BalTp")]
    public SecuritiesBalanceType10FormatChoice_? BalanceType { get; init; } 
    
    /// <summary>
    /// Specifies the corporate action options available to the account owner.
    /// </summary>
    [IsoId("_QUwGB9p-Ed-ak6NoX_4Aeg_-34603986")]
    [DisplayName("Option Type")]
    [IsoXmlTag("OptnTp")]
    public CorporateActionOption1FormatChoice_? OptionType { get; init; } 
    
    /// <summary>
    /// Number identifying the available corporate action options.
    /// </summary>
    [IsoId("_QUwGCNp-Ed-ak6NoX_4Aeg_-34603677")]
    [DisplayName("Option Number")]
    [IsoXmlTag("OptnNb")]
    [IsoSimpleType(IsoSimpleType.Exact3NumericText)]
    public IsoExact3NumericText? OptionNumber { get; init; } 
    
    /// <summary>
    /// Specifies the form of the financial instrument.
    /// </summary>
    [IsoId("_QUwGCdp-Ed-ak6NoX_4Aeg_537320662")]
    [DisplayName("Security Holding Form")]
    [IsoXmlTag("SctyHldgForm")]
    public FormOfSecurity1Code? SecurityHoldingForm { get; init; } 
    
    
    #nullable disable
    
}
