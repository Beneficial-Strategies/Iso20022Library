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
[IsoId("_TwGLjNp-Ed-ak6NoX_4Aeg_289518143")]
[DisplayName("Additional Information")]
public partial record AdditionalInformation3
{
    #nullable enable
    
    /// <summary>
    /// Identification of the transaction as known by the account owner. Will be used in a unilateral split to provide the executing party with the account owner identification of each split transaction.
    /// </summary>
    [IsoId("_TwGLjdp-Ed-ak6NoX_4Aeg_1127768434")]
    [DisplayName("Account Owner Transaction Identification")]
    [IsoXmlTag("AcctOwnrTxId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? AccountOwnerTransactionIdentification { get; init; } 
    
    /// <summary>
    /// Type of instrument involved in the transactions on which the modification request should apply.
    /// </summary>
    [IsoId("_TwGLjtp-Ed-ak6NoX_4Aeg_430815414")]
    [DisplayName("Classification Type")]
    [IsoXmlTag("ClssfctnTp")]
    public ClassificationType1Choice_? ClassificationType { get; init; } 
    
    /// <summary>
    /// Account to or from which a securities entry is made.
    /// </summary>
    [IsoId("_TwPVcNp-Ed-ak6NoX_4Aeg_-1493059795")]
    [DisplayName("Safekeeping Account")]
    [IsoXmlTag("SfkpgAcct")]
    public SecuritiesAccount13? SafekeepingAccount { get; init; } 
    
    /// <summary>
    /// Identification of the financial instrument involved in the transactions on which the modification request should apply.
    /// </summary>
    [IsoId("_TwPVcdp-Ed-ak6NoX_4Aeg_-10344762")]
    [DisplayName("Financial Instrument Identification")]
    [IsoXmlTag("FinInstrmId")]
    public SecurityIdentification11? FinancialInstrumentIdentification { get; init; } 
    
    /// <summary>
    /// Quantity of financial instrument concerned by the settlement condition modification request.
    /// </summary>
    [IsoId("_TwPVctp-Ed-ak6NoX_4Aeg_-374438073")]
    [DisplayName("Quantity")]
    [IsoXmlTag("Qty")]
    public FinancialInstrumentQuantity1Choice_? Quantity { get; init; } 
    
    /// <summary>
    /// Date/time when the request should take effect.
    /// </summary>
    [IsoId("_TwPVc9p-Ed-ak6NoX_4Aeg_472501435")]
    [DisplayName("Effective Date")]
    [IsoXmlTag("FctvDt")]
    public DateAndDateTimeChoice_? EffectiveDate { get; init; } 
    
    /// <summary>
    /// Date/time when the request should cease to be in effect.
    /// </summary>
    [IsoId("_TwPVdNp-Ed-ak6NoX_4Aeg_512210048")]
    [DisplayName("Expiry Date")]
    [IsoXmlTag("XpryDt")]
    public DateAndDateTimeChoice_? ExpiryDate { get; init; } 
    
    /// <summary>
    /// Date/time of the release.
    /// </summary>
    [IsoId("_TwPVddp-Ed-ak6NoX_4Aeg_743093025")]
    [DisplayName("Cut Off Date")]
    [IsoXmlTag("CutOffDt")]
    public DateAndDateTimeChoice_? CutOffDate { get; init; } 
    
    /// <summary>
    /// Party, either an individual or organisation, whose assets are being invested.
    /// </summary>
    [IsoId("_TwPVdtp-Ed-ak6NoX_4Aeg_970021962")]
    [DisplayName("Investor")]
    [IsoXmlTag("Invstr")]
    public PartyIdentification10Choice_? Investor { get; init; } 
    
    /// <summary>
    /// Party that, in a settlement chain interacts with the depository.
    /// </summary>
    [IsoId("_TwPVd9p-Ed-ak6NoX_4Aeg_-1919308161")]
    [DisplayName("Delivering Party")]
    [IsoXmlTag("DlvrgPty1")]
    public PartyIdentificationAndAccount16? DeliveringParty1 { get; init; } 
    
    /// <summary>
    /// Party that, in a settlement chain interacts with the depository.
    /// </summary>
    [IsoId("_TwPVeNp-Ed-ak6NoX_4Aeg_2017553355")]
    [DisplayName("Receiving Party")]
    [IsoXmlTag("RcvgPty1")]
    public PartyIdentificationAndAccount16? ReceivingParty1 { get; init; } 
    
    
    #nullable disable
    
}
