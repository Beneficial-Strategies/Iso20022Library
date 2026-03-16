// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Previous employment information.
/// </summary>
[IsoId("_YJCEAHzpEeuEHsEB8Johfw")]
[DisplayName("Employment Details")]
public record EmploymentDetails1
{
    /// <summary>
    /// Current tax code.
    /// </summary>
    [IsoId("_vkTboXzpEeuEHsEB8Johfw")]
    [DisplayName("Tax Code")]
    [IsoXmlTag("TaxCd")]
    public GenericIdentification36? TaxCode { get; init; }

    /// <summary>
    /// Indicates whether or not another tax code exists.
    /// </summary>
    [IsoId("_2hDV4HzqEeuEHsEB8Johfw")]
    [DisplayName("Other Tax Code Indicator")]
    [IsoXmlTag("OthrTaxCdInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? OtherTaxCodeIndicator { get; init; }

    /// <summary>
    /// Indicates whether tax is cumulative or non-cumulative. In the UK, this is known as the W1M1 indicator.
    /// </summary>
    [IsoId("_8YYLEHzpEeuEHsEB8Johfw")]
    [DisplayName("Cumulative Tax Indicator")]
    [IsoXmlTag("CmltvTaxInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? CumulativeTaxIndicator { get; init; }

    /// <summary>
    /// Amount of the previous pay.
    /// </summary>
    [IsoId("_D_1EoHzqEeuEHsEB8Johfw")]
    [DisplayName("Previous Pay")]
    [IsoXmlTag("PrvsPay")]
    public ActiveCurrencyAndAmount? PreviousPay { get; init; }

    /// <summary>
    /// Amount of the previous tax.
    /// </summary>
    [IsoId("_Hg2UUHzqEeuEHsEB8Johfw")]
    [DisplayName("Previous Tax")]
    [IsoXmlTag("PrvsTax")]
    public ActiveCurrencyAndAmount? PreviousTax { get; init; }

    /// <summary>
    /// Start date of the employment period.
    /// </summary>
    [IsoId("_KV09YHzqEeuEHsEB8Johfw")]
    [DisplayName("Start Date")]
    [IsoXmlTag("StartDt")]
    public DateFormat42Choice_? StartDate { get; init; }

    /// <summary>
    /// End date of the employment period.
    /// </summary>
    [IsoId("_ydy70HzqEeuEHsEB8Johfw")]
    [DisplayName("End Date")]
    [IsoXmlTag("EndDt")]
    public DateFormat42Choice_? EndDate { get; init; }

    /// <summary>
    /// Additional information about the employment.
    /// </summary>
    [IsoId("_9IAbwHzqEeuEHsEB8Johfw")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public ValueList<AdditionalInformation15> AdditionalInformation { get; init; } = [];
}
