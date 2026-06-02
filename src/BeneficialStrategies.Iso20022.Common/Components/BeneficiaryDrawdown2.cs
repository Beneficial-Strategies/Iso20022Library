// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about the beneficiary of a drawdown.
/// </summary>
[IsoId("060f5b7c-5f73-49cd-8328-183e7820b929")]
[DisplayName("Beneficiary Drawdown2")]
public record BeneficiaryDrawdown2
{
    /// <summary>
    /// Type of beneficiary.
    /// </summary>
    [IsoId("cb9eed79-2346-4bac-a3e5-b53616211789")]
    [DisplayName("Beneficiary Type")]
    [IsoXmlTag("BnfcryTp")]
    public BeneficiaryType1Choice? BeneficiaryType { get; init; }

    /// <summary>
    /// Indicates whether the original pension holder was under the age limit when deceased.
    /// </summary>
    [IsoId("2cfc2348-9c76-4fe7-9664-2eb47cd15421")]
    [DisplayName("Death Under Limit")]
    [IsoXmlTag("DthUdrLmt")]
    public IsoYesNoIndicator? DeathUnderLimit { get; init; }

    /// <summary>
    /// Date of death of the original pension holder.
    /// </summary>
    [IsoId("fbeef981-e754-42c2-8686-5a74c48e8783")]
    [DisplayName("Date Of Death")]
    [IsoXmlTag("DtOfDth")]
    public IsoISODate? DateOfDeath { get; init; }

    /// <summary>
    /// Date on which the new beneficiary was designated.
    /// </summary>
    [IsoId("ee24e9c6-da87-4795-8174-de46d3e404c9")]
    [DisplayName("Date Designated To Beneficiary")]
    [IsoXmlTag("DtDsgntdToBnfcry")]
    public IsoISODate? DateDesignatedToBeneficiary { get; init; }

    /// <summary>
    /// Additional information about the recipient of the drawdown.
    /// </summary>
    [IsoId("3732d376-9487-49e9-9c3b-8f5bf75833fa")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public ValueList<AdditionalInformation15> AdditionalInformation { get; init; } = [];
}
