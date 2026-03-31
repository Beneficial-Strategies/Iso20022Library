// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the reference number assigned by the clearing broker. A distinction can be made between the reference for the Central Counterparty (CCP) leg and the reference for the client leg of the transaction.
/// </summary>
[IsoId("_KYvvc4uZEeKYr_965Eh8aQ")]
[DisplayName("Clearing Broker Identification")]
public record ClearingBrokerIdentification1
{
    /// <summary>
    /// Distinguishes the client leg from the central counterparty (CCP) leg in the clearing broker identification.
    /// </summary>
    [IsoId("_s1IrIIuZEeKYr_965Eh8aQ")]
    [DisplayName("Side Indicator")]
    [IsoXmlTag("SdInd")]
    public required SideIndicator1Code SideIndicator { get; init; }

    /// <summary>
    /// Specifies the identification assigned to the clearing broker.
    /// </summary>
    [IsoId("_1RBSUIuZEeKYr_965Eh8aQ")]
    [DisplayName("Clearing Broker Identification")]
    [IsoXmlTag("ClrBrkrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text ClearingBrokerIdentification { get; init; }
}
