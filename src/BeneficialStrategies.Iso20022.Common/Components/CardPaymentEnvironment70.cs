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
[IsoId("_U3RGEdwhEeeKpa-yxjuKzQ")]
[DisplayName("Card Payment Environment")]
public partial record CardPaymentEnvironment70
{
    #nullable enable
    
    /// <summary>
    /// Acquirer involved in the card payment transactions.
    /// </summary>
    [IsoId("_VAVigdwhEeeKpa-yxjuKzQ")]
    [DisplayName("Acquirer")]
    [IsoXmlTag("Acqrr")]
    public Acquirer5? Acquirer { get; init; } 
    
    /// <summary>
    /// Merchant performing the card payment transactions.
    /// Usage: In some cases, merchant and acceptor may be regarded as the same entity.
    /// </summary>
    [IsoId("_VAVig9whEeeKpa-yxjuKzQ")]
    [DisplayName("Merchant")]
    [IsoXmlTag("Mrchnt")]
    public Organisation9? Merchant { get; init; } 
    
    /// <summary>
    /// Point of interaction (POI) performing the transaction.
    /// </summary>
    [IsoId("_VAVihdwhEeeKpa-yxjuKzQ")]
    [DisplayName("POI")]
    [IsoXmlTag("POI")]
    public PointOfInteraction8? POI { get; init; } 
    
    
    #nullable disable
    
}
