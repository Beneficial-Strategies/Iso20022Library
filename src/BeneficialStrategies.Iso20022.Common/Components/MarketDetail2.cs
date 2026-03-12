// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details specific to a market including which market identification and average number of transactions on the venue.
/// </summary>
[IsoId("_1Jjy4X5sEeasY4u9QTizPQ")]
[DisplayName("Market Detail")]
public partial record MarketDetail2
{
    #nullable enable
    
    /// <summary>
    /// Most relevant market in terms of liquidity as defined in the local regulation.
    /// </summary>
    [IsoId("_1WD9035sEeasY4u9QTizPQ")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.MICIdentifier)]
    public required IsoMICIdentifier Identification { get; init; } 
    
    /// <summary>
    /// Average daily number of transactions that have been performed on the most relevant market in terms of liquidity.
    /// </summary>
    [IsoId("_1WD91X5sEeasY4u9QTizPQ")]
    [DisplayName("Average Daily Number Of Transactions")]
    [IsoXmlTag("AvrgDalyNbOfTxs")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? AverageDailyNumberOfTransactions { get; init; } 
    
    
    #nullable disable
    
}
