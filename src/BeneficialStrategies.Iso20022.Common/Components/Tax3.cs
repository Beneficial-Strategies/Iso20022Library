// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Amount of money due to the government or tax authority, according to various pre-defined parameters such as thresholds or income.
/// </summary>
[IsoId("_U5HCC9p-Ed-ak6NoX_4Aeg_-556148948")]
[DisplayName("Tax")]
public record Tax3
{
    /// <summary>
    /// Type of tax applied.
    /// </summary>
    [IsoId("_U5HCDNp-Ed-ak6NoX_4Aeg_1191154640")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required TaxTypeFormat2Choice_ Type { get; init; }

    /// <summary>
    /// Amount of money resulting from the calculation of the tax.
    /// </summary>
    [IsoId("_U5QL8Np-Ed-ak6NoX_4Aeg_1191154580")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ActiveOrHistoricCurrencyAnd13DecimalAmount Amount { get; init; }

    /// <summary>
    /// Basis used to determine the capital gain or loss, eg, the purchase price.
    /// </summary>
    [IsoId("_U5QL8dp-Ed-ak6NoX_4Aeg_1207062701")]
    [DisplayName("Basis")]
    [IsoXmlTag("Bsis")]
    public TaxationBasis2Code? Basis { get; init; }

    /// <summary>
    /// Party that receives the tax. The recipient of, and the party entitled to, the tax may be two different parties.
    /// </summary>
    [IsoId("_U5QL8tp-Ed-ak6NoX_4Aeg_1207062821")]
    [DisplayName("Recipient Identification")]
    [IsoXmlTag("RcptId")]
    public PartyIdentification1Choice_? RecipientIdentification { get; init; }

    /// <summary>
    /// Indicates whether a tax exemption applies.
    /// </summary>
    [IsoId("_U5QL89p-Ed-ak6NoX_4Aeg_1207062761")]
    [DisplayName("Exemption Indicator")]
    [IsoXmlTag("XmptnInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator ExemptionIndicator { get; init; }

    /// <summary>
    /// Reason for a tax exemption.
    /// </summary>
    [IsoId("_U5QL9Np-Ed-ak6NoX_4Aeg_1207063147")]
    [DisplayName("Exemption Reason")]
    [IsoXmlTag("XmptnRsn")]
    public TaxExemptionReasonFormatChoice_? ExemptionReason { get; init; }
}
