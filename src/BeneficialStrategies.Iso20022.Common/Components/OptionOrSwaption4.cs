// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Option or swaption related attributes.
/// </summary>
[IsoId("_5YqYgagAEeW_OId9wS8dsQ")]
[DisplayName("Option Or Swaption")]
public partial record OptionOrSwaption4
{
    #nullable enable
    
    /// <summary>
    /// Specifies the type of the Option whether it is a call option (right to purchase a specific underlying asset) or a put option (right to sell a specific underlying asset).
    /// </summary>
    [IsoId("_5xdTAagAEeW_OId9wS8dsQ")]
    [DisplayName("Option Type")]
    [IsoXmlTag("OptnTp")]
    public OptionType2Code? OptionType { get; init; } 
    
    /// <summary>
    /// Predetermined price at which the holder will have to buy or sell the underlying instrument.
    /// </summary>
    [IsoId("_5xdTA6gAEeW_OId9wS8dsQ")]
    [DisplayName("Strike Price")]
    [IsoXmlTag("StrkPric")]
    public SecuritiesTransactionPrice3Choice_? StrikePrice { get; init; } 
    
    /// <summary>
    /// Indication as to whether the option may be exercised only at a fixed date (European, and Asian style), a series of pre-specified dates (Bermudan) or at any time during the life of the contract (American style). This field does not have to be populated for ISIN instruments.
    /// </summary>
    [IsoId("_5xdTB6gAEeW_OId9wS8dsQ")]
    [DisplayName("Option Exercise Style")]
    [IsoXmlTag("OptnExrcStyle")]
    public OptionStyle6Code? OptionExerciseStyle { get; init; } 
    
    /// <summary>
    /// In case of swaptions, maturity date of the underlying swap.
    /// </summary>
    [IsoId("_5xdTCagAEeW_OId9wS8dsQ")]
    [DisplayName("Maturity Date Of Underlying")]
    [IsoXmlTag("MtrtyDtOfUndrlyg")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? MaturityDateOfUnderlying { get; init; } 
    
    
    #nullable disable
    
}
