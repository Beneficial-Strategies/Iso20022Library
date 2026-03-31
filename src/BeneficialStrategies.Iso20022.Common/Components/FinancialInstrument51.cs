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
[IsoId("_xJQwByC6EeWPMvNwVtiMsA")]
[DisplayName("Financial Instrument")]
public record FinancialInstrument51
{
    /// <summary>
    /// Identification of the security by an ISIN.
    /// </summary>
    [IsoId("_xmeQdSC6EeWPMvNwVtiMsA")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required SecurityIdentification23Choice_ Identification { get; init; }

    /// <summary>
    /// Name of the financial instrument in free format text.
    /// </summary>
    [IsoId("_xmeQdyC6EeWPMvNwVtiMsA")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? Name { get; init; }

    /// <summary>
    /// Financial Instrument Short Name (FISN) expressed in conformance with the ISO 18774 standard.
    /// </summary>
    [IsoId("_GrGsMCL9EeWw25nezi_B1g")]
    [DisplayName("Short Name")]
    [IsoXmlTag("ShrtNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ShortName { get; init; }

    /// <summary>
    /// Additional information about a financial instrument to help identify the instrument.
    /// </summary>
    [IsoId("_xmeQfyC6EeWPMvNwVtiMsA")]
    [DisplayName("Supplementary Identification")]
    [IsoXmlTag("SplmtryId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? SupplementaryIdentification { get; init; }

    /// <summary>
    /// Features of units offered by a fund. For example, a unit may have a specific load structure, for example, front end or back end, an income policy, for example, pay out or accumulate, or a trailer policy, for example, with or without. Fund classes are typically denoted by a single character, for example, &apos;Class A&apos;, &apos;Class 2&apos;.
    /// </summary>
    [IsoId("_xmeQgSC6EeWPMvNwVtiMsA")]
    [DisplayName("Class Type")]
    [IsoXmlTag("ClssTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ClassType { get; init; }

    /// <summary>
    /// Form of ownership, that is registered or bearer.
    /// </summary>
    [IsoId("_xmeQgyC6EeWPMvNwVtiMsA")]
    [DisplayName("Securities Form")]
    [IsoXmlTag("SctiesForm")]
    public FormOfSecurity1Code? SecuritiesForm { get; init; }

    /// <summary>
    /// Income policy relating to a class type, that is, if income is paid out or retained in the fund.
    /// </summary>
    [IsoId("_xmeQiyC6EeWPMvNwVtiMsA")]
    [DisplayName("Distribution Policy")]
    [IsoXmlTag("DstrbtnPlcy")]
    public DistributionPolicy1Code? DistributionPolicy { get; init; }

    /// <summary>
    /// Company specific description of a group of funds.
    /// </summary>
    [IsoId("_xmeQjSC6EeWPMvNwVtiMsA")]
    [DisplayName("Product Group")]
    [IsoXmlTag("PdctGrp")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? ProductGroup { get; init; }

    /// <summary>
    /// When an account at fund or security level is blocked, this specifies details on how the holding is blocked.
    /// </summary>
    [IsoId("_xmeQjyC6EeWPMvNwVtiMsA")]
    [DisplayName("Blocked Holding Details")]
    [IsoXmlTag("BlckdHldgDtls")]
    public BlockedHoldingDetails2? BlockedHoldingDetails { get; init; }

    /// <summary>
    /// Specifies whether the holdings in the account are eligible for pledging.
    /// </summary>
    [IsoId("_IWy7sCC9EeWPMvNwVtiMsA")]
    [DisplayName("Pledging")]
    [IsoXmlTag("Pldgg")]
    public Eligible1Code? Pledging { get; init; }

    /// <summary>
    /// Specifies whether the holdings in the account are used as collateral.
    /// </summary>
    [IsoId("_8AWuACC9EeWPMvNwVtiMsA")]
    [DisplayName("Collateral")]
    [IsoXmlTag("Coll")]
    public Collateral1Code? Collateral { get; init; }

    /// <summary>
    /// Details of third party rights.
    /// </summary>
    [IsoId("_enC1MCC-EeWPMvNwVtiMsA")]
    [DisplayName("Third Party Rights")]
    [IsoXmlTag("ThrdPtyRghts")]
    public ThirdPartyRights1? ThirdPartyRights { get; init; }

    /// <summary>
    /// Specifies if all the shares are owned exclusively by the fund company.
    /// </summary>
    [IsoId("_NiPHACDXEeWCLu74WLgP4w")]
    [DisplayName("Fund Ownership")]
    [IsoXmlTag("FndOwnrsh")]
    public FundOwnership1Code? FundOwnership { get; init; }

    /// <summary>
    /// Specifies if the fund is intended for qualified investors.
    /// </summary>
    [IsoId("_vs1vICDXEeWCLu74WLgP4w")]
    [DisplayName("Fund Intention")]
    [IsoXmlTag("FndIntntn")]
    public FundIntention1Code? FundIntention { get; init; }

    /// <summary>
    /// Operational status of the fund.
    /// </summary>
    [IsoId("_t3m2YCDYEeWCLu74WLgP4w")]
    [DisplayName("Operational Status")]
    [IsoXmlTag("OprlSts")]
    public OperationalStatus1Code? OperationalStatus { get; init; }
}
