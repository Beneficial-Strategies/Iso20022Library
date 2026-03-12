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
[IsoId("_SOAxLSqCEeyR9JrVGfaMKw")]
[DisplayName("Additional Information")]
public partial record AdditionalInformation26
{
    #nullable enable
    
    /// <summary>
    /// Identification of the transaction as known by the account owner. Will be used in a unilateral split to provide the executing party with the account owner identification of each split transaction.
    /// </summary>
    [IsoId("_Sl2pVSqCEeyR9JrVGfaMKw")]
    [DisplayName("Account Owner Transaction Identification")]
    [IsoXmlTag("AcctOwnrTxId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? AccountOwnerTransactionIdentification { get; init; } 
    
    /// <summary>
    /// Type of instrument involved in the transactions on which the modification request should apply.
    /// </summary>
    [IsoId("_Sl2pXSqCEeyR9JrVGfaMKw")]
    [DisplayName("Classification Type")]
    [IsoXmlTag("ClssfctnTp")]
    public ClassificationType32Choice_? ClassificationType { get; init; } 
    
    /// <summary>
    /// Account to or from which a securities entry is made.
    /// </summary>
    [IsoId("_Sl2pYSqCEeyR9JrVGfaMKw")]
    [DisplayName("Safekeeping Account")]
    [IsoXmlTag("SfkpgAcct")]
    public SecuritiesAccount19? SafekeepingAccount { get; init; } 
    
    /// <summary>
    /// Blockchain address or wallet where digital assets are maintained. This is the equivalent of safekeeping account for digital assets.
    /// </summary>
    [IsoId("_QxLtEyqKEeyR9JrVGfaMKw")]
    [DisplayName("Block Chain Address Or Wallet")]
    [IsoXmlTag("BlckChainAdrOrWllt")]
    public BlockChainAddressWallet3? BlockChainAddressOrWallet { get; init; } 
    
    /// <summary>
    /// Identification of the financial instrument to which the modification request applied.
    /// </summary>
    [IsoId("_Sl2pZSqCEeyR9JrVGfaMKw")]
    [DisplayName("Financial Instrument Identification")]
    [IsoXmlTag("FinInstrmId")]
    public SecurityIdentification19? FinancialInstrumentIdentification { get; init; } 
    
    /// <summary>
    /// Quantity of financial instrument concerned by the settlement condition modification request.
    /// </summary>
    [IsoId("_Sl2paSqCEeyR9JrVGfaMKw")]
    [DisplayName("Quantity")]
    [IsoXmlTag("Qty")]
    public FinancialInstrumentQuantity33Choice_? Quantity { get; init; } 
    
    /// <summary>
    /// Date/time when the request should take effect.
    /// </summary>
    [IsoId("_Sl2pbSqCEeyR9JrVGfaMKw")]
    [DisplayName("Effective Date")]
    [IsoXmlTag("FctvDt")]
    public DateAndDateTime2Choice_? EffectiveDate { get; init; } 
    
    /// <summary>
    /// Date/time when the request should cease to be in effect.
    /// </summary>
    [IsoId("_Sl2pcSqCEeyR9JrVGfaMKw")]
    [DisplayName("Expiry Date")]
    [IsoXmlTag("XpryDt")]
    public DateAndDateTime2Choice_? ExpiryDate { get; init; } 
    
    /// <summary>
    /// Date/time of the release.
    /// </summary>
    [IsoId("_Sl2pdSqCEeyR9JrVGfaMKw")]
    [DisplayName("Cut Off Date")]
    [IsoXmlTag("CutOffDt")]
    public DateAndDateTime2Choice_? CutOffDate { get; init; } 
    
    /// <summary>
    /// Party, either an individual or organisation, whose assets are being invested.
    /// </summary>
    [IsoId("_Sl2peSqCEeyR9JrVGfaMKw")]
    [DisplayName("Investor")]
    [IsoXmlTag("Invstr")]
    public PartyIdentification136? Investor { get; init; } 
    
    /// <summary>
    /// Party that, in a settlement chain, interacts with the depository.
    /// </summary>
    [IsoId("_Sl2pfSqCEeyR9JrVGfaMKw")]
    [DisplayName("Delivering Party")]
    [IsoXmlTag("DlvrgPty1")]
    public PartyIdentificationAndAccount195? DeliveringParty1 { get; init; } 
    
    /// <summary>
    /// Party that, in a settlement chain, interacts with the depository.
    /// </summary>
    [IsoId("_Sl2pgSqCEeyR9JrVGfaMKw")]
    [DisplayName("Receiving Party")]
    [IsoXmlTag("RcvgPty1")]
    public PartyIdentificationAndAccount195? ReceivingParty1 { get; init; } 
    
    /// <summary>
    /// The transaction relates to a buy-in by the market following a delivery transaction failure.
    /// </summary>
    [IsoId("_Sl2phSqCEeyR9JrVGfaMKw")]
    [DisplayName("Transaction Subject To Buy In")]
    [IsoXmlTag("TxSbjtToBuyIn")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? TransactionSubjectToBuyIn { get; init; } 
    
    
    #nullable disable
    
}
