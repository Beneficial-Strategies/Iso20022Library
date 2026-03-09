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
/// Reports on transactions.
/// </summary>
[IsoId("_7tkDpQKxEe2rHs6fbn9-0A")]
[DisplayName("Transactions")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Transactions10
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Common detailed payment instruction information.
    /// </summary>
    [IsoId("_8Wpc5wKxEe2rHs6fbn9-0A")]
    [DisplayName("Payment Common Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PmtCmonInf")]
    #endif
    [IsoXmlTag("PmtCmonInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PaymentCommon5? PaymentCommonInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PaymentCommon5? PaymentCommonInformation { get; init; } 
    #else
    public PaymentCommon5? PaymentCommonInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the total number and sum of the transactions.
    /// </summary>
    [IsoId("_8Wpc6QKxEe2rHs6fbn9-0A")]
    [DisplayName("Transactions Summary")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxsSummry")]
    #endif
    [IsoXmlTag("TxsSummry")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public NumberAndSumOfTransactions2? TransactionsSummary { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public NumberAndSumOfTransactions2? TransactionsSummary { get; init; } 
    #else
    public NumberAndSumOfTransactions2? TransactionsSummary { get; set; } 
    #endif
    
    /// <summary>
    /// Reports either on the transaction information or on a business error.
    /// </summary>
    [IsoId("_8Wpc6wKxEe2rHs6fbn9-0A")]
    [DisplayName("Transaction Report")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxRpt")]
    #endif
    [IsoXmlTag("TxRpt")]
    public ValueList<TransactionReport7> TransactionReport { get; init; } = new ValueList<TransactionReport7>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _8Wpc6wKxEe2rHs6fbn9-0A
    
    
    #nullable disable
    
}
