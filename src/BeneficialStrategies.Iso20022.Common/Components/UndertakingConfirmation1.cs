// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Confirmation information for the issued undertaking.
/// </summary>
[IsoId("_9yV5knltEeG7BsjMvd1mEw_-1807654359")]
[DisplayName("Undertaking Confirmation")]
public record UndertakingConfirmation1
{
    /// <summary>
    /// Party that adds its undertaking to honour the undertaking or amendment of the undertaking.
    /// </summary>
    [IsoId("_9yV5k3ltEeG7BsjMvd1mEw_-1094766461")]
    [DisplayName("Confirmer")]
    [IsoXmlTag("Cnfrmr")]
    public required PartyIdentification43 Confirmer { get; init; }

    /// <summary>
    /// Unique and unambiguous identifier assigned by the confirmer to the undertaking.
    /// </summary>
    [IsoId("_9yV5lHltEeG7BsjMvd1mEw_-1612716749")]
    [DisplayName("Reference Number")]
    [IsoXmlTag("RefNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text ReferenceNumber { get; init; }

    /// <summary>
    /// Date and time when the undertaking or amendment of the undertaking was confirmed.
    /// </summary>
    [IsoId("_9yV5lXltEeG7BsjMvd1mEw_-1478675936")]
    [DisplayName("Date")]
    [IsoXmlTag("Dt")]
    public required DateAndDateTimeChoice_ Date { get; init; }

    /// <summary>
    /// Confirmation of the undertaking or amendment of the confirmed undertaking.
    /// </summary>
    [IsoId("_9yV5lnltEeG7BsjMvd1mEw_-1395818404")]
    [DisplayName("Confirmation")]
    [IsoXmlTag("Conf")]
    [IsoSimpleType(IsoSimpleType.Max2000Text)]
    [MinLength(0)]
    [MaxLength(5)]
    public SimpleValueList<System.String> Confirmation { get; init; } = [];
}
