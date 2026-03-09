// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Additional specific modification criteria.
/// </summary>
[IsoId("_djQq8Ti8Eeydid5dcNPKvg")]
[DisplayName("Additional Information")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AdditionalInformation28
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the transaction as known by the account owner. Will be used in a unilateral split to provide the executing party with the account owner identification of each split transaction.
    /// </summary>
    [IsoId("_djQq-zi8Eeydid5dcNPKvg")]
    [DisplayName("Account Owner Transaction Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctOwnrTxId")]
    #endif
    [IsoXmlTag("AcctOwnrTxId")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax16Text)]
    [StringLength(maximumLength: 16 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRestrictedFINXMax16Text? AccountOwnerTransactionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AccountOwnerTransactionIdentification { get; init; } 
    #else
    public System.String? AccountOwnerTransactionIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Type of instrument involved in the transactions on which the modification request should apply.
    /// </summary>
    [IsoId("_djQrAzi8Eeydid5dcNPKvg")]
    [DisplayName("Classification Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClssfctnTp")]
    #endif
    [IsoXmlTag("ClssfctnTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ClassificationType33Choice_? ClassificationType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ClassificationType33Choice_? ClassificationType { get; init; } 
    #else
    public ClassificationType33Choice_? ClassificationType { get; set; } 
    #endif
    
    /// <summary>
    /// Account to or from which a securities entry is made.
    /// </summary>
    [IsoId("_djQrBzi8Eeydid5dcNPKvg")]
    [DisplayName("Safekeeping Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SfkpgAcct")]
    #endif
    [IsoXmlTag("SfkpgAcct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SecuritiesAccount30? SafekeepingAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecuritiesAccount30? SafekeepingAccount { get; init; } 
    #else
    public SecuritiesAccount30? SafekeepingAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Blockchain address or wallet where digital assets are maintained. This is the equivalent of safekeeping account for digital assets.
    /// </summary>
    [IsoId("_djQrCzi8Eeydid5dcNPKvg")]
    [DisplayName("Block Chain Address Or Wallet")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BlckChainAdrOrWllt")]
    #endif
    [IsoXmlTag("BlckChainAdrOrWllt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BlockChainAddressWallet7? BlockChainAddressOrWallet { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BlockChainAddressWallet7? BlockChainAddressOrWallet { get; init; } 
    #else
    public BlockChainAddressWallet7? BlockChainAddressOrWallet { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the financial instrument to which the modification request applied.
    /// </summary>
    [IsoId("_djQrDTi8Eeydid5dcNPKvg")]
    [DisplayName("Financial Instrument Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FinInstrmId")]
    #endif
    [IsoXmlTag("FinInstrmId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SecurityIdentification20? FinancialInstrumentIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecurityIdentification20? FinancialInstrumentIdentification { get; init; } 
    #else
    public SecurityIdentification20? FinancialInstrumentIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Quantity of financial instrument concerned by the settlement condition modification request.
    /// </summary>
    [IsoId("_djQrETi8Eeydid5dcNPKvg")]
    [DisplayName("Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Qty")]
    #endif
    [IsoXmlTag("Qty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentQuantity36Choice_? Quantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity36Choice_? Quantity { get; init; } 
    #else
    public FinancialInstrumentQuantity36Choice_? Quantity { get; set; } 
    #endif
    
    /// <summary>
    /// Date/time when the request should take effect.
    /// </summary>
    [IsoId("_djQrFTi8Eeydid5dcNPKvg")]
    [DisplayName("Effective Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FctvDt")]
    #endif
    [IsoXmlTag("FctvDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateAndDateTime2Choice_? EffectiveDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateAndDateTime2Choice_? EffectiveDate { get; init; } 
    #else
    public DateAndDateTime2Choice_? EffectiveDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date/time when the request should cease to be in effect.
    /// </summary>
    [IsoId("_djQrGTi8Eeydid5dcNPKvg")]
    [DisplayName("Expiry Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XpryDt")]
    #endif
    [IsoXmlTag("XpryDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateAndDateTime2Choice_? ExpiryDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateAndDateTime2Choice_? ExpiryDate { get; init; } 
    #else
    public DateAndDateTime2Choice_? ExpiryDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date/time of the release.
    /// </summary>
    [IsoId("_djQrHTi8Eeydid5dcNPKvg")]
    [DisplayName("Cut Off Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CutOffDt")]
    #endif
    [IsoXmlTag("CutOffDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateAndDateTime2Choice_? CutOffDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateAndDateTime2Choice_? CutOffDate { get; init; } 
    #else
    public DateAndDateTime2Choice_? CutOffDate { get; set; } 
    #endif
    
    /// <summary>
    /// Party, either an individual or organisation, whose assets are being invested.
    /// </summary>
    [IsoId("_djQrITi8Eeydid5dcNPKvg")]
    [DisplayName("Investor")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Invstr")]
    #endif
    [IsoXmlTag("Invstr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification157? Investor { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification157? Investor { get; init; } 
    #else
    public PartyIdentification157? Investor { get; set; } 
    #endif
    
    /// <summary>
    /// Party that, in a settlement chain, interacts with the depository.
    /// </summary>
    [IsoId("_djQrJTi8Eeydid5dcNPKvg")]
    [DisplayName("Delivering Party")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DlvrgPty1")]
    #endif
    [IsoXmlTag("DlvrgPty1")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentificationAndAccount215? DeliveringParty1 { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentificationAndAccount215? DeliveringParty1 { get; init; } 
    #else
    public PartyIdentificationAndAccount215? DeliveringParty1 { get; set; } 
    #endif
    
    /// <summary>
    /// Party that, in a settlement chain, interacts with the depository.
    /// </summary>
    [IsoId("_djQrKTi8Eeydid5dcNPKvg")]
    [DisplayName("Receiving Party")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RcvgPty1")]
    #endif
    [IsoXmlTag("RcvgPty1")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentificationAndAccount215? ReceivingParty1 { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentificationAndAccount215? ReceivingParty1 { get; init; } 
    #else
    public PartyIdentificationAndAccount215? ReceivingParty1 { get; set; } 
    #endif
    
    /// <summary>
    /// The transaction relates to a buy-in by the market following a delivery transaction failure.
    /// </summary>
    [IsoId("_djQrLTi8Eeydid5dcNPKvg")]
    [DisplayName("Transaction Subject To Buy In")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxSbjtToBuyIn")]
    #endif
    [IsoXmlTag("TxSbjtToBuyIn")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? TransactionSubjectToBuyIn { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TransactionSubjectToBuyIn { get; init; } 
    #else
    public System.String? TransactionSubjectToBuyIn { get; set; } 
    #endif
    
    
    #nullable disable
    
}
