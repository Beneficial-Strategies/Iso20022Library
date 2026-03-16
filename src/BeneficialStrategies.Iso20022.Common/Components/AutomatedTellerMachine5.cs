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
[IsoId("_kjrhsYrfEeSvuOJS0mmL0g")]
[DisplayName("Automated Teller Machine")]
public record AutomatedTellerMachine5
{
    /// <summary>
    /// ATM terminal device identification for the acquirer and the issuer.
    /// </summary>
    [IsoId("_kwfOoYrfEeSvuOJS0mmL0g")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text Identification { get; init; }

    /// <summary>
    /// ATM terminal device identification for the ATM manager.
    /// </summary>
    [IsoId("_kwfOo4rfEeSvuOJS0mmL0g")]
    [DisplayName("Additional Identification")]
    [IsoXmlTag("AddtlId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? AdditionalIdentification { get; init; }

    /// <summary>
    /// ATM terminal device identification for the branch.
    /// </summary>
    [IsoId("_kwfOpYrfEeSvuOJS0mmL0g")]
    [DisplayName("Sequence Number")]
    [IsoXmlTag("SeqNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? SequenceNumber { get; init; }

    /// <summary>
    /// Reference currency of the ATM.
    /// </summary>
    [IsoId("_kwfOp4rfEeSvuOJS0mmL0g")]
    [DisplayName("Base Currency")]
    [IsoXmlTag("BaseCcy")]
    public required ActiveCurrencyCode BaseCurrency { get; init; }

    /// <summary>
    /// Location of the ATM.
    /// </summary>
    [IsoId("_kwfOqYrfEeSvuOJS0mmL0g")]
    [DisplayName("Location")]
    [IsoXmlTag("Lctn")]
    public PostalAddress17? Location { get; init; }

    /// <summary>
    /// Indicates the environment of the transaction.
    /// </summary>
    [IsoId("_kwfOq4rfEeSvuOJS0mmL0g")]
    [DisplayName("Location Category")]
    [IsoXmlTag("LctnCtgy")]
    public TransactionEnvironment2Code? LocationCategory { get; init; }

    /// <summary>
    /// ATM terminal equipment.
    /// </summary>
    [IsoId("_kwfOr4rfEeSvuOJS0mmL0g")]
    [DisplayName("Equipment")]
    [IsoXmlTag("Eqpmnt")]
    public ATMEquipment1? Equipment { get; init; }

    /// <summary>
    /// List of ATM devices out of service.
    /// </summary>
    [IsoId("_kwfOsYrfEeSvuOJS0mmL0g")]
    [DisplayName("Out Of Service Device")]
    [IsoXmlTag("OutOfSvcDvc")]
    public SimpleValueList<ATMDevice2Code> OutOfServiceDevice { get; init; } = [];

    /// <summary>
    /// Mechanism used to protect the message of the ATM protocol.
    /// </summary>
    [IsoId("_S8hBQIrgEeSvuOJS0mmL0g")]
    [DisplayName("Message Protection")]
    [IsoXmlTag("MsgPrtcn")]
    public MessageProtection1Code? MessageProtection { get; init; }
}
