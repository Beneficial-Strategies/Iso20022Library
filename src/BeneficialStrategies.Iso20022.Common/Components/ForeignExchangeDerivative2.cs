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
/// Foreign Exchange Derivative which is either deliverable or non-deliverable.
/// </summary>
[IsoId("_TzPS8X5iEeaGiOUFl5b1oQ")]
[DisplayName("Foreign Exchange Derivative")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ForeignExchangeDerivative2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ForeignExchangeDerivative2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ForeignExchangeDerivative2( AssetClassSubProductType19Code reqContractSubType )
    {
        ContractSubType = reqContractSubType;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of deliverable and non-deliverable forwards, options and swaps contract.	.
    /// </summary>
    [IsoId("_UA7JoX5iEeaGiOUFl5b1oQ")]
    [DisplayName("Contract Sub Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtrctSubTp")]
    #endif
    [IsoXmlTag("CtrctSubTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AssetClassSubProductType19Code ContractSubType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AssetClassSubProductType19Code ContractSubType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AssetClassSubProductType19Code ContractSubType { get; init; } 
    #else
    public AssetClassSubProductType19Code ContractSubType { get; set; } 
    #endif
    
    
    #nullable disable
    
}
