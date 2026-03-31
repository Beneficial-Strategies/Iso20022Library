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
[IsoId("_g1MlsYtLEeSxlKlAGYErFg")]
[DisplayName("Automated Teller Machine")]
public record AutomatedTellerMachine6
{
    /// <summary>
    /// ATM terminal device identification for the acquirer and the issuer.
    /// </summary>
    [IsoId("_hBkNwYtLEeSxlKlAGYErFg")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text Identification { get; init; }

    /// <summary>
    /// ATM terminal device identification for the ATM manager.
    /// </summary>
    [IsoId("_hBkNw4tLEeSxlKlAGYErFg")]
    [DisplayName("Additional Identification")]
    [IsoXmlTag("AddtlId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? AdditionalIdentification { get; init; }

    /// <summary>
    /// ATM terminal device identification for the branch.
    /// </summary>
    [IsoId("_hBkNxYtLEeSxlKlAGYErFg")]
    [DisplayName("Sequence Number")]
    [IsoXmlTag("SeqNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? SequenceNumber { get; init; }

    /// <summary>
    /// Location of the ATM.
    /// </summary>
    [IsoId("_hBkNyYtLEeSxlKlAGYErFg")]
    [DisplayName("Location")]
    [IsoXmlTag("Lctn")]
    public PostalAddress17? Location { get; init; }

    /// <summary>
    /// Indicates the environment of the transaction.
    /// </summary>
    [IsoId("_hBkNy4tLEeSxlKlAGYErFg")]
    [DisplayName("Location Category")]
    [IsoXmlTag("LctnCtgy")]
    public TransactionEnvironment2Code? LocationCategory { get; init; }

    /// <summary>
    /// ATM terminal equipment.
    /// </summary>
    [IsoId("_hBkNz4tLEeSxlKlAGYErFg")]
    [DisplayName("Equipment")]
    [IsoXmlTag("Eqpmnt")]
    public ATMEquipment1? Equipment { get; init; }
}
