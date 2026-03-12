// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Distinct pool of financial instruments managed by a single investment policy. May or not be part of an umbrella fund.The pool is issued in at least one investment fund class.
/// </summary>
[IsoId("_TJDZotp-Ed-ak6NoX_4Aeg_1796808068")]
[DisplayName("Fund Identification")]
public partial record FundIdentification2
{
    #nullable enable
    
    /// <summary>
    /// Identification of the investment fund.
    /// </summary>
    [IsoId("_TJDZo9p-Ed-ak6NoX_4Aeg_1796808111")]
    [DisplayName("Fund Identification")]
    [IsoXmlTag("FndId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text FundIdentification { get; init; } 
    
    /// <summary>
    /// Identifies the account of the fund held with the custodian.
    /// </summary>
    [IsoId("_TJDZpNp-Ed-ak6NoX_4Aeg_1796808086")]
    [DisplayName("Account Identification With Custodian")]
    [IsoXmlTag("AcctIdWthCtdn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? AccountIdentificationWithCustodian { get; init; } 
    
    /// <summary>
    /// Identification of the custodian which services the account of the fund.
    /// </summary>
    [IsoId("_TJDZpdp-Ed-ak6NoX_4Aeg_1796808173")]
    [DisplayName("Custodian Identification")]
    [IsoXmlTag("CtdnId")]
    public PartyIdentification8Choice_? CustodianIdentification { get; init; } 
    
    
    #nullable disable
    
}
