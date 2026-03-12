// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Defines the criteria based on which information is included.
/// </summary>
[IsoId("_sJDt5Tp6EemwKdP955WBJQ")]
[DisplayName("Intra Balance Query Criteria")]
public partial record IntraBalanceQueryCriteria7
{
    #nullable enable
    
    /// <summary>
    /// Collective reference identifying a set of messages.
    /// </summary>
    [IsoId("_sTfcQTp6EemwKdP955WBJQ")]
    [DisplayName("Cancellation Request Identification")]
    [IsoXmlTag("CxlReqId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? CancellationRequestIdentification { get; init; } 
    
    /// <summary>
    /// Provides the status of settlement of a transaction.
    /// </summary>
    [IsoId("_sTfcSTp6EemwKdP955WBJQ")]
    [DisplayName("Processing Status")]
    [IsoXmlTag("PrcgSts")]
    public CancellationProcessingStatus9Choice_? ProcessingStatus { get; init; } 
    
    /// <summary>
    /// Account in which cash is maintained.
    /// </summary>
    [IsoId("_sTfcSzp6EemwKdP955WBJQ")]
    [DisplayName("Cash Account")]
    [IsoXmlTag("CshAcct")]
    public AccountIdentificationSearchCriteria2Choice_? CashAccount { get; init; } 
    
    /// <summary>
    /// Party that owns the account.
    /// </summary>
    [IsoId("_sTfcTTp6EemwKdP955WBJQ")]
    [DisplayName("Cash Account Owner")]
    [IsoXmlTag("CshAcctOwnr")]
    public SystemPartyIdentification8? CashAccountOwner { get; init; } 
    
    /// <summary>
    /// Party that manages the cash account on behalf of the account owner, that is manages the registration and booking of entries on the account, calculates balances on the account and provides information about the account.
    /// </summary>
    [IsoId("_wio14Tp9EemwKdP955WBJQ")]
    [DisplayName("Cash Account Servicer")]
    [IsoXmlTag("CshAcctSvcr")]
    public BranchAndFinancialInstitutionIdentification6? CashAccountServicer { get; init; } 
    
    /// <summary>
    /// Party that originated the message, if other than the sender.
    /// </summary>
    [IsoId("_sTfcTzp6EemwKdP955WBJQ")]
    [DisplayName("Message Originator")]
    [IsoXmlTag("MsgOrgtr")]
    public SystemPartyIdentification8? MessageOriginator { get; init; } 
    
    /// <summary>
    /// Specifies the creation date/time of the intra-balance movement.
    /// </summary>
    [IsoId("_sTfcUTp6EemwKdP955WBJQ")]
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    public DateAndDateTimeSearch5Choice_? CreationDateTime { get; init; } 
    
    
    #nullable disable
    
}
