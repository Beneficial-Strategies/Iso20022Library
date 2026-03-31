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
[IsoId("_ZmIZgY7HEeaa5_S8lsRKCQ")]
[DisplayName("Additional Information")]
public record AdditionalInformation13
{
    /// <summary>
    /// Identification of the transaction as known by the account owner. Will be used in a unilateral split to provide the executing party with the account owner identification of each split transaction.
    /// </summary>
    [IsoId("_Z0Q8JY7HEeaa5_S8lsRKCQ")]
    [DisplayName("Account Owner Transaction Identification")]
    [IsoXmlTag("AcctOwnrTxId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? AccountOwnerTransactionIdentification { get; init; }

    /// <summary>
    /// Type of instrument involved in the transactions on which the modification request should apply.
    /// </summary>
    [IsoId("_Z0Q8LY7HEeaa5_S8lsRKCQ")]
    [DisplayName("Classification Type")]
    [IsoXmlTag("ClssfctnTp")]
    public ClassificationType32Choice_? ClassificationType { get; init; }

    /// <summary>
    /// Account to or from which a securities entry is made.
    /// </summary>
    [IsoId("_Z0Q8MY7HEeaa5_S8lsRKCQ")]
    [DisplayName("Safekeeping Account")]
    [IsoXmlTag("SfkpgAcct")]
    public SecuritiesAccount19? SafekeepingAccount { get; init; }

    /// <summary>
    /// Identification of the financial instrument involved in the transactions on which the modification request should apply.
    /// </summary>
    [IsoId("_Z0Q8NY7HEeaa5_S8lsRKCQ")]
    [DisplayName("Financial Instrument Identification")]
    [IsoXmlTag("FinInstrmId")]
    public SecurityIdentification19? FinancialInstrumentIdentification { get; init; }

    /// <summary>
    /// Quantity of financial instrument concerned by the settlement condition modification request.
    /// </summary>
    [IsoId("_Z0Q8OY7HEeaa5_S8lsRKCQ")]
    [DisplayName("Quantity")]
    [IsoXmlTag("Qty")]
    public FinancialInstrumentQuantity1Choice_? Quantity { get; init; }

    /// <summary>
    /// Date/time when the request should take effect.
    /// </summary>
    [IsoId("_Z0Q8PY7HEeaa5_S8lsRKCQ")]
    [DisplayName("Effective Date")]
    [IsoXmlTag("FctvDt")]
    public DateAndDateTimeChoice_? EffectiveDate { get; init; }

    /// <summary>
    /// Date/time when the request should cease to be in effect.
    /// </summary>
    [IsoId("_Z0Q8QY7HEeaa5_S8lsRKCQ")]
    [DisplayName("Expiry Date")]
    [IsoXmlTag("XpryDt")]
    public DateAndDateTimeChoice_? ExpiryDate { get; init; }

    /// <summary>
    /// Date/time of the release.
    /// </summary>
    [IsoId("_Z0Q8RY7HEeaa5_S8lsRKCQ")]
    [DisplayName("Cut Off Date")]
    [IsoXmlTag("CutOffDt")]
    public DateAndDateTimeChoice_? CutOffDate { get; init; }

    /// <summary>
    /// Party, either an individual or organisation, whose assets are being invested.
    /// </summary>
    [IsoId("_Z0Q8SY7HEeaa5_S8lsRKCQ")]
    [DisplayName("Investor")]
    [IsoXmlTag("Invstr")]
    public PartyIdentification100? Investor { get; init; }

    /// <summary>
    /// Party that, in a settlement chain interacts with the depository.
    /// </summary>
    [IsoId("_Z0Q8TY7HEeaa5_S8lsRKCQ")]
    [DisplayName("Delivering Party")]
    [IsoXmlTag("DlvrgPty1")]
    public PartyIdentificationAndAccount117? DeliveringParty1 { get; init; }

    /// <summary>
    /// Party that, in a settlement chain interacts with the depository.
    /// </summary>
    [IsoId("_Z0Q8UY7HEeaa5_S8lsRKCQ")]
    [DisplayName("Receiving Party")]
    [IsoXmlTag("RcvgPty1")]
    public PartyIdentificationAndAccount117? ReceivingParty1 { get; init; }
}
