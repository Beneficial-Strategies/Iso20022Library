// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Defines the securities account position query criteria.
/// </summary>
[IsoId("_3wfPkeGBEeWCAvUNsZ5u6g")]
[DisplayName("Position Search Criteria")]
public partial record PositionSearchCriteria2
{
    #nullable enable
    
    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    [IsoId("_38iukeGBEeWCAvUNsZ5u6g")]
    [DisplayName("Account Owner")]
    [IsoXmlTag("AcctOwnr")]
    public PartyIdentification100? AccountOwner { get; init; } 
    
    /// <summary>
    /// Party that manages the account on behalf of the account owner, that is manages the registration and booking of entries on the account, calculates balances on the account and provides information about the account.
    /// </summary>
    [IsoId("_38iuk-GBEeWCAvUNsZ5u6g")]
    [DisplayName("Account Servicer")]
    [IsoXmlTag("AcctSvcr")]
    public PartyIdentification100? AccountServicer { get; init; } 
    
    /// <summary>
    /// Account to or from which a securities entry is made.
    /// </summary>
    [IsoId("_38iuleGBEeWCAvUNsZ5u6g")]
    [DisplayName("Safekeeping Account")]
    [IsoXmlTag("SfkpgAcct")]
    public SecuritiesAccount2Choice_? SafekeepingAccount { get; init; } 
    
    /// <summary>
    /// Financial instrument representing a sum of rights of the investor vis-à-vis the issuer.
    /// </summary>
    [IsoId("_38iul-GBEeWCAvUNsZ5u6g")]
    [DisplayName("Financial Instrument")]
    [IsoXmlTag("FinInstrm")]
    public SecurityIdentification19? FinancialInstrument { get; init; } 
    
    /// <summary>
    /// Country where the security is issued.
    /// </summary>
    [IsoId("_38iumeGBEeWCAvUNsZ5u6g")]
    [DisplayName("Country Of Issue")]
    [IsoXmlTag("CtryOfIsse")]
    public CountryCode? CountryOfIssue { get; init; } 
    
    /// <summary>
    /// Defines specific restriction characteristics for a securities position.
    /// </summary>
    [IsoId("_38ium-GBEeWCAvUNsZ5u6g")]
    [DisplayName("Sub Balance Type")]
    [IsoXmlTag("SubBalTp")]
    public SecuritiesBalanceType7Choice_? SubBalanceType { get; init; } 
    
    /// <summary>
    /// Option to provide output zero position in the results.
    /// </summary>
    [IsoId("_38iuneGBEeWCAvUNsZ5u6g")]
    [DisplayName("Return Zero Position")]
    [IsoXmlTag("RtrZeroPos")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public required IsoTrueFalseIndicator ReturnZeroPosition { get; init; } 
    
    
    #nullable disable
    
}
