// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about a transfer instruction.
/// </summary>
[IsoId("_RQ8ogtp-Ed-ak6NoX_4Aeg_1365580031")]
[DisplayName("PEPISA Transfer")]
public record PEPISATransfer7
{
    /// <summary>
    /// Information identifying the primary individual investor, eg, name, address, social security number and date of birth.
    /// </summary>
    [IsoId("_RQ8og9p-Ed-ak6NoX_4Aeg_-1099764976")]
    [DisplayName("Primary Individual Investor")]
    [IsoXmlTag("PmryIndvInvstr")]
    public IndividualPerson8? PrimaryIndividualInvestor { get; init; }

    /// <summary>
    /// Information identifying the secondary individual investor, eg, name, address, social security number and date of birth.
    /// </summary>
    [IsoId("_RQ8ohNp-Ed-ak6NoX_4Aeg_-584439393")]
    [DisplayName("Secondary Individual Investor")]
    [IsoXmlTag("ScndryIndvInvstr")]
    public IndividualPerson8? SecondaryIndividualInvestor { get; init; }

    /// <summary>
    /// Information identifying the other individual investors, eg, name, address, social security number and date of birth.
    /// </summary>
    [IsoId("_RQ8ohdp-Ed-ak6NoX_4Aeg_-352635019")]
    [DisplayName("Other Individual Investor")]
    [IsoXmlTag("OthrIndvInvstr")]
    public ValueList<IndividualPerson8> OtherIndividualInvestor { get; init; } = [];

    /// <summary>
    /// Information identifying the primary corporate investor, eg, name and address.
    /// </summary>
    [IsoId("_RQ8ohtp-Ed-ak6NoX_4Aeg_133134622")]
    [DisplayName("Primary Corporate Investor")]
    [IsoXmlTag("PmryCorpInvstr")]
    public Organisation4? PrimaryCorporateInvestor { get; init; }

    /// <summary>
    /// Information identifying the secondary corporate investor, eg, name and address.
    /// </summary>
    [IsoId("_RQ8oh9p-Ed-ak6NoX_4Aeg_-854109506")]
    [DisplayName("Secondary Corporate Investor")]
    [IsoXmlTag("ScndryCorpInvstr")]
    public Organisation4? SecondaryCorporateInvestor { get; init; }

    /// <summary>
    /// Information identifying the other corporate investors, eg, name and address.
    /// </summary>
    [IsoId("_RQ8oiNp-Ed-ak6NoX_4Aeg_160843477")]
    [DisplayName("Other Corporate Investor")]
    [IsoXmlTag("OthrCorpInvstr")]
    public ValueList<Organisation4> OtherCorporateInvestor { get; init; } = [];

    /// <summary>
    /// Identification of an account owned by the investor at the old plan manager (account servicer).
    /// </summary>
    [IsoId("_RQ8oidp-Ed-ak6NoX_4Aeg_-851335907")]
    [DisplayName("Client Account")]
    [IsoXmlTag("ClntAcct")]
    public required Account5 ClientAccount { get; init; }

    /// <summary>
    /// Account held in the name of a party that is not the name of the beneficial owner of the shares.
    /// </summary>
    [IsoId("_RQ8oitp-Ed-ak6NoX_4Aeg_-824556683")]
    [DisplayName("Nominee Account")]
    [IsoXmlTag("NmneeAcct")]
    public Account6? NomineeAccount { get; init; }

    /// <summary>
    /// Information related to the institution to which the financial instrument is to be transferred.
    /// </summary>
    [IsoId("_RRGZgNp-Ed-ak6NoX_4Aeg_-813474062")]
    [DisplayName("New Plan Manager")]
    [IsoXmlTag("NewPlanMgr")]
    public required PartyIdentification2Choice_ NewPlanManager { get; init; }

    /// <summary>
    /// Identification of an account owned by the investor to which a cash entry is made based on the transfer of asset(s).
    /// </summary>
    [IsoId("_RRGZgdp-Ed-ak6NoX_4Aeg_-809777956")]
    [DisplayName("Cash Account")]
    [IsoXmlTag("CshAcct")]
    public CashAccount11? CashAccount { get; init; }

    /// <summary>
    /// Provides information related to the asset(s) transferred.
    /// </summary>
    [IsoId("_RRGZgtp-Ed-ak6NoX_4Aeg_1190462500")]
    [DisplayName("Product Transfer")]
    [IsoXmlTag("PdctTrf")]
    public ValueList<PEPISATransfer8> ProductTransfer { get; init; } = [];

    // ID for the above is _RRGZgtp-Ed-ak6NoX_4Aeg_1190462500

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_RRGZg9p-Ed-ak6NoX_4Aeg_-756215153")]
    [DisplayName("Extension")]
    [IsoXmlTag("Xtnsn")]
    public ValueList<Extension1> Extension { get; init; } = [];
}
