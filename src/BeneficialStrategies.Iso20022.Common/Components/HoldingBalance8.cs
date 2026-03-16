// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Net position of a segregated holding of a single security within the overall position held in the securities account,for example, sub-balance per status.
/// </summary>
[IsoId("__b2CMVtkEeSwKe7KuKvXhg")]
[DisplayName("Holding Balance")]
public record HoldingBalance8
{
    /// <summary>
    /// Total quantity of financial instrument for the referenced holding.
    /// </summary>
    [IsoId("__4aCY1tkEeSwKe7KuKvXhg")]
    [DisplayName("Balance")]
    [IsoXmlTag("Bal")]
    public required UnitOrFaceAmountOrCode1Choice_ Balance { get; init; }

    /// <summary>
    /// Reason a security is not available or additional information about the financial instrument for which the balance is given, for example, unregistered, registered in nominee name.
    /// </summary>
    [IsoId("__4aCZVtkEeSwKe7KuKvXhg")]
    [DisplayName("Balance Type")]
    [IsoXmlTag("BalTp")]
    public SecuritiesEntryType2Code? BalanceType { get; init; }

    /// <summary>
    /// Place where the securities are safe-kept, physically or notionally. This place can be, for example, a local custodian, a Central Securities Depository (CSD) or an International Central Securities Depository (ICSD).
    /// </summary>
    [IsoId("__4aCZ1tkEeSwKe7KuKvXhg")]
    [DisplayName("Safekeeping Place")]
    [IsoXmlTag("SfkpgPlc")]
    public SafekeepingPlaceFormat2Choice_? SafekeepingPlace { get; init; }
}
