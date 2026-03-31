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
[IsoId("_B3YZgYf_EeevKP8c-ilVhA")]
[DisplayName("Financial Instrument")]
public record FinancialInstrument63
{
    /// <summary>
    /// Identification of a security by an ISIN.
    /// </summary>
    [IsoId("_CJFNhYf_EeevKP8c-ilVhA")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required SecurityIdentification25Choice_ Identification { get; init; }

    /// <summary>
    /// Name of the financial instrument in free format text.
    /// </summary>
    [IsoId("_CJFNh4f_EeevKP8c-ilVhA")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? Name { get; init; }

    /// <summary>
    /// Financial Instrument Short Name (FISN) expressed in conformance with the ISO 18774 standard.
    /// </summary>
    [IsoId("_CJFNj4f_EeevKP8c-ilVhA")]
    [DisplayName("Short Name")]
    [IsoXmlTag("ShrtNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ShortName { get; init; }

    /// <summary>
    /// Additional information about the financial instrument.
    /// </summary>
    [IsoId("_CJFNkYf_EeevKP8c-ilVhA")]
    [DisplayName("Supplementary Identification")]
    [IsoXmlTag("SplmtryId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? SupplementaryIdentification { get; init; }

    /// <summary>
    /// Features of units offered by a fund. For example, a unit may have a specific load structure, for example, front end or back end, an income policy, for example, pay out or accumulate, or a trailer policy, for example, with or without. Fund classes are typically denoted by a single character, for example, &apos;Class A&apos;, &apos;Class 2&apos;.
    /// </summary>
    [IsoId("_CJFNk4f_EeevKP8c-ilVhA")]
    [DisplayName("Class Type")]
    [IsoXmlTag("ClssTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ClassType { get; init; }

    /// <summary>
    /// Form, that is, ownership, of the security, that is, registered or bearer.
    /// </summary>
    [IsoId("_CJFNlYf_EeevKP8c-ilVhA")]
    [DisplayName("Securities Form")]
    [IsoXmlTag("SctiesForm")]
    public FormOfSecurity1Code? SecuritiesForm { get; init; }

    /// <summary>
    /// Income policy relating to a class type, that is, if income is paid out or retained in the fund.
    /// </summary>
    [IsoId("_CJFNnYf_EeevKP8c-ilVhA")]
    [DisplayName("Distribution Policy")]
    [IsoXmlTag("DstrbtnPlcy")]
    public DistributionPolicy1Code? DistributionPolicy { get; init; }
}
