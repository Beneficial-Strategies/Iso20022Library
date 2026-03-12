// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about funds that have been arrested.
/// </summary>
[IsoId("_Qpd4YBt3Eeaiht5D4a9WSA")]
[DisplayName("Arrested Funds")]
public partial record ArrestedFunds1
{
    #nullable enable
    
    /// <summary>
    /// Identification of the arrest order assigned by the account servicer.
    /// </summary>
    [IsoId("_W_XnACG4EeaZx5-Tw7BKeQ")]
    [DisplayName("Arrest Identification")]
    [IsoXmlTag("ArrstId")]
    [IsoSimpleType(IsoSimpleType.Max10Text)]
    [StringLength(maximumLength: 10 ,MinimumLength = 1)]
    public IsoMax10Text? ArrestIdentification { get; init; } 
    
    /// <summary>
    /// Total amount owed subject to arrest.
    /// </summary>
    [IsoId("_fvCwYBt3Eeaiht5D4a9WSA")]
    [DisplayName("Total Amount")]
    [IsoXmlTag("TtlAmt")]
    public ActiveCurrencyAndAmount? TotalAmount { get; init; } 
    
    /// <summary>
    /// Remaining unpaid amount out of total amount owed subject to arrest.
    /// </summary>
    [IsoId("_yfPgABt3Eeaiht5D4a9WSA")]
    [DisplayName("Remaining Unpaid Amount")]
    [IsoXmlTag("RmngUnpdAmt")]
    public required ActiveCurrencyAndAmount RemainingUnpaidAmount { get; init; } 
    
    /// <summary>
    /// Funds blocked for settlement of the arrest order.
    /// </summary>
    [IsoId("_qz16kBt3Eeaiht5D4a9WSA")]
    [DisplayName("Arrested Amount")]
    [IsoXmlTag("ArrstdAmt")]
    public ActiveCurrencyAndAmount? ArrestedAmount { get; init; } 
    
    
    #nullable disable
    
}
