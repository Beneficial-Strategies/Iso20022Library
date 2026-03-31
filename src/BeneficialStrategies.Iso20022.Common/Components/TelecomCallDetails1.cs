// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Structured call details with address.
/// </summary>
[IsoId("_1J_VOPfGEei89sMSHxl1ew")]
[DisplayName("Telecom Call Details")]
public record TelecomCallDetails1
{
    /// <summary>
    /// Contains call type values.
    /// </summary>
    [IsoId("_1J_VOffGEei89sMSHxl1ew")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public TelephonyCallType1Code? Type { get; init; }

    /// <summary>
    /// Contains other call type values.
    /// </summary>
    [IsoId("_1J_VPvfGEei89sMSHxl1ew")]
    [DisplayName("Other Type")]
    [IsoXmlTag("OthrTp")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? OtherType { get; init; }

    /// <summary>
    /// Origination or destination phone number.
    /// </summary>
    [IsoId("_d2rxUffHEei89sMSHxl1ew")]
    [DisplayName("Phone Number")]
    [IsoXmlTag("PhneNb")]
    [IsoSimpleType(IsoSimpleType.PhoneNumber)]
    public IsoPhoneNumber? PhoneNumber { get; init; }

    /// <summary>
    /// City from which or to which the call was made.
    /// </summary>
    [IsoId("_1J_VP_fGEei89sMSHxl1ew")]
    [DisplayName("City")]
    [IsoXmlTag("City")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? City { get; init; }

    /// <summary>
    /// State from which or to which the call was made.
    /// </summary>
    [IsoId("_1J_VO_fGEei89sMSHxl1ew")]
    [DisplayName("State")]
    [IsoXmlTag("Stat")]
    [IsoSimpleType(IsoSimpleType.Max16Text)]
    [StringLength(maximumLength: 16, MinimumLength = 1)]
    public IsoMax16Text? State { get; init; }

    /// <summary>
    /// Province from which or to which the call was made.
    /// </summary>
    [IsoId("_1J_VPPfGEei89sMSHxl1ew")]
    [DisplayName("Province")]
    [IsoXmlTag("Prvc")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Province { get; init; }

    /// <summary>
    /// Country from which or to which the call was made.
    /// </summary>
    [IsoId("_1J_VPffGEei89sMSHxl1ew")]
    [DisplayName("Country")]
    [IsoXmlTag("Ctry")]
    [IsoSimpleType(IsoSimpleType.Min2Max3AlphaText)]
    public IsoMin2Max3AlphaText? Country { get; init; }
}
