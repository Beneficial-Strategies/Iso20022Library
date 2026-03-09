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
[IsoId("_rIFrmUDWEeWOL-OsSq2h6w")]
[DisplayName("Contract Valuation Data")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ContractValuationData2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ContractValuationData2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ContractValuationData2( AmountAndDirection54 reqContractValue,System.DateTime reqTimeStamp,ValuationType1Code reqType )
    {
        ContractValue = reqContractValue;
        TimeStamp = reqTimeStamp;
        Type = reqType;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Mark to market valuation of the contract, or mark to model valuation. The CCP’s valuation to be used for a cleared trade.
    /// </summary>
    [IsoId("_rS83wUDWEeWOL-OsSq2h6w")]
    [DisplayName("Contract Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtrctVal")]
    #endif
    [IsoXmlTag("CtrctVal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AmountAndDirection54 ContractValue { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AmountAndDirection54 ContractValue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection54 ContractValue { get; init; } 
    #else
    public AmountAndDirection54 ContractValue { get; set; } 
    #endif
    
    /// <summary>
    /// Date and time of the last valuation.
    /// Usage: For mark-to-market valuation the date and time of publishing of reference prices shall be reported.
    /// </summary>
    [IsoId("_rS83w0DWEeWOL-OsSq2h6w")]
    [DisplayName("Time Stamp")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TmStmp")]
    #endif
    [IsoXmlTag("TmStmp")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODateTime TimeStamp { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.DateTime TimeStamp { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime TimeStamp { get; init; } 
    #else
    public System.DateTime TimeStamp { get; set; } 
    #endif
    
    /// <summary>
    /// Indicate whether valuation was performed mark to market, mark to model or provided by the CCP.
    /// </summary>
    [IsoId("_rS83xUDWEeWOL-OsSq2h6w")]
    [DisplayName("Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tp")]
    #endif
    [IsoXmlTag("Tp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ValuationType1Code Type { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ValuationType1Code Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ValuationType1Code Type { get; init; } 
    #else
    public ValuationType1Code Type { get; set; } 
    #endif
    
    
    #nullable disable
    
}
