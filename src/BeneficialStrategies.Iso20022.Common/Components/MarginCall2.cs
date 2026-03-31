// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the calculation and the resulting margin and independent amount needed to cover the risk exposure of one party versus another.
/// </summary>
[IsoId("_gfK1AILVEeWrrO9HojbPQA")]
[DisplayName("Margin Call")]
public record MarginCall2
{
    /// <summary>
    /// Provides additional information on the collateral account of the party delivering/receiving the collateral.
    /// </summary>
    [IsoId("_ZJDtoILWEeWrrO9HojbPQA")]
    [DisplayName("Collateral Account Identification")]
    [IsoXmlTag("CollAcctId")]
    public CollateralAccount2? CollateralAccountIdentification { get; init; }

    /// <summary>
    /// Summation of the call amounts per margin type. It is provided for the purposes of carrying forward for future messages that are used to compare the margin call results to determine whether a call is agreed or full/partially disputed.
    /// </summary>
    [IsoId("_Hey14ILXEeWrrO9HojbPQA")]
    [DisplayName("Margin Call Result")]
    [IsoXmlTag("MrgnCallRslt")]
    public required MarginCallResult3 MarginCallResult { get; init; }

    /// <summary>
    /// Provides details about the margin calculation that would be due to party A.
    /// </summary>
    [IsoId("_rzRKAILWEeWrrO9HojbPQA")]
    [DisplayName("Margin Detail Due To A")]
    [IsoXmlTag("MrgnDtlDueToA")]
    public MarginCall1? MarginDetailDueToA { get; init; }

    /// <summary>
    /// Provides details about the margin calculation that would be due to party B.
    /// </summary>
    [IsoId("_zRi5cILWEeWrrO9HojbPQA")]
    [DisplayName("Margin Detail Due To B")]
    [IsoXmlTag("MrgnDtlDueToB")]
    public MarginCall1? MarginDetailDueToB { get; init; }

    /// <summary>
    /// Amount of expected margin that will be either delivered to party A by party B or recalled to party A from party B.
    /// </summary>
    [IsoId("_3Lsa0ILWEeWrrO9HojbPQA")]
    [DisplayName("Requirement Details Due To A")]
    [IsoXmlTag("RqrmntDtlsDueToA")]
    public MarginRequirement1Choice_? RequirementDetailsDueToA { get; init; }

    /// <summary>
    /// Amount of expected margin that will be either delivered to party B by party A or recalled to party B from party A.
    /// </summary>
    [IsoId("_Apw3wILXEeWrrO9HojbPQA")]
    [DisplayName("Requirement Details Due To B")]
    [IsoXmlTag("RqrmntDtlsDueToB")]
    public MarginRequirement1Choice_? RequirementDetailsDueToB { get; init; }

    /// <summary>
    /// Provides details about the type of collateral that will be either delivered to party A by party B or recalled to party A from party B.
    /// </summary>
    [IsoId("_bkuCUILXEeWrrO9HojbPQA")]
    [DisplayName("Expected Collateral Due To A")]
    [IsoXmlTag("XpctdCollDueToA")]
    public ExpectedCollateral2Choice_? ExpectedCollateralDueToA { get; init; }

    /// <summary>
    /// Provides details about the type of collateral that will be either delivered to party B by party A or recalled to party B from party A.
    /// </summary>
    [IsoId("_ioK28ILXEeWrrO9HojbPQA")]
    [DisplayName("Expected Collateral Due To B")]
    [IsoXmlTag("XpctdCollDueToB")]
    public ExpectedCollateral2Choice_? ExpectedCollateralDueToB { get; init; }
}
