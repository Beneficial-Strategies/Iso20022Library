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
/// Set of elements used to identify the underlying (group of) transaction(s) to which the investigation applies.
/// </summary>
[IsoId("_PmstQtp-Ed-ak6NoX_4Aeg_-1329439131")]
[DisplayName("Underlying Transaction")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record UnderlyingTransaction2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Set of elements used to provide information on the original messsage, to which the cancellation refers.
    /// </summary>
    [IsoId("_PmstQ9p-Ed-ak6NoX_4Aeg_-1329439038")]
    [DisplayName("Original Group Information And Cancellation")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlGrpInfAndCxl")]
    #endif
    [IsoXmlTag("OrgnlGrpInfAndCxl")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OriginalGroupInformation23? OriginalGroupInformationAndCancellation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OriginalGroupInformation23? OriginalGroupInformationAndCancellation { get; init; } 
    #else
    public OriginalGroupInformation23? OriginalGroupInformationAndCancellation { get; set; } 
    #endif
    
    /// <summary>
    /// Set of elements used to provide information on the original transactions to which the cancellation request message refers.
    /// </summary>
    [IsoId("_PmstRNp-Ed-ak6NoX_4Aeg_-1329438698")]
    [DisplayName("Transaction Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxInf")]
    #endif
    [IsoXmlTag("TxInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PaymentTransactionInformation31? TransactionInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PaymentTransactionInformation31? TransactionInformation { get; init; } 
    #else
    public PaymentTransactionInformation31? TransactionInformation { get; set; } 
    #endif
    
    
    #nullable disable
    
}
