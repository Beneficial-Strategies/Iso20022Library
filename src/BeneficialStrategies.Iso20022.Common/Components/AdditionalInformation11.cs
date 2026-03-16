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
[IsoId("_qkGGOx5hEeWE3PufGMdJ3w")]
[DisplayName("Additional Information")]
public record AdditionalInformation11
{
    /// <summary>
    /// Identification of the transaction as known by the account owner. Will be used in a unilateral split to provide the executing party with the account owner identification of each split transaction.
    /// </summary>
    [IsoId("_rDfXuR5hEeWE3PufGMdJ3w")]
    [DisplayName("Account Owner Transaction Identification")]
    [IsoXmlTag("AcctOwnrTxId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? AccountOwnerTransactionIdentification { get; init; }

    /// <summary>
    /// Type of instrument involved in the transactions on which the modification request should apply.
    /// </summary>
    [IsoId("_rDfXwR5hEeWE3PufGMdJ3w")]
    [DisplayName("Classification Type")]
    [IsoXmlTag("ClssfctnTp")]
    public ClassificationType32Choice_? ClassificationType { get; init; }

    /// <summary>
    /// Account to or from which a securities entry is made.
    /// </summary>
    [IsoId("_rDfXxR5hEeWE3PufGMdJ3w")]
    [DisplayName("Safekeeping Account")]
    [IsoXmlTag("SfkpgAcct")]
    public SecuritiesAccount19? SafekeepingAccount { get; init; }

    /// <summary>
    /// Identification of the financial instrument involved in the transactions on which the modification request should apply.
    /// </summary>
    [IsoId("_rDfXyR5hEeWE3PufGMdJ3w")]
    [DisplayName("Financial Instrument Identification")]
    [IsoXmlTag("FinInstrmId")]
    public SecurityIdentification19? FinancialInstrumentIdentification { get; init; }

    /// <summary>
    /// Quantity of financial instrument concerned by the settlement condition modification request.
    /// </summary>
    [IsoId("_rDfXzR5hEeWE3PufGMdJ3w")]
    [DisplayName("Quantity")]
    [IsoXmlTag("Qty")]
    public FinancialInstrumentQuantity1Choice_? Quantity { get; init; }

    /// <summary>
    /// Date/time when the request should take effect.
    /// </summary>
    [IsoId("_rDfX0R5hEeWE3PufGMdJ3w")]
    [DisplayName("Effective Date")]
    [IsoXmlTag("FctvDt")]
    public DateAndDateTimeChoice_? EffectiveDate { get; init; }

    /// <summary>
    /// Date/time when the request should cease to be in effect.
    /// </summary>
    [IsoId("_rDfX1R5hEeWE3PufGMdJ3w")]
    [DisplayName("Expiry Date")]
    [IsoXmlTag("XpryDt")]
    public DateAndDateTimeChoice_? ExpiryDate { get; init; }

    /// <summary>
    /// Date/time of the release.
    /// </summary>
    [IsoId("_rDfX2R5hEeWE3PufGMdJ3w")]
    [DisplayName("Cut Off Date")]
    [IsoXmlTag("CutOffDt")]
    public DateAndDateTimeChoice_? CutOffDate { get; init; }

    /// <summary>
    /// Party, either an individual or organisation, whose assets are being invested.
    /// </summary>
    [IsoId("_rDfX3R5hEeWE3PufGMdJ3w")]
    [DisplayName("Investor")]
    [IsoXmlTag("Invstr")]
    public PartyIdentification100? Investor { get; init; }

    /// <summary>
    /// Party that, in a settlement chain interacts with the depository.
    /// </summary>
    [IsoId("_rDfX4R5hEeWE3PufGMdJ3w")]
    [DisplayName("Delivering Party")]
    [IsoXmlTag("DlvrgPty1")]
    public PartyIdentificationAndAccount117? DeliveringParty1 { get; init; }

    /// <summary>
    /// Party that, in a settlement chain interacts with the depository.
    /// </summary>
    [IsoId("_rDfX5R5hEeWE3PufGMdJ3w")]
    [DisplayName("Receiving Party")]
    [IsoXmlTag("RcvgPty1")]
    public PartyIdentificationAndAccount117? ReceivingParty1 { get; init; }

    /// <summary>
    /// Provides details on the processing status of the transaction.
    /// </summary>
    [IsoId("_rDfX6R5hEeWE3PufGMdJ3w")]
    [DisplayName("Processing Status")]
    [IsoXmlTag("PrcgSts")]
    public ProcessingStatus56Choice_? ProcessingStatus { get; init; }
}
