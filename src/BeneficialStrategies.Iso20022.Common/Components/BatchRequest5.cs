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
/// Data to request a batch service.
/// </summary>
[IsoId("_PiJcMXGyEe2TbaNWBpRZpQ")]
[DisplayName("Batch Request")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record BatchRequest5
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Sale System identification of the batch in an unambiguous way.
    /// </summary>
    [IsoId("_PoYAAXGyEe2TbaNWBpRZpQ")]
    [DisplayName("Sale Batch Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SaleBtchId")]
    #endif
    [IsoXmlTag("SaleBtchId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TransactionIdentifier1? SaleBatchIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransactionIdentifier1? SaleBatchIdentification { get; init; } 
    #else
    public TransactionIdentifier1? SaleBatchIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Flag to remove all the transactions.
    /// </summary>
    [IsoId("_PoYAA3GyEe2TbaNWBpRZpQ")]
    [DisplayName("Remove All Flag")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RmvAllFlg")]
    #endif
    [IsoXmlTag("RmvAllFlg")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? RemoveAllFlag { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? RemoveAllFlag { get; init; } 
    #else
    public System.String? RemoveAllFlag { get; set; } 
    #endif
    
    /// <summary>
    /// Content of the Batch Request message.
    /// </summary>
    [IsoId("_PoYABXGyEe2TbaNWBpRZpQ")]
    [DisplayName("Transaction To Perform")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxToPrfrm")]
    #endif
    [IsoXmlTag("TxToPrfrm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TransactionToPerform5Choice_? TransactionToPerform { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransactionToPerform5Choice_? TransactionToPerform { get; init; } 
    #else
    public TransactionToPerform5Choice_? TransactionToPerform { get; set; } 
    #endif
    
    
    #nullable disable
    
}
