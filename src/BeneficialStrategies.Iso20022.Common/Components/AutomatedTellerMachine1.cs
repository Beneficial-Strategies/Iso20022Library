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
[IsoId("_4kERQIn3EeShMpas3885ww")]
[DisplayName("Automated Teller Machine")]
public record AutomatedTellerMachine1
{
    /// <summary>
    /// ATM terminal device identification for the acquirer and the issuer.
    /// </summary>
    [IsoId("_A5NXQIn4EeShMpas3885ww")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text Identification { get; init; }

    /// <summary>
    /// ATM terminal device identification for the ATM manager.
    /// </summary>
    [IsoId("_NO13MIn4EeShMpas3885ww")]
    [DisplayName("Additional Identification")]
    [IsoXmlTag("AddtlId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? AdditionalIdentification { get; init; }

    /// <summary>
    /// ATM terminal device identification for the branch.
    /// </summary>
    [IsoId("_Q4L8cIn4EeShMpas3885ww")]
    [DisplayName("Sequence Number")]
    [IsoXmlTag("SeqNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? SequenceNumber { get; init; }

    /// <summary>
    /// Reference currency of the ATM.
    /// </summary>
    [IsoId("_V-1tMIn4EeShMpas3885ww")]
    [DisplayName("Base Currency")]
    [IsoXmlTag("BaseCcy")]
    public required ActiveCurrencyCode BaseCurrency { get; init; }

    /// <summary>
    /// Location of the ATM.
    /// </summary>
    [IsoId("_n0FQcIn4EeShMpas3885ww")]
    [DisplayName("Location")]
    [IsoXmlTag("Lctn")]
    public PostalAddress17? Location { get; init; }

    /// <summary>
    /// Indicates the environment of the transaction.
    /// </summary>
    [IsoId("_dytAMIn6EeShMpas3885ww")]
    [DisplayName("Location Category")]
    [IsoXmlTag("LctnCtgy")]
    public TransactionEnvironment2Code? LocationCategory { get; init; }

    /// <summary>
    /// Capabilities of the ATM terminal performing the transaction.
    /// </summary>
    [IsoId("_2iMYwIn6EeShMpas3885ww")]
    [DisplayName("Capabilities")]
    [IsoXmlTag("Cpblties")]
    public PointOfInteractionCapabilities5? Capabilities { get; init; }

    /// <summary>
    /// ATM terminal equipment.
    /// </summary>
    [IsoId("_Di9OcIn9EeShMpas3885ww")]
    [DisplayName("Equipment")]
    [IsoXmlTag("Eqpmnt")]
    public ATMEquipment1? Equipment { get; init; }
}
