// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Security that is a sub-set of an investment fund, and is governed by the same investment fund policy, eg, dividend option or valuation currency.
/// </summary>
[IsoId("_VG0G0tp-Ed-ak6NoX_4Aeg_-2041666443")]
[DisplayName("Financial Instrument")]
public record FinancialInstrument3
{
    /// <summary>
    /// Identification of a security by an ISIN.
    /// </summary>
    [IsoId("_VG0G09p-Ed-ak6NoX_4Aeg_-1837566972")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required SecurityIdentification1Choice_ Identification { get; init; }

    /// <summary>
    /// Name of the financial instrument in free format text.
    /// </summary>
    [IsoId("_VG0G1Np-Ed-ak6NoX_4Aeg_-1837566937")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? Name { get; init; }

    /// <summary>
    /// Additional information about a financial instrument to help identify the instrument.
    /// </summary>
    [IsoId("_VG0G1dp-Ed-ak6NoX_4Aeg_605592417")]
    [DisplayName("Supplementary Identification")]
    [IsoXmlTag("SplmtryId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? SupplementaryIdentification { get; init; }

    /// <summary>
    /// Currency to be used for pricing the fund. This currency must be among the set of currencies in which the price may be expressed, as stated in the prospectus.
    /// </summary>
    [IsoId("_VG0G1tp-Ed-ak6NoX_4Aeg_-1564440567")]
    [DisplayName("Requested NAV Currency")]
    [IsoXmlTag("ReqdNAVCcy")]
    public ActiveOrHistoricCurrencyCode? RequestedNAVCurrency { get; init; }

    /// <summary>
    /// Features of units offered by a fund. For example, a unit may have a specific load structure, eg, front end or back end, an income policy, eg, pay out or accumulate, or a trailer policy, eg, with or without. Fund classes are typically denoted by a single character, eg, &apos;Class A&apos;, &apos;Class 2&apos;.
    /// </summary>
    [IsoId("_VG0G19p-Ed-ak6NoX_4Aeg_-93961271")]
    [DisplayName("Class Type")]
    [IsoXmlTag("ClssTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ClassType { get; init; }

    /// <summary>
    /// Form, ie, ownership, of the security, eg, registered or bearer.
    /// </summary>
    [IsoId("_VG0G2Np-Ed-ak6NoX_4Aeg_605592884")]
    [DisplayName("Securities Form")]
    [IsoXmlTag("SctiesForm")]
    public FormOfSecurity1Code? SecuritiesForm { get; init; }

    /// <summary>
    /// Income policy relating to a class type, ie, if income is paid out or retained in the fund.
    /// </summary>
    [IsoId("_VG0G2dp-Ed-ak6NoX_4Aeg_-88419001")]
    [DisplayName("Distribution Policy")]
    [IsoXmlTag("DstrbtnPlcy")]
    public DistributionPolicy1Code? DistributionPolicy { get; init; }
}
