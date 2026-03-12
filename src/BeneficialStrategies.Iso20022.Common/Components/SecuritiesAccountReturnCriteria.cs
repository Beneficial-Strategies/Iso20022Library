// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Return criteria for information to be returned in the report deriving from a query about securities account reference data.
/// </summary>
[IsoId("_hjB2Z2liEeGaMcKyqKNRfQ_-1911828030")]
[DisplayName("Securities Account Return Criteria")]
public partial record SecuritiesAccountReturnCriteria
{
    #nullable enable
    
    /// <summary>
    /// Indicates whether the identification of the account is requested.
    /// </summary>
    [IsoId("_hjB2aGliEeGaMcKyqKNRfQ_-1979285068")]
    [DisplayName("Account Identification")]
    [IsoXmlTag("AcctId")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? AccountIdentification { get; init; } 
    
    /// <summary>
    /// Indicates whether the identification of the party owning the account is requested.
    /// </summary>
    [IsoId("_hjB2aWliEeGaMcKyqKNRfQ_1420289725")]
    [DisplayName("Party Identification")]
    [IsoXmlTag("PtyId")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? PartyIdentification { get; init; } 
    
    /// <summary>
    /// Indicates whether the type of the party owning the account is requested.
    /// </summary>
    [IsoId("_hjB2amliEeGaMcKyqKNRfQ_817359905")]
    [DisplayName("Party Type")]
    [IsoXmlTag("PtyTp")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? PartyType { get; init; } 
    
    /// <summary>
    /// Indicates whether the account servicer is requested.
    /// </summary>
    [IsoId("_hjB2a2liEeGaMcKyqKNRfQ_-1406786554")]
    [DisplayName("Account Servicer")]
    [IsoXmlTag("AcctSvcr")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? AccountServicer { get; init; } 
    
    /// <summary>
    /// Indicates whether the account type is requested.
    /// </summary>
    [IsoId("_hjB2bGliEeGaMcKyqKNRfQ_-713957965")]
    [DisplayName("Account Type")]
    [IsoXmlTag("AcctTp")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? AccountType { get; init; } 
    
    /// <summary>
    /// Indicates whether the opening date for the account is requested.
    /// </summary>
    [IsoId("_hjB2bWliEeGaMcKyqKNRfQ_81224670")]
    [DisplayName("Opening Date")]
    [IsoXmlTag("OpngDt")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? OpeningDate { get; init; } 
    
    /// <summary>
    /// Indicates whether the closing date for the account is requested.
    /// </summary>
    [IsoId("_hjB2bmliEeGaMcKyqKNRfQ_841989823")]
    [DisplayName("Closing Date")]
    [IsoXmlTag("ClsgDt")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? ClosingDate { get; init; } 
    
    /// <summary>
    /// Specifies information to identify securities accounts where allocation instructions are posted.
    /// </summary>
    [IsoId("_hjB2b2liEeGaMcKyqKNRfQ_-140662419")]
    [DisplayName("End Investor Flag")]
    [IsoXmlTag("EndInvstrFlg")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? EndInvestorFlag { get; init; } 
    
    /// <summary>
    /// Defines how the price is applied to the securities account.
    /// </summary>
    [IsoId("_hjB2cGliEeGaMcKyqKNRfQ_131386874")]
    [DisplayName("Pricing Scheme")]
    [IsoXmlTag("PricgSchme")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? PricingScheme { get; init; } 
    
    
    #nullable disable
    
}
