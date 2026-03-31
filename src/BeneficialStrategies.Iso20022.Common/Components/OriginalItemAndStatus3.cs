// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identifies the original notification item and to provide the status.
/// </summary>
[IsoId("_tBBOtFkyEeGeoaLUQk__nA_1755686524")]
[DisplayName("Original Item And Status")]
public record OriginalItemAndStatus3
{
    /// <summary>
    /// Identification of the original notification item.
    /// </summary>
    [IsoId("_tBKYoFkyEeGeoaLUQk__nA_1917816055")]
    [DisplayName("Original Item Identification")]
    [IsoXmlTag("OrgnlItmId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text OriginalItemIdentification { get; init; }

    /// <summary>
    /// Unique identification as assigned by the debtor to unambiguously identify the original underlying transaction to the creditor.
    /// </summary>
    [IsoId("_tBKYoVkyEeGeoaLUQk__nA_1906717278")]
    [DisplayName("Original End To End Identification")]
    [IsoXmlTag("OrgnlEndToEndId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OriginalEndToEndIdentification { get; init; }

    /// <summary>
    /// Amount of money expected to be credited to the account, as per the original notification to receive.
    /// </summary>
    [IsoId("_tBKYolkyEeGeoaLUQk__nA_-1337116946")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ActiveOrHistoricCurrencyAndAmount Amount { get; init; }

    /// <summary>
    /// Value date on which the account was expected to be credited.
    /// </summary>
    [IsoId("_tBKYo1kyEeGeoaLUQk__nA_1450197645")]
    [DisplayName("Expected Value Date")]
    [IsoXmlTag("XpctdValDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? ExpectedValueDate { get; init; }

    /// <summary>
    /// Specifies the status of the notification item.
    /// </summary>
    [IsoId("_tBUJoFkyEeGeoaLUQk__nA_1823103368")]
    [DisplayName("Item Status")]
    [IsoXmlTag("ItmSts")]
    public required NotificationStatus3Code ItemStatus { get; init; }

    /// <summary>
    /// Further details of the item status.
    /// </summary>
    [IsoId("_tFyZ8FkyEeGeoaLUQk__nA_-2089239349")]
    [DisplayName("Additional Status Information")]
    [IsoXmlTag("AddtlStsInf")]
    [IsoSimpleType(IsoSimpleType.Max105Text)]
    [StringLength(maximumLength: 105, MinimumLength = 1)]
    public IsoMax105Text? AdditionalStatusInformation { get; init; }

    /// <summary>
    /// Provides further information in order to identify a previous payment notification.
    /// </summary>
    [IsoId("_tF7j4FkyEeGeoaLUQk__nA_-1150355524")]
    [DisplayName("Original Item Reference")]
    [IsoXmlTag("OrgnlItmRef")]
    public OriginalItemReference2? OriginalItemReference { get; init; }
}
