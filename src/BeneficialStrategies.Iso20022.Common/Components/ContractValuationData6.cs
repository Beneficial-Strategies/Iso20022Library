// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to contract valuation.
/// </summary>
[IsoId("_KdqEsVfnEeqfKIw9ojIoIw")]
[DisplayName("Contract Valuation Data")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ContractValuationData6
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies the current value of the outstanding contract.
    /// </summary>
    [IsoId("_KxveU1fnEeqfKIw9ojIoIw")]
    [DisplayName("Contract Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtrctVal")]
    #endif
    [IsoXmlTag("CtrctVal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection106? ContractValue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection106? ContractValue { get; init; } 
    #else
    public AmountAndDirection106? ContractValue { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the date and time of the last valuation marked to market provided by the central counterparty (CCP) or calculated using the current or last available market price of the inputs.
    /// </summary>
    [IsoId("_KxveVVfnEeqfKIw9ojIoIw")]
    [DisplayName("Time Stamp")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TmStmp")]
    #endif
    [IsoXmlTag("TmStmp")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODateTime? TimeStamp { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime? TimeStamp { get; init; } 
    #else
    public System.DateTime? TimeStamp { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the source and method used for the valuation of the transaction by the reporting counterparty.
    /// Usage:
    /// If at least one valuation input is used that is classified as mark-to-model, the whole valuation is classified as mark-to-model.
    /// If only inputs are used that are classified as mark-to-market; the whole valuation is classified as mark-to-market.|
    /// </summary>
    [IsoId("_KxveV1fnEeqfKIw9ojIoIw")]
    [DisplayName("Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tp")]
    #endif
    [IsoXmlTag("Tp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ValuationType1Code? Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ValuationType1Code? Type { get; init; } 
    #else
    public ValuationType1Code? Type { get; set; } 
    #endif
    
    
    #nullable disable
    
}
