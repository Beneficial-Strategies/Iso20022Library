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
[IsoId("_QUckBdp-Ed-ak6NoX_4Aeg_-1097204754")]
[DisplayName("Securities Account")]
public partial record SecuritiesAccount8
{
    #nullable enable
    
    /// <summary>
    /// Specifies whether the value is a debit or credit.
    /// </summary>
    [IsoId("_QUckBtp-Ed-ak6NoX_4Aeg_-1450435879")]
    [DisplayName("Credit Debit Indicator")]
    [IsoXmlTag("CdtDbtInd")]
    public required CreditDebitCode CreditDebitIndicator { get; init; } 
    
    /// <summary>
    /// Identification of the party that owns the account.
    /// </summary>
    [IsoId("_QUckB9p-Ed-ak6NoX_4Aeg_-1042716086")]
    [DisplayName("Account Owner Identification")]
    [IsoXmlTag("AcctOwnrId")]
    public PartyIdentification2Choice_? AccountOwnerIdentification { get; init; } 
    
    /// <summary>
    /// Idenfitication of the account where financial instruments are maintained.
    /// </summary>
    [IsoId("_QUckCNp-Ed-ak6NoX_4Aeg_-1042716085")]
    [DisplayName("Account Identification")]
    [IsoXmlTag("AcctId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text AccountIdentification { get; init; } 
    
    /// <summary>
    /// Type of balance.
    /// </summary>
    [IsoId("_QUmVANp-Ed-ak6NoX_4Aeg_-1042716055")]
    [DisplayName("Balance Type")]
    [IsoXmlTag("BalTp")]
    public SecuritiesBalanceType10FormatChoice_? BalanceType { get; init; } 
    
    /// <summary>
    /// Specifies the corporate action options available to the account owner.
    /// </summary>
    [IsoId("_QUmVAdp-Ed-ak6NoX_4Aeg_-1042716054")]
    [DisplayName("Option Type")]
    [IsoXmlTag("OptnTp")]
    public CorporateActionOption1FormatChoice_? OptionType { get; init; } 
    
    /// <summary>
    /// Number identifying the available corporate action options.
    /// </summary>
    [IsoId("_QUmVAtp-Ed-ak6NoX_4Aeg_-1042716025")]
    [DisplayName("Option Number")]
    [IsoXmlTag("OptnNb")]
    [IsoSimpleType(IsoSimpleType.Exact3NumericText)]
    public IsoExact3NumericText? OptionNumber { get; init; } 
    
    /// <summary>
    /// Specifies the form of the financial instrument.
    /// </summary>
    [IsoId("_QUmVA9p-Ed-ak6NoX_4Aeg_-1042715994")]
    [DisplayName("Security Holding Form")]
    [IsoXmlTag("SctyHldgForm")]
    public FormOfSecurity1Code? SecurityHoldingForm { get; init; } 
    
    /// <summary>
    /// Specifies if the stamp duty is applicable.
    /// </summary>
    [IsoId("_QUmVBNp-Ed-ak6NoX_4Aeg_-1896087600")]
    [DisplayName("Stamp Duty")]
    [IsoXmlTag("StmpDty")]
    public StampDutyType1FormatChoice_? StampDuty { get; init; } 
    
    
    #nullable disable
    
}
