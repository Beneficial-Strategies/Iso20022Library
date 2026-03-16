// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the central counterparty clearing time.
/// </summary>
[IsoId("_Bemz9-xYEemioJdkOVFBdw")]
[DisplayName("Clearing Party And Time")]
public record ClearingPartyAndTime10
{
    /// <summary>
    /// Indicates that the contract is intended to be cleared.
    /// </summary>
    [IsoId("_9bAboexXEemioJdkOVFBdw")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public NoReasonCode? Reason { get; init; }

    /// <summary>
    /// Identifies the central counterparty (CCP) that cleared the transaction.
    /// </summary>
    [IsoId("_BpsCk-xYEemioJdkOVFBdw")]
    [DisplayName("CCP")]
    [IsoXmlTag("CCP")]
    public OrganisationIdentification10Choice_? CCP { get; init; }

    /// <summary>
    /// Time and date when clearing took place.
    /// </summary>
    [IsoId("_BpsClexYEemioJdkOVFBdw")]
    [DisplayName("Clearing Date Time")]
    [IsoXmlTag("ClrDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? ClearingDateTime { get; init; }
}
