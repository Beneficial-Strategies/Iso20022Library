// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Security that is a sub-set of an investment fund, and is governed by the same investment fund policy, for example, dividend option or valuation currency.
/// </summary>
[IsoId("_ztdGYThREeaRwdGFv45qTQ")]
[DisplayName("Financial Instrument")]
public record FinancialInstrument57
{
    /// <summary>
    /// Identification of the security by an ISIN.
    /// </summary>
    [IsoId("_0FaTZThREeaRwdGFv45qTQ")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required SecurityIdentification25Choice_ Identification { get; init; }

    /// <summary>
    /// Name of the financial instrument in free format text.
    /// </summary>
    [IsoId("_0FaTZzhREeaRwdGFv45qTQ")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? Name { get; init; }

    /// <summary>
    /// Financial Instrument Short Name (FISN) expressed in conformance with the ISO 18774 standard.
    /// </summary>
    [IsoId("_cLkFUTlBEealR6-8aQ15BA")]
    [DisplayName("Short Name")]
    [IsoXmlTag("ShrtNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ShortName { get; init; }

    /// <summary>
    /// Additional information about the financial instrument to help identify the instrument.
    /// </summary>
    [IsoId("_0FaTbzhREeaRwdGFv45qTQ")]
    [DisplayName("Supplementary Identification")]
    [IsoXmlTag("SplmtryId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? SupplementaryIdentification { get; init; }

    /// <summary>
    /// Features of units offered by the fund. For example, a unit may have a specific load structure, for example, front end or back end, an income policy, for example, pay out or accumulate, or a trailer policy, for example, with or without. Fund classes are typically denoted by a single character, for example, &apos;Class A&apos;, &apos;Class 2&apos;.
    /// </summary>
    [IsoId("_0FaTcThREeaRwdGFv45qTQ")]
    [DisplayName("Class Type")]
    [IsoXmlTag("ClssTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ClassType { get; init; }

    /// <summary>
    /// Form, that is, ownership, of the security, for example, registered or bearer.
    /// </summary>
    [IsoId("_0FaTczhREeaRwdGFv45qTQ")]
    [DisplayName("Securities Form")]
    [IsoXmlTag("SctiesForm")]
    public FormOfSecurity1Code? SecuritiesForm { get; init; }

    /// <summary>
    /// Income policy relating to a class type, that is, if income is paid out or retained in the fund.
    /// </summary>
    [IsoId("_0FaTezhREeaRwdGFv45qTQ")]
    [DisplayName("Distribution Policy")]
    [IsoXmlTag("DstrbtnPlcy")]
    public DistributionPolicy1Code? DistributionPolicy { get; init; }

    /// <summary>
    /// Company specific description of a group of funds.
    /// </summary>
    [IsoId("_0FaTfThREeaRwdGFv45qTQ")]
    [DisplayName("Product Group")]
    [IsoXmlTag("PdctGrp")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? ProductGroup { get; init; }

    /// <summary>
    /// Choice of formats for the identification of a series.
    /// </summary>
    [IsoId("_VTdocEgQEea9YuSvQGoi-w")]
    [DisplayName("Series Identification")]
    [IsoXmlTag("SrsId")]
    public Series1? SeriesIdentification { get; init; }
}
