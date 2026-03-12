// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Net position of a segregated holding of a single security within the overall position held in the securities account, for example, sub-balance per status.
/// </summary>
[IsoId("_UfAdDa7yEemG7MmivSuE5g")]
[DisplayName("Holding Balance")]
public partial record HoldingBalance9
{
    #nullable enable
    
    /// <summary>
    /// Total quantity of financial instrument for the referenced holding.
    /// </summary>
    [IsoId("_U03_U67yEemG7MmivSuE5g")]
    [DisplayName("Balance")]
    [IsoXmlTag("Bal")]
    public required FinancialInstrumentQuantity18Choice_ Balance { get; init; } 
    
    /// <summary>
    /// Reason a security is not available or additional information about the financial instrument for which the balance is given, for example, unregistered, registered in nominee name.
    /// </summary>
    [IsoId("_U03_Va7yEemG7MmivSuE5g")]
    [DisplayName("Balance Type")]
    [IsoXmlTag("BalTp")]
    public required SecuritiesEntryType2Code BalanceType { get; init; } 
    
    /// <summary>
    /// Place where the securities are safe-kept, physically or notionally. This place can be, for example, a local custodian, a Central Securities Depository (CSD) or an International Central Securities Depository (ICSD).
    /// </summary>
    [IsoId("_U03_V67yEemG7MmivSuE5g")]
    [DisplayName("Safekeeping Place")]
    [IsoXmlTag("SfkpgPlc")]
    public SafekeepingPlaceFormat28Choice_? SafekeepingPlace { get; init; } 
    
    /// <summary>
    /// Date of the entitlement.
    /// </summary>
    [IsoId("_U03_Wa7yEemG7MmivSuE5g")]
    [DisplayName("Date")]
    [IsoXmlTag("Dt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? Date { get; init; } 
    
    
    #nullable disable
    
}
