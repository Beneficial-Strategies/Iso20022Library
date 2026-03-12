// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Defines the criteria used to search for a limit.
/// </summary>
[IsoId("_jOa_4-5NEeCisYr99QEiWA_-1185186372")]
[DisplayName("Limit Utilisation Journal Search Criteria")]
public partial record LimitUtilisationJournalSearchCriteria1
{
    #nullable enable
    
    /// <summary>
    /// Type of limit applied by the system at the present time.
    /// </summary>
    [IsoId("_jOa_5O5NEeCisYr99QEiWA_-1661846618")]
    [DisplayName("Limit Type")]
    [IsoXmlTag("LmtTp")]
    public LimitType4Code? LimitType { get; init; } 
    
    /// <summary>
    /// Date upon which journal activity takes place.
    /// </summary>
    [IsoId("_jOkw4O5NEeCisYr99QEiWA_-733934865")]
    [DisplayName("Journal Activity Date")]
    [IsoXmlTag("JrnlActvtyDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate JournalActivityDate { get; init; } 
    
    /// <summary>
    /// Unique and unambiguous identification for the account between the account owner and the account servicer.
    /// </summary>
    [IsoId("_jOkw4e5NEeCisYr99QEiWA_-766183687")]
    [DisplayName("Account Identification")]
    [IsoXmlTag("AcctId")]
    public AccountIdentification4Choice_? AccountIdentification { get; init; } 
    
    /// <summary>
    /// Currency unit used to specify the limit amount.
    /// </summary>
    [IsoId("_jOkw4u5NEeCisYr99QEiWA_658227287")]
    [DisplayName("Limit Currency")]
    [IsoXmlTag("LmtCcy")]
    public ActiveCurrencyCode? LimitCurrency { get; init; } 
    
    /// <summary>
    /// Owner of the account which is being queried.
    /// </summary>
    [IsoId("_jOkw4-5NEeCisYr99QEiWA_-1984336654")]
    [DisplayName("Account Owner")]
    [IsoXmlTag("AcctOwnr")]
    [IsoSimpleType(IsoSimpleType.BICFIIdentifier)]
    public IsoBICFIIdentifier? AccountOwner { get; init; } 
    
    /// <summary>
    /// Identification of the system member for which the limit is established.
    /// </summary>
    [IsoId("_jOkw5O5NEeCisYr99QEiWA_1853746946")]
    [DisplayName("Bilateral Limit Counterparty Identification")]
    [IsoXmlTag("BilLmtCtrPtyId")]
    public required SystemPartyIdentification4 BilateralLimitCounterpartyIdentification { get; init; } 
    
    
    #nullable disable
    
}
