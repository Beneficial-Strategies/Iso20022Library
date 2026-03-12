// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// General information about the collateral agreement.
/// </summary>
[IsoId("_G5UkMSW1EeyT3chuyX0PgA")]
[DisplayName("Obligation")]
public partial record Obligation8
{
    #nullable enable
    
    /// <summary>
    /// One of the entities associated with the collateral agreement
    /// </summary>
    [IsoId("_HRJ1YSW1EeyT3chuyX0PgA")]
    [DisplayName("Party A")]
    [IsoXmlTag("PtyA")]
    public required PartyIdentification178Choice_ PartyA { get; init; } 
    
    /// <summary>
    /// Party that is acting on behalf of party A and that offers collateral management services.
    /// </summary>
    [IsoId("_HRJ1YyW1EeyT3chuyX0PgA")]
    [DisplayName("Servicing Party A")]
    [IsoXmlTag("SvcgPtyA")]
    public PartyIdentification178Choice_? ServicingPartyA { get; init; } 
    
    /// <summary>
    /// Other entity associated with the collateral agreement
    /// </summary>
    [IsoId("_HRJ1ZSW1EeyT3chuyX0PgA")]
    [DisplayName("Party B")]
    [IsoXmlTag("PtyB")]
    public required PartyIdentification178Choice_ PartyB { get; init; } 
    
    /// <summary>
    /// Party that is acting on behalf of party B and that offers collateral management services.
    /// </summary>
    [IsoId("_HRJ1ZyW1EeyT3chuyX0PgA")]
    [DisplayName("Servicing Party B")]
    [IsoXmlTag("SvcgPtyB")]
    public PartyIdentification178Choice_? ServicingPartyB { get; init; } 
    
    /// <summary>
    /// Provides additional information on the collateral account of the party delivering/receiving the collateral.
    /// </summary>
    [IsoId("_HRJ1aSW1EeyT3chuyX0PgA")]
    [DisplayName("Collateral Account Identification")]
    [IsoXmlTag("CollAcctId")]
    public CollateralAccount3? CollateralAccountIdentification { get; init; } 
    
    /// <summary>
    /// Blockchain address or wallet where digital assets are maintained. This is the equivalent of collateral account for digital assets.
    /// </summary>
    [IsoId("_ac_m4yqREeyR9JrVGfaMKw")]
    [DisplayName("Block Chain Address Or Wallet")]
    [IsoXmlTag("BlckChainAdrOrWllt")]
    public BlockChainAddressWallet5? BlockChainAddressOrWallet { get; init; } 
    
    /// <summary>
    /// Underlying business area or type of trade causing the collateral movement.
    /// </summary>
    [IsoId("_HRJ1ayW1EeyT3chuyX0PgA")]
    [DisplayName("Exposure Type")]
    [IsoXmlTag("XpsrTp")]
    public ExposureType21Choice_? ExposureType { get; init; } 
    
    /// <summary>
    /// Type of collateral instruction.
    /// </summary>
    [IsoId("_HRJ1bSW1EeyT3chuyX0PgA")]
    [DisplayName("Collateral Transaction Type")]
    [IsoXmlTag("CollTxTp")]
    public CollateralTransactionType1Choice_? CollateralTransactionType { get; init; } 
    
    /// <summary>
    /// Specifies whether the client is the collateral taker or giver.
    /// </summary>
    [IsoId("_HRJ1byW1EeyT3chuyX0PgA")]
    [DisplayName("Collateral Side")]
    [IsoXmlTag("CollSd")]
    public CollateralRole1Code? CollateralSide { get; init; } 
    
    /// <summary>
    /// Amount of the principal. 
    /// </summary>
    [IsoId("_HRJ1cSW1EeyT3chuyX0PgA")]
    [DisplayName("Exposure Amount")]
    [IsoXmlTag("XpsrAmt")]
    public ActiveOrHistoricCurrencyAndAmount? ExposureAmount { get; init; } 
    
    /// <summary>
    /// Close of business date on which the initiating party is valuing the margin call.
    /// </summary>
    [IsoId("_HRJ1cyW1EeyT3chuyX0PgA")]
    [DisplayName("Valuation Date")]
    [IsoXmlTag("ValtnDt")]
    public DateAndDateTime2Choice_? ValuationDate { get; init; } 
    
    /// <summary>
    /// Closing date/time or maturity date/time of the transaction.
    /// </summary>
    [IsoId("_HRJ1dSW1EeyT3chuyX0PgA")]
    [DisplayName("Closing Date")]
    [IsoXmlTag("ClsgDt")]
    public ClosingDate4Choice_? ClosingDate { get; init; } 
    
    /// <summary>
    /// Date/time at which the instructing party requests the instruction to be executed. 
    /// </summary>
    [IsoId("_HRJ1dyW1EeyT3chuyX0PgA")]
    [DisplayName("Requested Execution Date")]
    [IsoXmlTag("ReqdExctnDt")]
    public DateAndDateTime2Choice_? RequestedExecutionDate { get; init; } 
    
    /// <summary>
    /// Specifies the settlement process in which the collateral will be settled.
    /// </summary>
    [IsoId("_VWE58CW7EeygjNFjAlVoPA")]
    [DisplayName("Settlement Process")]
    [IsoXmlTag("SttlmPrc")]
    public GenericIdentification30? SettlementProcess { get; init; } 
    
    
    #nullable disable
    
}
