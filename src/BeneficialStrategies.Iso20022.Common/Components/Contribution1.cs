// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides additional information such as the contribution account identification or the requirement amount.
/// </summary>
[IsoId("_UqzgRdp-Ed-ak6NoX_4Aeg_-225785581")]
[DisplayName("Contribution")]
public partial record Contribution1
{
    #nullable enable
    
    /// <summary>
    /// Segregation done by the central counterparty based on trading venues/products or other attributes.
    /// </summary>
    [IsoId("_UqzgRtp-Ed-ak6NoX_4Aeg_-1145836666")]
    [DisplayName("Account")]
    [IsoXmlTag("Acct")]
    public AccountIdentification4Choice_? Account { get; init; } 
    
    /// <summary>
    /// Total contribution required by the clearing member to participate to the default fund.
    /// </summary>
    [IsoId("_UqzgR9p-Ed-ak6NoX_4Aeg_-1662301035")]
    [DisplayName("Required Amount")]
    [IsoXmlTag("ReqrdAmt")]
    public required ActiveCurrencyAndAmount RequiredAmount { get; init; } 
    
    /// <summary>
    /// Additional amount that the clearing member will have to provide to cover a risk increase. This results from a risk management decision depending on central counterparty specific criteria.
    /// </summary>
    [IsoId("_UqzgSNp-Ed-ak6NoX_4Aeg_432559077")]
    [DisplayName("Increase Coverage Amount")]
    [IsoXmlTag("IncrCvrgAmt")]
    public ActiveCurrencyAndAmount? IncreaseCoverageAmount { get; init; } 
    
    /// <summary>
    /// Provides the identification for the non-clearing member.
    /// </summary>
    [IsoId("_UqzgSdp-Ed-ak6NoX_4Aeg_-1098356779")]
    [DisplayName("Non Clearing Member")]
    [IsoXmlTag("NonClrMmb")]
    public PartyIdentificationAndAccount31? NonClearingMember { get; init; } 
    
    
    #nullable disable
    
}
