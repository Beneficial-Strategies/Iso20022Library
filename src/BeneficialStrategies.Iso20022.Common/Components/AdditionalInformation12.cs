// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Additional specific modification criteria.
/// </summary>
[IsoId("_6HUmz5NLEeWGlc8L7oPDIg")]
[DisplayName("Additional Information")]
public record AdditionalInformation12
{
    /// <summary>
    /// Identification of the transaction as known by the account owner. Will be used in a unilateral split to provide the executing party with the account owner identification of each split transaction.
    /// </summary>
    [IsoId("_6HUm1ZNLEeWGlc8L7oPDIg")]
    [DisplayName("Account Owner Transaction Identification")]
    [IsoXmlTag("AcctOwnrTxId")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax16Text)]
    [StringLength(maximumLength: 16, MinimumLength = 1)]
    public IsoRestrictedFINXMax16Text? AccountOwnerTransactionIdentification { get; init; }

    /// <summary>
    /// Type of instrument involved in the transactions on which the modification request should apply.
    /// </summary>
    [IsoId("_6HUm3ZNLEeWGlc8L7oPDIg")]
    [DisplayName("Classification Type")]
    [IsoXmlTag("ClssfctnTp")]
    public ClassificationType33Choice_? ClassificationType { get; init; }

    /// <summary>
    /// Account to or from which a securities entry is made.
    /// </summary>
    [IsoId("_6HUm4ZNLEeWGlc8L7oPDIg")]
    [DisplayName("Safekeeping Account")]
    [IsoXmlTag("SfkpgAcct")]
    public SecuritiesAccount30? SafekeepingAccount { get; init; }

    /// <summary>
    /// Identification of the financial instrument involved in the transactions on which the modification request should apply.
    /// </summary>
    [IsoId("_6HUm5ZNLEeWGlc8L7oPDIg")]
    [DisplayName("Financial Instrument Identification")]
    [IsoXmlTag("FinInstrmId")]
    public SecurityIdentification20? FinancialInstrumentIdentification { get; init; }

    /// <summary>
    /// Quantity of financial instrument concerned by the settlement condition modification request.
    /// </summary>
    [IsoId("_6HUm6ZNLEeWGlc8L7oPDIg")]
    [DisplayName("Quantity")]
    [IsoXmlTag("Qty")]
    public FinancialInstrumentQuantity15Choice_? Quantity { get; init; }

    /// <summary>
    /// Date/time when the request should take effect.
    /// </summary>
    [IsoId("_6HUm7ZNLEeWGlc8L7oPDIg")]
    [DisplayName("Effective Date")]
    [IsoXmlTag("FctvDt")]
    public DateAndDateTimeChoice_? EffectiveDate { get; init; }

    /// <summary>
    /// Date/time when the request should cease to be in effect.
    /// </summary>
    [IsoId("_6HUm8ZNLEeWGlc8L7oPDIg")]
    [DisplayName("Expiry Date")]
    [IsoXmlTag("XpryDt")]
    public DateAndDateTimeChoice_? ExpiryDate { get; init; }

    /// <summary>
    /// Date/time of the release.
    /// </summary>
    [IsoId("_6HUm9ZNLEeWGlc8L7oPDIg")]
    [DisplayName("Cut Off Date")]
    [IsoXmlTag("CutOffDt")]
    public DateAndDateTimeChoice_? CutOffDate { get; init; }

    /// <summary>
    /// Party, either an individual or organisation, whose assets are being invested.
    /// </summary>
    [IsoId("_6HUm-ZNLEeWGlc8L7oPDIg")]
    [DisplayName("Investor")]
    [IsoXmlTag("Invstr")]
    public PartyIdentification111? Investor { get; init; }

    /// <summary>
    /// Party that, in a settlement chain interacts with the depository.
    /// </summary>
    [IsoId("_6HUm_ZNLEeWGlc8L7oPDIg")]
    [DisplayName("Delivering Party")]
    [IsoXmlTag("DlvrgPty1")]
    public PartyIdentificationAndAccount146? DeliveringParty1 { get; init; }

    /// <summary>
    /// Party that, in a settlement chain interacts with the depository.
    /// </summary>
    [IsoId("_6HUnAZNLEeWGlc8L7oPDIg")]
    [DisplayName("Receiving Party")]
    [IsoXmlTag("RcvgPty1")]
    public PartyIdentificationAndAccount146? ReceivingParty1 { get; init; }

    /// <summary>
    /// Provides details on the processing status of the transaction.
    /// </summary>
    [IsoId("_6HUnBZNLEeWGlc8L7oPDIg")]
    [DisplayName("Processing Status")]
    [IsoXmlTag("PrcgSts")]
    public ProcessingStatus59Choice_? ProcessingStatus { get; init; }
}
