// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Characteristics and values set for account limits.
/// </summary>
[IsoId("_M0i6YBwpEeaSw8_Cr7PTfA")]
[DisplayName("Account Limits")]
public partial record AccountLimits1
{
    #nullable enable
    
    /// <summary>
    /// Defines type of funds limits.
    /// </summary>
    [IsoId("_1mqMkBwqEeaSw8_Cr7PTfA")]
    [DisplayName("Limit Type")]
    [IsoXmlTag("LmtTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text LimitType { get; init; } 
    
    /// <summary>
    /// Amount of money of the limit.
    /// </summary>
    [IsoId("_sT1O8BwtEeaSw8_Cr7PTfA")]
    [DisplayName("Limit Amount")]
    [IsoXmlTag("LmtAmt")]
    public required ActiveCurrencyAndAmount LimitAmount { get; init; } 
    
    /// <summary>
    /// Amount of used funds out of defined limit.
    /// </summary>
    [IsoId("_AwVvYBwuEeaSw8_Cr7PTfA")]
    [DisplayName("Limit Utilisation Amount")]
    [IsoXmlTag("LmtUtlstnAmt")]
    public ActiveCurrencyAndAmount? LimitUtilisationAmount { get; init; } 
    
    /// <summary>
    /// Identification of the system member for which the limit is established.
    /// </summary>
    [IsoId("_l8WTABwuEeaSw8_Cr7PTfA")]
    [DisplayName("Bilateral Limit Counterparty Identification")]
    [IsoXmlTag("BilLmtCtrPtyId")]
    public BranchAndFinancialInstitutionIdentification5? BilateralLimitCounterpartyIdentification { get; init; } 
    
    /// <summary>
    /// Clearing scheme related to Registry of the Clearing Positions (RCP).
    /// </summary>
    [IsoId("_V6qioBwvEeaSw8_Cr7PTfA")]
    [DisplayName("Clearing Circuit Scheme")]
    [IsoXmlTag("ClrCrctSchme")]
    public ClearingScheme1Choice_? ClearingCircuitScheme { get; init; } 
    
    
    #nullable disable
    
}
