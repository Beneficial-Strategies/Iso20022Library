// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// ATM information.
/// </summary>
[IsoId("_nmv2ka4VEeW_TaP-ygI0SQ")]
[DisplayName("Automated Teller Machine")]
public record AutomatedTellerMachine10
{
    /// <summary>
    /// ATM terminal device identification for the acquirer and the issuer.
    /// </summary>
    [IsoId("_nyEVwa4VEeW_TaP-ygI0SQ")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text Identification { get; init; }

    /// <summary>
    /// ATM terminal device identification for the ATM manager.
    /// </summary>
    [IsoId("_nyEVw64VEeW_TaP-ygI0SQ")]
    [DisplayName("Additional Identification")]
    [IsoXmlTag("AddtlId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? AdditionalIdentification { get; init; }

    /// <summary>
    /// ATM terminal device identification for the branch.
    /// </summary>
    [IsoId("_nyEVxa4VEeW_TaP-ygI0SQ")]
    [DisplayName("Sequence Number")]
    [IsoXmlTag("SeqNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? SequenceNumber { get; init; }

    /// <summary>
    /// Reference currency of the ATM.
    /// </summary>
    [IsoId("_nyEVx64VEeW_TaP-ygI0SQ")]
    [DisplayName("Base Currency")]
    [IsoXmlTag("BaseCcy")]
    public required ActiveCurrencyCode BaseCurrency { get; init; }

    /// <summary>
    /// Location of the ATM.
    /// </summary>
    [IsoId("_nyEVya4VEeW_TaP-ygI0SQ")]
    [DisplayName("Location")]
    [IsoXmlTag("Lctn")]
    public PostalAddress17? Location { get; init; }

    /// <summary>
    /// Indicates the environment of the transaction.
    /// </summary>
    [IsoId("_nyEVy64VEeW_TaP-ygI0SQ")]
    [DisplayName("Location Category")]
    [IsoXmlTag("LctnCtgy")]
    public TransactionEnvironment2Code? LocationCategory { get; init; }

    /// <summary>
    /// Capabilities of the ATM terminal performing the transaction.
    /// </summary>
    [IsoId("_nyEVza4VEeW_TaP-ygI0SQ")]
    [DisplayName("Capabilities")]
    [IsoXmlTag("Cpblties")]
    public PointOfInteractionCapabilities7? Capabilities { get; init; }

    /// <summary>
    /// ATM terminal equipment.
    /// </summary>
    [IsoId("_nyEVz64VEeW_TaP-ygI0SQ")]
    [DisplayName("Equipment")]
    [IsoXmlTag("Eqpmnt")]
    public ATMEquipment1? Equipment { get; init; }

    /// <summary>
    /// List of ATM devices out of service.
    /// </summary>
    [IsoId("_nyEV0a4VEeW_TaP-ygI0SQ")]
    [DisplayName("Available Device")]
    [IsoXmlTag("AvlblDvc")]
    public SimpleValueList<ATMDevice2Code> AvailableDevice { get; init; } = [];
}
