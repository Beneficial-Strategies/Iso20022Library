// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Parameters for contracts which obligate the buyer to receive and the seller to deliver in the future the assets specified at an agreed price.
/// </summary>
[IsoId("_12okUWp7EemmaZLSPtWX5A")]
[DisplayName("Future")]
public partial record Future4
{
    #nullable enable
    
    /// <summary>
    /// Ratio or multiplying factor used to convert one contract into a quantity.
    /// </summary>
    [IsoId("_2CcLsWp7EemmaZLSPtWX5A")]
    [DisplayName("Contract Size")]
    [IsoXmlTag("CtrctSz")]
    [IsoSimpleType(IsoSimpleType.BaseOneRate)]
    public IsoBaseOneRate? ContractSize { get; init; } 
    
    /// <summary>
    /// Predetermined price at which the holder of a Future will have to buy or sell the underlying instrument.
    /// </summary>
    [IsoId("_2CcLs2p7EemmaZLSPtWX5A")]
    [DisplayName("Exercise Price")]
    [IsoXmlTag("ExrcPric")]
    public Price8? ExercisePrice { get; init; } 
    
    /// <summary>
    /// Date on which future contracts settle.
    /// </summary>
    [IsoId("_2CcLtWp7EemmaZLSPtWX5A")]
    [DisplayName("Future Date")]
    [IsoXmlTag("FutrDt")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? FutureDate { get; init; } 
    
    /// <summary>
    /// Specifies the minimum ratio or multiply factor used to convert from contracts to shares.
    /// </summary>
    [IsoId("_2CcLt2p7EemmaZLSPtWX5A")]
    [DisplayName("Minimum Size")]
    [IsoXmlTag("MinSz")]
    public ActiveCurrencyAndAmount? MinimumSize { get; init; } 
    
    /// <summary>
    /// Used to indicate the measurement unit of the underlying commodity on which the contract is based (for example, 2500 lbs of lean cattle, 1000 barrels of crude oil, 1000 bushels of corn, etc.).
    /// </summary>
    [IsoId("_2CcLuWp7EemmaZLSPtWX5A")]
    [DisplayName("Unit Of Measure")]
    [IsoXmlTag("UnitOfMeasr")]
    public UnitOfMeasure7Choice_? UnitOfMeasure { get; init; } 
    
    /// <summary>
    /// Used to indicate a time unit for the contract (for example days, weeks, months, etc.).
    /// </summary>
    [IsoId("_2CcLwWp7EemmaZLSPtWX5A")]
    [DisplayName("Time Unit")]
    [IsoXmlTag("TmUnit")]
    public TimeUnit3Choice_? TimeUnit { get; init; } 
    
    /// <summary>
    /// Provides more information about the underlying instrument.
    /// </summary>
    [IsoId("_2CcLyWp7EemmaZLSPtWX5A")]
    [DisplayName("Additional Underlying Attributes")]
    [IsoXmlTag("AddtlUndrlygAttrbts")]
    public UnderlyingAttributes4? AdditionalUnderlyingAttributes { get; init; } 
    
    
    #nullable disable
    
}
