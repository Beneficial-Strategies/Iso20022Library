// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Additional specific modification criteria.
/// </summary>
[IsoId("_djQq8Ti8Eeydid5dcNPKvg")]
[DisplayName("Additional Information")]
public partial record AdditionalInformation28
{
    #nullable enable
    
    /// <summary>
    /// Identification of the transaction as known by the account owner. Will be used in a unilateral split to provide the executing party with the account owner identification of each split transaction.
    /// </summary>
    [IsoId("_djQq-zi8Eeydid5dcNPKvg")]
    [DisplayName("Account Owner Transaction Identification")]
    [IsoXmlTag("AcctOwnrTxId")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax16Text)]
    [StringLength(maximumLength: 16 ,MinimumLength = 1)]
    public IsoRestrictedFINXMax16Text? AccountOwnerTransactionIdentification { get; init; } 
    
    /// <summary>
    /// Type of instrument involved in the transactions on which the modification request should apply.
    /// </summary>
    [IsoId("_djQrAzi8Eeydid5dcNPKvg")]
    [DisplayName("Classification Type")]
    [IsoXmlTag("ClssfctnTp")]
    public ClassificationType33Choice_? ClassificationType { get; init; } 
    
    /// <summary>
    /// Account to or from which a securities entry is made.
    /// </summary>
    [IsoId("_djQrBzi8Eeydid5dcNPKvg")]
    [DisplayName("Safekeeping Account")]
    [IsoXmlTag("SfkpgAcct")]
    public SecuritiesAccount30? SafekeepingAccount { get; init; } 
    
    /// <summary>
    /// Blockchain address or wallet where digital assets are maintained. This is the equivalent of safekeeping account for digital assets.
    /// </summary>
    [IsoId("_djQrCzi8Eeydid5dcNPKvg")]
    [DisplayName("Block Chain Address Or Wallet")]
    [IsoXmlTag("BlckChainAdrOrWllt")]
    public BlockChainAddressWallet7? BlockChainAddressOrWallet { get; init; } 
    
    /// <summary>
    /// Identification of the financial instrument to which the modification request applied.
    /// </summary>
    [IsoId("_djQrDTi8Eeydid5dcNPKvg")]
    [DisplayName("Financial Instrument Identification")]
    [IsoXmlTag("FinInstrmId")]
    public SecurityIdentification20? FinancialInstrumentIdentification { get; init; } 
    
    /// <summary>
    /// Quantity of financial instrument concerned by the settlement condition modification request.
    /// </summary>
    [IsoId("_djQrETi8Eeydid5dcNPKvg")]
    [DisplayName("Quantity")]
    [IsoXmlTag("Qty")]
    public FinancialInstrumentQuantity36Choice_? Quantity { get; init; } 
    
    /// <summary>
    /// Date/time when the request should take effect.
    /// </summary>
    [IsoId("_djQrFTi8Eeydid5dcNPKvg")]
    [DisplayName("Effective Date")]
    [IsoXmlTag("FctvDt")]
    public DateAndDateTime2Choice_? EffectiveDate { get; init; } 
    
    /// <summary>
    /// Date/time when the request should cease to be in effect.
    /// </summary>
    [IsoId("_djQrGTi8Eeydid5dcNPKvg")]
    [DisplayName("Expiry Date")]
    [IsoXmlTag("XpryDt")]
    public DateAndDateTime2Choice_? ExpiryDate { get; init; } 
    
    /// <summary>
    /// Date/time of the release.
    /// </summary>
    [IsoId("_djQrHTi8Eeydid5dcNPKvg")]
    [DisplayName("Cut Off Date")]
    [IsoXmlTag("CutOffDt")]
    public DateAndDateTime2Choice_? CutOffDate { get; init; } 
    
    /// <summary>
    /// Party, either an individual or organisation, whose assets are being invested.
    /// </summary>
    [IsoId("_djQrITi8Eeydid5dcNPKvg")]
    [DisplayName("Investor")]
    [IsoXmlTag("Invstr")]
    public PartyIdentification157? Investor { get; init; } 
    
    /// <summary>
    /// Party that, in a settlement chain, interacts with the depository.
    /// </summary>
    [IsoId("_djQrJTi8Eeydid5dcNPKvg")]
    [DisplayName("Delivering Party")]
    [IsoXmlTag("DlvrgPty1")]
    public PartyIdentificationAndAccount215? DeliveringParty1 { get; init; } 
    
    /// <summary>
    /// Party that, in a settlement chain, interacts with the depository.
    /// </summary>
    [IsoId("_djQrKTi8Eeydid5dcNPKvg")]
    [DisplayName("Receiving Party")]
    [IsoXmlTag("RcvgPty1")]
    public PartyIdentificationAndAccount215? ReceivingParty1 { get; init; } 
    
    /// <summary>
    /// The transaction relates to a buy-in by the market following a delivery transaction failure.
    /// </summary>
    [IsoId("_djQrLTi8Eeydid5dcNPKvg")]
    [DisplayName("Transaction Subject To Buy In")]
    [IsoXmlTag("TxSbjtToBuyIn")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? TransactionSubjectToBuyIn { get; init; } 
    
    
    #nullable disable
    
}
