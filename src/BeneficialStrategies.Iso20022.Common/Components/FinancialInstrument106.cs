// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Security that is a sub-set of an investment fund, and is governed by the same investment fund policy.
/// </summary>
[IsoId("125e4d7a-152a-446e-ae78-566434a31ae1")]
[DisplayName("Financial Instrument106")]
public record FinancialInstrument106
{
    /// <summary>
    /// Identification of a security by an ISIN.
    /// </summary>
    [IsoId("f65ccf05-19de-402e-b9e8-576814d05beb")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [MinLength(1)]
    public ValueList<SecurityIdentification46Choice_> Identification { get; init; } = [];

    /// <summary>
    /// Name of the financial instrument in free format text.
    /// </summary>
    [IsoId("63415e65-e8c5-4228-8b56-b82f354331ae")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    public IsoMax350Text? Name { get; init; }

    /// <summary>
    /// Financial Instrument Short Name (FISN) expressed in conformance with the ISO 18774 standard.
    /// </summary>
    [IsoId("0edf31fe-cca2-488e-a56c-a3d8b2e5a727")]
    [DisplayName("Short Name")]
    [IsoXmlTag("ShrtNm")]
    public IsoMax35Text? ShortName { get; init; }

    /// <summary>
    /// Additional information about a financial instrument to help identify the instrument.
    /// </summary>
    [IsoId("31646637-279d-4810-9738-949b207fcabf")]
    [DisplayName("Supplementary Identification")]
    [IsoXmlTag("SplmtryId")]
    public IsoMax35Text? SupplementaryIdentification { get; init; }

    /// <summary>
    /// Currency in which a security is issued or redenominated.
    /// </summary>
    [IsoId("412ef5c4-dee6-406a-9ec5-54be7f1aace1")]
    [DisplayName("Denomination Currency")]
    [IsoXmlTag("DnmtnCcy")]
    public ActiveOrHistoricCurrencyCode? DenominationCurrency { get; init; }

    /// <summary>
    /// Features of units offered by a fund.
    /// </summary>
    [IsoId("34c89cd1-d2a5-43b6-a1e1-7565cdd37a09")]
    [DisplayName("Class Type")]
    [IsoXmlTag("ClssTp")]
    public IsoMax35Text? ClassType { get; init; }

    /// <summary>
    /// Form, that is, ownership, of the security.
    /// </summary>
    [IsoId("6b32a240-b7f6-49c8-9da0-7e04af205f88")]
    [DisplayName("Securities Form")]
    [IsoXmlTag("SctiesForm")]
    public FormOfSecurity1Code? SecuritiesForm { get; init; }

    /// <summary>
    /// Income policy relating to a class type.
    /// </summary>
    [IsoId("7eb0b129-9be0-4a83-9e04-1ab164c84473")]
    [DisplayName("Distribution Policy")]
    [IsoXmlTag("DstrbtnPlcy")]
    public DistributionPolicy1Code? DistributionPolicy { get; init; }

    /// <summary>
    /// Indicates whether the fund has two prices.
    /// </summary>
    [IsoId("2e38e21d-63bb-4e28-9cff-097144bf2b4e")]
    [DisplayName("Dual Fund Indicator")]
    [IsoXmlTag("DualFndInd")]
    public required IsoYesNoIndicator DualFundIndicator { get; init; }

    /// <summary>
    /// Company specific description of a group of funds.
    /// </summary>
    [IsoId("be22437d-5338-4c13-b168-01e37cf53a41")]
    [DisplayName("Product Group")]
    [IsoXmlTag("PdctGrp")]
    public IsoMax140Text? ProductGroup { get; init; }

    /// <summary>
    /// Source of the identification, that is, domestic (national) or proprietary.
    /// </summary>
    [IsoId("a232b3b6-d578-42a1-ae2d-7ca471ef7c26")]
    [DisplayName("Series Identification")]
    [IsoXmlTag("SrsId")]
    public Series1? SeriesIdentification { get; init; }
}
