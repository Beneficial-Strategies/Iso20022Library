// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Automated Teller Machine12.
/// </summary>
[IsoId("_ZIAcMaEUEe-MRKYsaX6JDg")]
[DisplayName("Automated Teller Machine12")]
public record AutomatedTellerMachine12
{
    /// <summary>
    /// Additional Identification.
    /// </summary>
    [DisplayName("Additional Identification")]
    [IsoXmlTag("AddtlId")]
    public IsoMax35Text? AdditionalIdentification { get; init; }

    /// <summary>
    /// Base Currency.
    /// </summary>
    [DisplayName("Base Currency")]
    [IsoXmlTag("BaseCcy")]
    public required ActiveCurrencyCode BaseCurrency { get; init; }

    /// <summary>
    /// Capabilities.
    /// </summary>
    [DisplayName("Capabilities")]
    [IsoXmlTag("Cpblties")]
    public PointOfInteractionCapabilities10? Capabilities { get; init; }

    /// <summary>
    /// Equipment.
    /// </summary>
    [DisplayName("Equipment")]
    [IsoXmlTag("Eqpmnt")]
    public ATMEquipment1? Equipment { get; init; }

    /// <summary>
    /// Identification.
    /// </summary>
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required IsoMax35Text Identification { get; init; }

    /// <summary>
    /// Location.
    /// </summary>
    [DisplayName("Location")]
    [IsoXmlTag("Lctn")]
    public PostalAddress17? Location { get; init; }

    /// <summary>
    /// Location Category.
    /// </summary>
    [DisplayName("Location Category")]
    [IsoXmlTag("LctnCtgy")]
    public TransactionEnvironment2Code? LocationCategory { get; init; }

    /// <summary>
    /// Sequence Number.
    /// </summary>
    [DisplayName("Sequence Number")]
    [IsoXmlTag("SeqNb")]
    public IsoMax35Text? SequenceNumber { get; init; }
}
