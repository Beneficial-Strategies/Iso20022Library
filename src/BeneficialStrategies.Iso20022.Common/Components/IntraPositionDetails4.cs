// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of the intra-position movement.
/// </summary>
[IsoId("_QW-6pdp-Ed-ak6NoX_4Aeg_144843223")]
[DisplayName("Intra Position Details")]
public partial record IntraPositionDetails4
{
    #nullable enable
    
    /// <summary>
    /// Collective reference identifying a set of messages.
    /// </summary>
    [IsoId("_QW-6ptp-Ed-ak6NoX_4Aeg_495025651")]
    [DisplayName("Pool Identification")]
    [IsoXmlTag("PoolId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? PoolIdentification { get; init; } 
    
    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    [IsoId("_QW-6p9p-Ed-ak6NoX_4Aeg_1196681416")]
    [DisplayName("Account Owner")]
    [IsoXmlTag("AcctOwnr")]
    public PartyIdentification13Choice_? AccountOwner { get; init; } 
    
    /// <summary>
    /// Account to or from which a securities entry is made.
    /// </summary>
    [IsoId("_QW-6qNp-Ed-ak6NoX_4Aeg_1915295531")]
    [DisplayName("Safekeeping Account")]
    [IsoXmlTag("SfkpgAcct")]
    public required SecuritiesAccount13 SafekeepingAccount { get; init; } 
    
    /// <summary>
    /// Financial instruments representing a sum of rights of the investor vis-a-vis the issuer.
    /// </summary>
    [IsoId("_QW-6qdp-Ed-ak6NoX_4Aeg_627843532")]
    [DisplayName("Financial Instrument Identification")]
    [IsoXmlTag("FinInstrmId")]
    public required SecurityIdentification11 FinancialInstrumentIdentification { get; init; } 
    
    /// <summary>
    /// Quantity of financial instrument effectively settled.
    /// </summary>
    [IsoId("_QW-6qtp-Ed-ak6NoX_4Aeg_144843958")]
    [DisplayName("Settled Quantity")]
    [IsoXmlTag("SttldQty")]
    public required FinancialInstrumentQuantity1Choice_ SettledQuantity { get; init; } 
    
    /// <summary>
    /// Date and time at which the securities are to be moved.
    /// </summary>
    [IsoId("_QXIroNp-Ed-ak6NoX_4Aeg_144843493")]
    [DisplayName("Settlement Date")]
    [IsoXmlTag("SttlmDt")]
    public required DateAndDateTimeChoice_ SettlementDate { get; init; } 
    
    /// <summary>
    /// Balance from which the securities are moving.
    /// </summary>
    [IsoId("_QXIrodp-Ed-ak6NoX_4Aeg_144843554")]
    [DisplayName("Balance From")]
    [IsoXmlTag("BalFr")]
    public SecuritiesBalanceType2Choice_? BalanceFrom { get; init; } 
    
    /// <summary>
    /// Balance to which the securities are moving.
    /// </summary>
    [IsoId("_QXIrotp-Ed-ak6NoX_4Aeg_144843585")]
    [DisplayName("Balance To")]
    [IsoXmlTag("BalTo")]
    public SecuritiesBalanceType2Choice_? BalanceTo { get; init; } 
    
    
    #nullable disable
    
}
