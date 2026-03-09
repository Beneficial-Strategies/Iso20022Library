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
[IsoId("_Ku5_KZRwEeaIOYt3E5eJjQ")]
[DisplayName("Contract Valuation Data")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ContractValuationData3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Mark to market valuation of the contract, or mark to model valuation. The CCP’s valuation to be used for a cleared trade.
    /// </summary>
    [IsoId("_K5e3cZRwEeaIOYt3E5eJjQ")]
    [DisplayName("Contract Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtrctVal")]
    #endif
    [IsoXmlTag("CtrctVal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection54? ContractValue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection54? ContractValue { get; init; } 
    #else
    public AmountAndDirection54? ContractValue { get; set; } 
    #endif
    
    /// <summary>
    /// Date and time of the last valuation.
    /// Usage: For mark-to-market valuation the date and time of publishing of reference prices shall be reported.
    /// </summary>
    [IsoId("_K5e3c5RwEeaIOYt3E5eJjQ")]
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
    /// Indicate whether valuation was performed mark to market, mark to model or provided by the CCP.
    /// </summary>
    [IsoId("_K5e3dZRwEeaIOYt3E5eJjQ")]
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
