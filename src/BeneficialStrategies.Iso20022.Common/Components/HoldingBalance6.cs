// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Net position of a segregated holding of a single security within the overall position held in the securities account, eg, sub-balance per status.
/// </summary>
[IsoId("_QYxDV9p-Ed-ak6NoX_4Aeg_-1016174191")]
[DisplayName("Holding Balance")]
public record HoldingBalance6
{
    /// <summary>
    /// Total quantity of financial instrument for the referenced holding.
    /// </summary>
    [IsoId("_QYxDWNp-Ed-ak6NoX_4Aeg_-1016174160")]
    [DisplayName("Balance")]
    [IsoXmlTag("Bal")]
    public UnitOrFaceAmount1Choice_? Balance { get; init; }

    /// <summary>
    /// Reason a security is not available or additional information about the financial instrument for which the balance is given, for example, unregistered, registered in nominee name.
    /// </summary>
    [IsoId("_QY60UNp-Ed-ak6NoX_4Aeg_-1016174130")]
    [DisplayName("Balance Type")]
    [IsoXmlTag("BalTp")]
    public SecuritiesEntryType2Code? BalanceType { get; init; }

    /// <summary>
    /// Place where the securities are safe-kept, physically or notionally. This place can be, for example, a local custodian, a Central Securities Depository (CSD) or an International Central Securities Depository (ICSD).
    /// </summary>
    [IsoId("_QY60Udp-Ed-ak6NoX_4Aeg_-1016174069")]
    [DisplayName("Safekeeping Place")]
    [IsoXmlTag("SfkpgPlc")]
    public SafekeepingPlaceFormatChoice_? SafekeepingPlace { get; init; }

    /// <summary>
    /// Date of the entitlement.
    /// </summary>
    [IsoId("_QY60Utp-Ed-ak6NoX_4Aeg_-1016174007")]
    [DisplayName("Date")]
    [IsoXmlTag("Dt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? Date { get; init; }
}
