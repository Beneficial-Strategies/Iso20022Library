// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Environment common to a collection of transactions.
/// </summary>
[IsoId("__dA7YQvYEeKzJ69IWwzB9Q")]
[DisplayName("Card Payment Environment")]
public partial record CardPaymentEnvironment13
{
    #nullable enable
    
    /// <summary>
    /// Acquirer involved in the card payment transactions.
    /// </summary>
    [IsoId("__ow4YQvYEeKzJ69IWwzB9Q")]
    [DisplayName("Acquirer")]
    [IsoXmlTag("Acqrr")]
    public Acquirer3? Acquirer { get; init; } 
    
    /// <summary>
    /// Merchant performing the card payment transactions.
    /// Usage: In some cases, merchant and acceptor may be regarded as the same entity.
    /// </summary>
    [IsoId("__ow4ZQvYEeKzJ69IWwzB9Q")]
    [DisplayName("Merchant")]
    [IsoXmlTag("Mrchnt")]
    public Organisation9? Merchant { get; init; } 
    
    /// <summary>
    /// Point of interaction (POI) performing the transaction.
    /// </summary>
    [IsoId("__ow4aQvYEeKzJ69IWwzB9Q")]
    [DisplayName("POI")]
    [IsoXmlTag("POI")]
    public PointOfInteraction2? POI { get; init; } 
    
    
    #nullable disable
    
}
