// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Holding Balance14.
/// </summary>
[IsoId("_4SCqdY-9Ee-COKgew96POA")]
[DisplayName("Holding Balance14")]
public partial record HoldingBalance14
{
    #nullable enable

    /// <summary>
    /// Balance.
    /// </summary>
    [DisplayName("Balance")]
    [IsoXmlTag("Bal")]
    public required SignedQuantityFormat14 Balance { get; init; } 

    /// <summary>
    /// Balance Type.
    /// </summary>
    [DisplayName("Balance Type")]
    [IsoXmlTag("BalTp")]
    public required SecuritiesEntryType2Code BalanceType { get; init; } 

    /// <summary>
    /// Date.
    /// </summary>
    [DisplayName("Date")]
    [IsoXmlTag("Dt")]
    public IsoISODate? Date { get; init; } 

    /// <summary>
    /// Safekeeping Place.
    /// </summary>
    [DisplayName("Safekeeping Place")]
    [IsoXmlTag("SfkpgPlc")]
    public SafekeepingPlaceFormat42Choice_? SafekeepingPlace { get; init; } 

    
    #nullable disable
    
}
