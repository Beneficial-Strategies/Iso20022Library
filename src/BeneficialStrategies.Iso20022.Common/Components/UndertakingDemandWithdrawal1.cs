// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of the demand withdrawal notification.
/// </summary>
[IsoId("_-Br9JnltEeG7BsjMvd1mEw_1678341433")]
[DisplayName("Undertaking Demand Withdrawal")]
public record UndertakingDemandWithdrawal1
{
    /// <summary>
    /// Details related to the identification of the undertaking.
    /// </summary>
    [IsoId("_-Br9J3ltEeG7BsjMvd1mEw_149297181")]
    [DisplayName("Undertaking Identification")]
    [IsoXmlTag("UdrtkgId")]
    public required Undertaking6 UndertakingIdentification { get; init; }

    /// <summary>
    /// Unique and unambiguous identifier assigned by the advising party to the undertaking.
    /// </summary>
    [IsoId("_-Br9KHltEeG7BsjMvd1mEw_-1462957369")]
    [DisplayName("Advising Party Reference Number")]
    [IsoXmlTag("AdvsgPtyRefNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? AdvisingPartyReferenceNumber { get; init; }

    /// <summary>
    /// Details related to the demand.
    /// </summary>
    [IsoId("_-B1uIHltEeG7BsjMvd1mEw_-2032107044")]
    [DisplayName("Demand Details")]
    [IsoXmlTag("DmndDtls")]
    public required Demand3 DemandDetails { get; init; }

    /// <summary>
    /// Unique and unambiguous identifier assigned by the confirmer to the undertaking.
    /// </summary>
    [IsoId("_-B1uIXltEeG7BsjMvd1mEw_1834937574")]
    [DisplayName("Confirmer Reference Number")]
    [IsoXmlTag("CnfrmrRefNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ConfirmerReferenceNumber { get; init; }
}
