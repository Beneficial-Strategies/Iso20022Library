// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides additional information regarding corporate action instructed balance details at option protect level.
/// </summary>
[IsoId("_Q4PnoQ-0EeuE0Pnt-OcNOA")]
[DisplayName("Corporate Action Instructed Balance Option Protect Instruction SD")]
public record CorporateActionInstructedBalanceOptionProtectInstructionSD4
{
    /// <summary>
    /// Xpath to the element that is being extended.
    /// </summary>
    [IsoId("_RNEoIQ-0EeuE0Pnt-OcNOA")]
    [DisplayName("Place And Name")]
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? PlaceAndName { get; init; }

    /// <summary>
    /// Option number of the protect instruction.
    /// </summary>
    [IsoId("_RNEoIw-0EeuE0Pnt-OcNOA")]
    [DisplayName("Option Number")]
    [IsoXmlTag("OptnNb")]
    public required OptionNumber1Choice_ OptionNumber { get; init; }

    /// <summary>
    /// Instruction reference number assigned by DTC to the uncovered protect instruction.
    /// </summary>
    [IsoId("_TnpNIQ-0EeuE0Pnt-OcNOA")]
    [DisplayName("Protect Identification")]
    [IsoXmlTag("PrtctId")]
    [IsoSimpleType(IsoSimpleType.Max15Text)]
    [StringLength(maximumLength: 15, MinimumLength = 1)]
    public IsoMax15Text? ProtectIdentification { get; init; }

    /// <summary>
    /// For cover protect instructions whereby one safekeeping account is covering on behalf of another safekeeping account. The protect safekeeping account will be the account which submitted the original protect instruction.
    /// </summary>
    [IsoId("_RNEoKw-0EeuE0Pnt-OcNOA")]
    [DisplayName("Protect Safekeeping Account")]
    [IsoXmlTag("PrtctSfkpgAcct")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINMax35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoRestrictedFINMax35Text? ProtectSafekeepingAccount { get; init; }

    /// <summary>
    /// Quantity of the protect instruction which has not been covered.
    /// </summary>
    [IsoId("_RNEoLQ-0EeuE0Pnt-OcNOA")]
    [DisplayName("Protect Identification Uncovered Quantity")]
    [IsoXmlTag("PrtctIdUcvrdQty")]
    public FinancialInstrumentQuantity15Choice_? ProtectIdentificationUncoveredQuantity { get; init; }

    /// <summary>
    /// Protect oversubscription quantity.
    /// </summary>
    [IsoId("_RNEoLw-0EeuE0Pnt-OcNOA")]
    [DisplayName("Protect Identification Oversubscription Quantity")]
    [IsoXmlTag("PrtctIdOvrsbcptQty")]
    public FinancialInstrumentQuantity15Choice_? ProtectIdentificationOversubscriptionQuantity { get; init; }

    /// <summary>
    /// Status of the protect instruction.
    /// </summary>
    [IsoId("_RNEoMQ-0EeuE0Pnt-OcNOA")]
    [DisplayName("Protect Identification Status")]
    [IsoXmlTag("PrtctIdSts")]
    public DTCProtectInstructionStatus1Code? ProtectIdentificationStatus { get; init; }
}
