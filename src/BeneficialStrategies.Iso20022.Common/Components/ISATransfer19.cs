// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Describes the type of product and the assets to be transferred.
/// </summary>
[IsoId("_l0CXpQgMEeSFYfyUKDXKaw")]
[DisplayName("ISA Transfer")]
public record ISATransfer19
{
    /// <summary>
    /// Information identifying the primary individual investor, for example, name, address, social security number and date of birth.
    /// </summary>
    [IsoId("_mPHxLQgMEeSFYfyUKDXKaw")]
    [DisplayName("Primary Individual Investor")]
    [IsoXmlTag("PmryIndvInvstr")]
    public IndividualPerson8? PrimaryIndividualInvestor { get; init; }

    /// <summary>
    /// Information identifying the secondary individual investor, for example, name, address, social security number and date of birth.
    /// </summary>
    [IsoId("_mPHxLwgMEeSFYfyUKDXKaw")]
    [DisplayName("Secondary Individual Investor")]
    [IsoXmlTag("ScndryIndvInvstr")]
    public IndividualPerson8? SecondaryIndividualInvestor { get; init; }

    /// <summary>
    /// Information identifying the other individual investors, for example, name, address, social security number and date of birth.
    /// </summary>
    [IsoId("_mPHxMQgMEeSFYfyUKDXKaw")]
    [DisplayName("Other Individual Investor")]
    [IsoXmlTag("OthrIndvInvstr")]
    public ValueList<IndividualPerson8> OtherIndividualInvestor { get; init; } = [];

    /// <summary>
    /// Information identifying the primary corporate investor, for example, name and address.
    /// </summary>
    [IsoId("_mPHxMwgMEeSFYfyUKDXKaw")]
    [DisplayName("Primary Corporate Investor")]
    [IsoXmlTag("PmryCorpInvstr")]
    public Organisation4? PrimaryCorporateInvestor { get; init; }

    /// <summary>
    /// Information identifying the secondary corporate investor, for example, name and address.
    /// </summary>
    [IsoId("_mPHxNQgMEeSFYfyUKDXKaw")]
    [DisplayName("Secondary Corporate Investor")]
    [IsoXmlTag("ScndryCorpInvstr")]
    public Organisation4? SecondaryCorporateInvestor { get; init; }

    /// <summary>
    /// Information identifying the other corporate investors, for example, name and address.
    /// </summary>
    [IsoId("_mPHxNwgMEeSFYfyUKDXKaw")]
    [DisplayName("Other Corporate Investor")]
    [IsoXmlTag("OthrCorpInvstr")]
    public ValueList<Organisation4> OtherCorporateInvestor { get; init; } = [];

    /// <summary>
    /// Identification of an account owned by the investor at the old plan manager (account servicer).
    /// </summary>
    [IsoId("_mPHxOQgMEeSFYfyUKDXKaw")]
    [DisplayName("Transferor Account")]
    [IsoXmlTag("TrfrAcct")]
    public required Account15 TransferorAccount { get; init; }

    /// <summary>
    /// Account held in the name of a party that is not the name of the beneficial owner of the shares.
    /// </summary>
    [IsoId("_mPHxOwgMEeSFYfyUKDXKaw")]
    [DisplayName("Nominee Account")]
    [IsoXmlTag("NmneeAcct")]
    public Account16? NomineeAccount { get; init; }

    /// <summary>
    /// Information related to the institution to which the financial instrument is to be transferred.
    /// </summary>
    [IsoId("_mPHxPQgMEeSFYfyUKDXKaw")]
    [DisplayName("Transferee")]
    [IsoXmlTag("Trfee")]
    public required PartyIdentification2Choice_ Transferee { get; init; }

    /// <summary>
    /// Identification of an account owned by the investor to which a cash entry is made based on the transfer of asset(s).
    /// </summary>
    [IsoId("_mPHxPwgMEeSFYfyUKDXKaw")]
    [DisplayName("Cash Account")]
    [IsoXmlTag("CshAcct")]
    public CashAccount29? CashAccount { get; init; }

    /// <summary>
    /// Details of the transfer to be cancelled.
    /// </summary>
    [IsoId("_mPHxQQgMEeSFYfyUKDXKaw")]
    [DisplayName("Product Transfer And Reference")]
    [IsoXmlTag("PdctTrfAndRef")]
    public required ISATransfer20 ProductTransferAndReference { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_mPHxQwgMEeSFYfyUKDXKaw")]
    [DisplayName("Extension")]
    [IsoXmlTag("Xtnsn")]
    public ValueList<Extension1> Extension { get; init; } = [];
}
