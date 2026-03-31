// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Context22.
/// </summary>
[IsoId("_cJRaIX5TEe6YlIMyoxWMJA")]
[DisplayName("Context22")]
public record Context22
{
    /// <summary>
    /// Additional Data.
    /// </summary>
    [DisplayName("Additional Data")]
    [IsoXmlTag("AddtlData")]
    public ValueList<AdditionalData1> AdditionalData { get; init; } = [];

    /// <summary>
    /// Delayed Charges.
    /// </summary>
    [DisplayName("Delayed Charges")]
    [IsoXmlTag("DelydChrgs")]
    public IsoTrueFalseIndicator? DelayedCharges { get; init; }

    /// <summary>
    /// Merchant Category Code.
    /// </summary>
    [DisplayName("Merchant Category Code")]
    [IsoXmlTag("MrchntCtgyCd")]
    public ISO18245MerchantCategoryCode? MerchantCategoryCode { get; init; }

    /// <summary>
    /// Merchant Category Specific Data.
    /// </summary>
    [DisplayName("Merchant Category Specific Data")]
    [IsoXmlTag("MrchntCtgySpcfcData")]
    public IsoMax35Text? MerchantCategorySpecificData { get; init; }

    /// <summary>
    /// No Show.
    /// </summary>
    [DisplayName("No Show")]
    [IsoXmlTag("NoShow")]
    public IsoTrueFalseIndicator? NoShow { get; init; }

    /// <summary>
    /// Other Merchant Category.
    /// </summary>
    [DisplayName("Other Merchant Category")]
    [IsoXmlTag("OthrMrchntCtgy")]
    public IsoMax35Text? OtherMerchantCategory { get; init; }

    /// <summary>
    /// Partial Shipment.
    /// </summary>
    [DisplayName("Partial Shipment")]
    [IsoXmlTag("PrtlShipmnt")]
    public IsoTrueFalseIndicator? PartialShipment { get; init; }

    /// <summary>
    /// Reauthorisation.
    /// </summary>
    [DisplayName("Reauthorisation")]
    [IsoXmlTag("Reauthstn")]
    public IsoTrueFalseIndicator? Reauthorisation { get; init; }

    /// <summary>
    /// Re Submission.
    /// </summary>
    [DisplayName("Re Submission")]
    [IsoXmlTag("ReSubmissn")]
    public IsoTrueFalseIndicator? ReSubmission { get; init; }

    /// <summary>
    /// Transaction Initiator.
    /// </summary>
    [DisplayName("Transaction Initiator")]
    [IsoXmlTag("TxInitr")]
    public TransactionInitiator1Code? TransactionInitiator { get; init; }
}
