// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to contract valuation.
/// </summary>
[IsoId("_KdqEsVfnEeqfKIw9ojIoIw")]
[DisplayName("Contract Valuation Data")]
public partial record ContractValuationData6
{
    #nullable enable
    
    /// <summary>
    /// Specifies the current value of the outstanding contract.
    /// </summary>
    [IsoId("_KxveU1fnEeqfKIw9ojIoIw")]
    [DisplayName("Contract Value")]
    [IsoXmlTag("CtrctVal")]
    public AmountAndDirection106? ContractValue { get; init; } 
    
    /// <summary>
    /// Indicates the date and time of the last valuation marked to market provided by the central counterparty (CCP) or calculated using the current or last available market price of the inputs.
    /// </summary>
    [IsoId("_KxveVVfnEeqfKIw9ojIoIw")]
    [DisplayName("Time Stamp")]
    [IsoXmlTag("TmStmp")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? TimeStamp { get; init; } 
    
    /// <summary>
    /// Indicates the source and method used for the valuation of the transaction by the reporting counterparty.
    /// Usage:
    /// If at least one valuation input is used that is classified as mark-to-model, the whole valuation is classified as mark-to-model.
    /// If only inputs are used that are classified as mark-to-market; the whole valuation is classified as mark-to-market.|
    /// </summary>
    [IsoId("_KxveV1fnEeqfKIw9ojIoIw")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public ValuationType1Code? Type { get; init; } 
    
    
    #nullable disable
    
}
