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
[IsoId("_QUJpF9p-Ed-ak6NoX_4Aeg_-1770262344")]
[DisplayName("Securities Account")]
public partial record SecuritiesAccount10
{
    #nullable enable
    
    /// <summary>
    /// Specifies whether the value is a debit or credit.
    /// </summary>
    [IsoId("_QUJpGNp-Ed-ak6NoX_4Aeg_-1509539821")]
    [DisplayName("Credit Debit Indicator")]
    [IsoXmlTag("CdtDbtInd")]
    public required CreditDebitCode CreditDebitIndicator { get; init; } 
    
    /// <summary>
    /// Identification of the party that owns the account.
    /// </summary>
    [IsoId("_QUJpGdp-Ed-ak6NoX_4Aeg_-1526450863")]
    [DisplayName("Account Owner Identification")]
    [IsoXmlTag("AcctOwnrId")]
    public PartyIdentification2Choice_? AccountOwnerIdentification { get; init; } 
    
    /// <summary>
    /// Nationality of the account owner.
    /// </summary>
    [IsoId("_QUJpGtp-Ed-ak6NoX_4Aeg_933471459")]
    [DisplayName("Account Owner Nationality")]
    [IsoXmlTag("AcctOwnrNtlty")]
    public NationalityCode? AccountOwnerNationality { get; init; } 
    
    /// <summary>
    /// Idenfitication of the account.
    /// </summary>
    [IsoId("_QUTaENp-Ed-ak6NoX_4Aeg_-1526450862")]
    [DisplayName("Account Identification")]
    [IsoXmlTag("AcctId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text AccountIdentification { get; init; } 
    
    /// <summary>
    /// Type of balance.
    /// </summary>
    [IsoId("_QUTaEdp-Ed-ak6NoX_4Aeg_-1526450832")]
    [DisplayName("Balance Type")]
    [IsoXmlTag("BalTp")]
    public SecuritiesBalanceType9FormatChoice_? BalanceType { get; init; } 
    
    /// <summary>
    /// Specifies the form of the financial instrument.
    /// </summary>
    [IsoId("_QUTaEtp-Ed-ak6NoX_4Aeg_1158516377")]
    [DisplayName("Security Holding Form")]
    [IsoXmlTag("SctyHldgForm")]
    public FormOfSecurity1Code? SecurityHoldingForm { get; init; } 
    
    
    #nullable disable
    
}
