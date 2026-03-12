// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the settlement fails and the ranking for a specific financial instrument.
/// </summary>
[IsoId("_Bnkxd40bEemUAO64Q252gQ")]
[DisplayName("Settlement Fails Securities")]
public partial record SettlementFailsSecurities1
{
    #nullable enable
    
    /// <summary>
    /// Financial instruments representing a sum of rights of the investor vis-a-vis the issuer.
    /// </summary>
    [IsoId("_QRwG4o0bEemUAO64Q252gQ")]
    [DisplayName("Financial Instrument Identification")]
    [IsoXmlTag("FinInstrmId")]
    public required SecurityIdentification19 FinancialInstrumentIdentification { get; init; } 
    
    /// <summary>
    /// Ranking of the top financial instruments with the highest rate of settlement fails.
    /// </summary>
    [IsoId("_BnlYgY0bEemUAO64Q252gQ")]
    [DisplayName("Rank")]
    [IsoXmlTag("Rank")]
    [IsoSimpleType(IsoSimpleType.Max2NumericText)]
    public required IsoMax2NumericText Rank { get; init; } 
    
    
    #nullable disable
    
}
