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
[IsoId("_YoyEkSzREeOsiuMH68so7Q")]
[DisplayName("Additional Information")]
public record AdditionalInformation9
{
    /// <summary>
    /// Identification of the transaction as known by the account owner. Will be used in a unilateral split to provide the executing party with the account owner identification of each split transaction.
    /// </summary>
    [IsoId("_ZBCMiyzREeOsiuMH68so7Q")]
    [DisplayName("Account Owner Transaction Identification")]
    [IsoXmlTag("AcctOwnrTxId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? AccountOwnerTransactionIdentification { get; init; }

    /// <summary>
    /// Type of instrument involved in the transactions on which the modification request should apply.
    /// </summary>
    [IsoId("_ZBCMnyzREeOsiuMH68so7Q")]
    [DisplayName("Classification Type")]
    [IsoXmlTag("ClssfctnTp")]
    public ClassificationType1Choice_? ClassificationType { get; init; }

    /// <summary>
    /// Account to or from which a securities entry is made.
    /// </summary>
    [IsoId("_ZBCMpyzREeOsiuMH68so7Q")]
    [DisplayName("Safekeeping Account")]
    [IsoXmlTag("SfkpgAcct")]
    public SecuritiesAccount13? SafekeepingAccount { get; init; }

    /// <summary>
    /// Identification of the financial instrument involved in the transactions on which the modification request should apply.
    /// </summary>
    [IsoId("_ZBCMryzREeOsiuMH68so7Q")]
    [DisplayName("Financial Instrument Identification")]
    [IsoXmlTag("FinInstrmId")]
    public SecurityIdentification14? FinancialInstrumentIdentification { get; init; }

    /// <summary>
    /// Quantity of financial instrument concerned by the settlement condition modification request.
    /// </summary>
    [IsoId("_ZBCMtyzREeOsiuMH68so7Q")]
    [DisplayName("Quantity")]
    [IsoXmlTag("Qty")]
    public FinancialInstrumentQuantity1Choice_? Quantity { get; init; }

    /// <summary>
    /// Date/time when the request should take effect.
    /// </summary>
    [IsoId("_ZBCMvyzREeOsiuMH68so7Q")]
    [DisplayName("Effective Date")]
    [IsoXmlTag("FctvDt")]
    public DateAndDateTimeChoice_? EffectiveDate { get; init; }

    /// <summary>
    /// Date/time when the request should cease to be in effect.
    /// </summary>
    [IsoId("_ZBCMxyzREeOsiuMH68so7Q")]
    [DisplayName("Expiry Date")]
    [IsoXmlTag("XpryDt")]
    public DateAndDateTimeChoice_? ExpiryDate { get; init; }

    /// <summary>
    /// Date/time of the release.
    /// </summary>
    [IsoId("_ZBCMzyzREeOsiuMH68so7Q")]
    [DisplayName("Cut Off Date")]
    [IsoXmlTag("CutOffDt")]
    public DateAndDateTimeChoice_? CutOffDate { get; init; }

    /// <summary>
    /// Party, either an individual or organisation, whose assets are being invested.
    /// </summary>
    [IsoId("_ZBCM1yzREeOsiuMH68so7Q")]
    [DisplayName("Investor")]
    [IsoXmlTag("Invstr")]
    public PartyIdentification43Choice_? Investor { get; init; }

    /// <summary>
    /// Party that, in a settlement chain interacts with the depository.
    /// </summary>
    [IsoId("_ZBCM3yzREeOsiuMH68so7Q")]
    [DisplayName("Delivering Party")]
    [IsoXmlTag("DlvrgPty1")]
    public PartyIdentificationAndAccount43? DeliveringParty1 { get; init; }

    /// <summary>
    /// Party that, in a settlement chain interacts with the depository.
    /// </summary>
    [IsoId("_ZBCM5yzREeOsiuMH68so7Q")]
    [DisplayName("Receiving Party")]
    [IsoXmlTag("RcvgPty1")]
    public PartyIdentificationAndAccount43? ReceivingParty1 { get; init; }

    /// <summary>
    /// Provides details on the processing status of the transaction.
    /// </summary>
    [IsoId("_uVaT0Cz3EeOsiuMH68so7Q")]
    [DisplayName("Processing Status")]
    [IsoXmlTag("PrcgSts")]
    public ProcessingStatus39Choice_? ProcessingStatus { get; init; }
}
