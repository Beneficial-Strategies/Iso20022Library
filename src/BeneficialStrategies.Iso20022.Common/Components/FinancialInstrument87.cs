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
[IsoId("_O07nJ5S8EemqYPWMBuVawg")]
[DisplayName("Financial Instrument")]
public record FinancialInstrument87
{
    /// <summary>
    /// Identification of the security by an ISIN.
    /// </summary>
    [IsoId("_PI3PxZS8EemqYPWMBuVawg")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required SecurityIdentification25Choice_ Identification { get; init; }

    /// <summary>
    /// Name of the financial instrument in free format text.
    /// </summary>
    [IsoId("_PI3Px5S8EemqYPWMBuVawg")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? Name { get; init; }

    /// <summary>
    /// Financial Instrument Short Name (FISN) expressed in conformance with the ISO 18774 standard.
    /// </summary>
    [IsoId("_PI3Pz5S8EemqYPWMBuVawg")]
    [DisplayName("Short Name")]
    [IsoXmlTag("ShrtNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ShortName { get; init; }

    /// <summary>
    /// Additional information about the financial instrument to help identify the instrument.
    /// </summary>
    [IsoId("_PI3P0ZS8EemqYPWMBuVawg")]
    [DisplayName("Supplementary Identification")]
    [IsoXmlTag("SplmtryId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? SupplementaryIdentification { get; init; }

    /// <summary>
    /// Features of units offered by the fund. For example, a unit may have a specific load structure, for example, front end or back end, an income policy, for example, pay out or accumulate, or a trailer policy, for example, with or without. Fund classes are typically denoted by a single character, for example, &apos;Class A&apos;, &apos;Class 2&apos;.
    /// </summary>
    [IsoId("_PI3P05S8EemqYPWMBuVawg")]
    [DisplayName("Class Type")]
    [IsoXmlTag("ClssTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ClassType { get; init; }

    /// <summary>
    /// Form, that is, ownership, of the security, that is, registered or bearer.
    /// </summary>
    [IsoId("_PI3P1ZS8EemqYPWMBuVawg")]
    [DisplayName("Securities Form")]
    [IsoXmlTag("SctiesForm")]
    public FormOfSecurity1Code? SecuritiesForm { get; init; }

    /// <summary>
    /// Income policy relating to the class type, that is, if income is paid out or retained in the fund.
    /// </summary>
    [IsoId("_PI3P3ZS8EemqYPWMBuVawg")]
    [DisplayName("Distribution Policy")]
    [IsoXmlTag("DstrbtnPlcy")]
    public DistributionPolicy1Code? DistributionPolicy { get; init; }

    /// <summary>
    /// Company specific description of a group of funds.
    /// </summary>
    [IsoId("_PI3P35S8EemqYPWMBuVawg")]
    [DisplayName("Product Group")]
    [IsoXmlTag("PdctGrp")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? ProductGroup { get; init; }

    /// <summary>
    /// When an account at fund or security level is blocked, this specifies details on how the holding is blocked.
    /// </summary>
    [IsoId("_PI3P4ZS8EemqYPWMBuVawg")]
    [DisplayName("Blocked Holding Details")]
    [IsoXmlTag("BlckdHldgDtls")]
    public BlockedHoldingDetails2? BlockedHoldingDetails { get; init; }

    /// <summary>
    /// Specifies whether the holdings in the account are eligible for pledging.
    /// </summary>
    [IsoId("_PI3P45S8EemqYPWMBuVawg")]
    [DisplayName("Pledging")]
    [IsoXmlTag("Pldgg")]
    public Eligible1Code? Pledging { get; init; }

    /// <summary>
    /// Specifies whether the holdings in the account are used as collateral.
    /// </summary>
    [IsoId("_PI3P5ZS8EemqYPWMBuVawg")]
    [DisplayName("Collateral")]
    [IsoXmlTag("Coll")]
    public Collateral1Code? Collateral { get; init; }

    /// <summary>
    /// Details of third party rights.
    /// </summary>
    [IsoId("_PI3P55S8EemqYPWMBuVawg")]
    [DisplayName("Third Party Rights")]
    [IsoXmlTag("ThrdPtyRghts")]
    public ThirdPartyRights2? ThirdPartyRights { get; init; }

    /// <summary>
    /// Specifies if all the shares are owned exclusively by the fund company.
    /// </summary>
    [IsoId("_PI3P6ZS8EemqYPWMBuVawg")]
    [DisplayName("Fund Ownership")]
    [IsoXmlTag("FndOwnrsh")]
    public FundOwnership1Code? FundOwnership { get; init; }

    /// <summary>
    /// Specifies if the fund is intended for qualified investors.
    /// </summary>
    [IsoId("_PI3P65S8EemqYPWMBuVawg")]
    [DisplayName("Fund Intention")]
    [IsoXmlTag("FndIntntn")]
    public FundIntention1Code? FundIntention { get; init; }

    /// <summary>
    /// Operational status of the fund.
    /// </summary>
    [IsoId("_PI3P7ZS8EemqYPWMBuVawg")]
    [DisplayName("Operational Status")]
    [IsoXmlTag("OprlSts")]
    public OperationalStatus1Code? OperationalStatus { get; init; }
}
