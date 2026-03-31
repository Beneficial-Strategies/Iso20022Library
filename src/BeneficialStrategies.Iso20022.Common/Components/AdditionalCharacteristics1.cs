// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Contains additional characteristics of addendum data.
/// </summary>
[IsoId("_IocXk_JZEeiJn9rM2Znz2w")]
[DisplayName("Additional Characteristics")]
public record AdditionalCharacteristics1
{
    /// <summary>
    /// Identifies the specific classification or type of business.
    /// </summary>
    [IsoId("_IocXlPJZEeiJn9rM2Znz2w")]
    [DisplayName("Business Type")]
    [IsoXmlTag("BizTp")]
    public AdditionalCharacteristicDetails1? BusinessType { get; init; }

    /// <summary>
    /// Identifies specific characteristics about the
    /// business owner.
    /// </summary>
    [IsoId("_IocXlfJZEeiJn9rM2Znz2w")]
    [DisplayName("Owner")]
    [IsoXmlTag("Ownr")]
    public AdditionalCharacteristicDetails1? Owner { get; init; }

    /// <summary>
    /// Identifies specific characteristics about the business certification type, such as small business, disadvantaged, or other certification type.
    /// </summary>
    [IsoId("_fs81AfJZEeiJn9rM2Znz2w")]
    [DisplayName("Certification")]
    [IsoXmlTag("Certfctn")]
    public AdditionalCharacteristicDetails1? Certification { get; init; }

    /// <summary>
    /// Identifies the racial or ethnic type of
    /// the majority owner of the business.
    /// </summary>
    [IsoId("_gHCI8fJZEeiJn9rM2Znz2w")]
    [DisplayName("Owner Ethnicity")]
    [IsoXmlTag("OwnrEthncty")]
    public AdditionalCharacteristicDetails1? OwnerEthnicity { get; init; }
}
